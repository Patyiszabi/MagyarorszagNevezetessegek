using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagyarorszagNevezetessegek
{
    public partial class MagyarorszagNevezetessegekForm : Form
    {
        private readonly List<Nevezetesseg> nevezetessegek = new List<Nevezetesseg>();
        private readonly List<Nevezetesseg> szurtLista = new List<Nevezetesseg>();

        private readonly string dataFilePath = Path.Combine(Application.StartupPath, "magyarorszag_nevezetessegek.txt");

        // Kép cache (hogy ne töltse le mindig újra)
        private readonly Dictionary<string, Image> kepCache = new Dictionary<string, Image>();

        // Ha gyorsan kattintgat a user, ne keveredjenek a képek
        private int aktualisKepKeresId = 0;

        public MagyarorszagNevezetessegekForm()
        {
            InitializeComponent();

            // UI alap beállítások
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            filterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // Események
            this.Load += MagyarorszagNevezetessegekForm_Load;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            filterComboBox.SelectedIndexChanged += filterComboBox_SelectedIndexChanged;
            exitButton.Click += exitButton_Click;
            detailsButton.Click += detailsButton_Click;
        }

        public class Nevezetesseg
        {
            public string Nev { get; set; }
            public string Leiras { get; set; }
            public string Helyszin { get; set; }
            public string TurizmusTipus { get; set; }
            public string KepFajlNev { get; set; } // nálad URL van a txt-ben, ezért oké így is

            public Nevezetesseg(string nev, string leiras, string helyszin, string turizmusTipus, string kepFajlNev)
            {
                Nev = nev;
                Leiras = leiras;
                Helyszin = helyszin;
                TurizmusTipus = turizmusTipus;
                KepFajlNev = kepFajlNev;
            }
        }

        private void MagyarorszagNevezetessegekForm_Load(object sender, EventArgs e)
        {
            FeltoltRendezesCombo();
            BetoltAdatokTxtbol();
            AlkalmazSzuresEsRendezes();
        }

        private void FeltoltRendezesCombo()
        {
            filterComboBox.Items.Clear();
            filterComboBox.Items.Add("Név (ABC)");
            filterComboBox.Items.Add("Helyszín");
            filterComboBox.Items.Add("Turizmus típus");
            filterComboBox.SelectedIndex = 0;
        }

        private void BetoltAdatokTxtbol()
        {
            nevezetessegek.Clear();

            if (!File.Exists(dataFilePath))
            {
                MessageBox.Show("Nem található az adatfájl:\n" + dataFilePath, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] sorok = File.ReadAllLines(dataFilePath, Encoding.UTF8);

            // 0. sor fejléc: Nev&Leiras&Helyszin&TurizmusTipus&KepFajlNev
            for (int i = 1; i < sorok.Length; i++)
            {
                string sor = sorok[i].Trim();
                if (sor.Length == 0) continue;

                string[] p = sor.Split('&');

                // Ha a sor végén van felesleges "&", akkor a split adhat üres utolsó elemet
                int n = p.Length;
                if (n > 0 && p[n - 1].Trim().Length == 0) n--;

                if (n < 5) continue;

                string nev = p[0].Trim();
                string leiras = p[1].Trim();
                string helyszin = p[2].Trim();
                string tipus = p[3].Trim();
                string kepUrl = p[4].Trim();

                if (nev.Length == 0) continue;

                nevezetessegek.Add(new Nevezetesseg(nev, leiras, helyszin, tipus, kepUrl));
            }
        }

        private void AlkalmazSzuresEsRendezes()
        {
            string keres = searchTextBox.Text.Trim();

            // Szűrés (LINQ nélkül)
            szurtLista.Clear();
            for (int i = 0; i < nevezetessegek.Count; i++)
            {
                Nevezetesseg n = nevezetessegek[i];

                if (keres.Length == 0)
                {
                    szurtLista.Add(n);
                }
                else
                {
                    if (n.Nev != null && n.Nev.IndexOf(keres, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        szurtLista.Add(n);
                    }
                }
            }

            // Rendezés
            int mode = filterComboBox.SelectedIndex;
            szurtLista.Sort((a, b) =>
            {
                if (mode == 1) return string.Compare(a.Helyszin, b.Helyszin, StringComparison.OrdinalIgnoreCase);
                if (mode == 2) return string.Compare(a.TurizmusTipus, b.TurizmusTipus, StringComparison.OrdinalIgnoreCase);
                return string.Compare(a.Nev, b.Nev, StringComparison.OrdinalIgnoreCase);
            });

            // ListBox frissítés
            listBox1.BeginUpdate();
            listBox1.Items.Clear();
            for (int i = 0; i < szurtLista.Count; i++)
            {
                listBox1.Items.Add(szurtLista[i].Nev);
            }
            listBox1.EndUpdate();

            if (listBox1.Items.Count > 0)
                listBox1.SelectedIndex = 0;
            else
                UritKartya();
        }

        private void UritKartya()
        {
            nevValueLabel.Text = "-";
            leirasValueLabel.Text = "-";
            helyszinValueLabel.Text = "-";
            turizmus_tipusValueLabel.Text = "-";
            KepTorles();
        }

        private void KepTorles()
        {
            if (pictureBox1.Image != null)
            {
                Image regi = pictureBox1.Image;
                pictureBox1.Image = null;
                regi.Dispose();
            }
        }

        private async void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index < 0 || index >= szurtLista.Count) return;

            Nevezetesseg n = szurtLista[index];

            nevValueLabel.Text = n.Nev;
            leirasValueLabel.Text = n.Leiras;
            helyszinValueLabel.Text = n.Helyszin;
            turizmus_tipusValueLabel.Text = n.TurizmusTipus;

            await KepBetoltesUrlrol(n.KepFajlNev);
        }

        private async Task KepBetoltesUrlrol(string url)
        {
            KepTorles();

            if (string.IsNullOrWhiteSpace(url))
                return;

            // ID növelés, hogy a régi letöltések ne írják felül az újat
            int myId = ++aktualisKepKeresId;

            // memória cache
            if (kepCache.ContainsKey(url))
            {
                // klón, hogy a UI Dispose ne ölje meg a cache példányt
                pictureBox1.Image = (Image)kepCache[url].Clone();
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    byte[] data = await client.GetByteArrayAsync(url);

                    // Ha közben másik képet kértek, ezt eldobjuk
                    if (myId != aktualisKepKeresId) return;

                    using (MemoryStream ms = new MemoryStream(data))
                    {
                        Image img = Image.FromStream(ms);

                        // cache-be eredeti klón
                        kepCache[url] = (Image)img.Clone();

                        // UI-ba külön klón
                        pictureBox1.Image = (Image)img.Clone();
                        img.Dispose();
                    }
                }
            }
            catch
            {
                // Ha nem jön le a kép, ne omoljon össze
                // Marad üresen a PictureBox
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            AlkalmazSzuresEsRendezes();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AlkalmazSzuresEsRendezes();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index < 0 || index >= szurtLista.Count) return;

            Nevezetesseg n = szurtLista[index];

            MessageBox.Show(
                "Név: " + n.Nev + "\n\n"
                + "Helyszín: " + n.Helyszin + "\n"
                + "Turizmus típus: " + n.TurizmusTipus + "\n\n"
                + "Leírás:\n" + n.Leiras,
                "További részletek",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
