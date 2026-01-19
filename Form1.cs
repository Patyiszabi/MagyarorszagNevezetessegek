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
        private class Nevezetesseg
        {
            public string Nev { get; set; }
            public string Leiras { get; set; }
            public string Helyszin {get; set; }
            public string TurizmusTipus {get; set; }
            public string KepFajlNev {get; set; }

            public Nevezetesseg(string nev, string leiras, string helyszin, string turizmusTipus, string kepFajlNev)
            {
                Nev = nev;
                Leiras = leiras;
                Helyszin = helyszin;
                TurizmusTipus = turizmusTipus;
                KepFajlNev = kepFajlNev;
            }
        }

        private readonly List<Nevezetesseg> nevezetessegek = new List<Nevezetesseg>();
        private readonly List<Nevezetesseg> szurtLista = new List<Nevezetesseg>();

        private readonly string dataFilePath = "magyarorszag_nevezetessegek.txt";

        private readonly Dictionary<string, byte[]> kepCache = new Dictionary<string, byte[]>();
        private static readonly HttpClient http = new HttpClient();

       

        // asnyc 
        private int kepKeresSorszam = 0;

        public MagyarorszagNevezetessegekForm()
        {
            InitializeComponent();
            this.Load += MagyarorszagNevezetessegekForm_Load;
        }


        private void MagyarorszagNevezetessegekForm_Load(object sender, EventArgs e)
        {
            filterComboBox.Items.Clear();
            filterComboBox.Items.Add("Név (ABC)");
            filterComboBox.Items.Add("Helyszín");
            filterComboBox.Items.Add("Turizmus típus");
            filterComboBox.SelectedIndex = 0;
            nevezetessegek.Clear();

            if (!File.Exists(dataFilePath))
            {
                MessageBox.Show("Hiányzik az adatfájl: " + dataFilePath + Environment.NewLine,
                                "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] sorok = File.ReadAllLines(dataFilePath, Encoding.UTF8);

            for (int i = 1; i < sorok.Length; i++)
            {
                string sor = sorok[i].Trim();
                if (sor.Length == 0) continue;

                string[] p = sor.Split(new char[] { '&' }, 5);

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

                Szures();
            }
        }


        private void Szures()
        {
            string keres = searchTextBox.Text.Trim();

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

            int mode = filterComboBox.SelectedIndex;
            szurtLista.Sort((a, b) =>
            {
                if (mode == 1) return string.Compare(a.Helyszin, b.Helyszin, StringComparison.OrdinalIgnoreCase);
                if (mode == 2) return string.Compare(a.TurizmusTipus, b.TurizmusTipus, StringComparison.OrdinalIgnoreCase);
                return string.Compare(a.Nev, b.Nev, StringComparison.OrdinalIgnoreCase);
            });

            listBox1.BeginUpdate();
            listBox1.Items.Clear();
            for (int i = 0; i < szurtLista.Count; i++)
            {
                listBox1.Items.Add(szurtLista[i].Nev);
            }
            listBox1.EndUpdate();

            if (listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = 0;
            }
            else
            {
                kartyaUrites("Nincs találat.");
            }
        }

        private void kartyaUrites(string uzenet)
        {
            nevValueLabel.Text = "-";
            helyszinValueLabel.Text = "-";
            turizmus_tipusValueLabel.Text = "-";
            leirasPreviewTextBox.Text = uzenet;

            kepTorles();
        }

     

        private void kepTorles()
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
            int idx = listBox1.SelectedIndex;
            if (idx < 0 || idx >= szurtLista.Count) return;

            Nevezetesseg n = szurtLista[idx];

            nevValueLabel.Text = n.Nev;
            helyszinValueLabel.Text = n.Helyszin;
            turizmus_tipusValueLabel.Text = n.TurizmusTipus;
            leirasPreviewTextBox.Text = leiras(n.Leiras, 220);



            await kepBetoltes(n.KepFajlNev);
        }
        private string leiras(string szoveg, int maxHossz)
        {
            if (szoveg == null) return "";
            string s = szoveg.Trim();
            if (s.Length <= maxHossz) return s;
            return s.Substring(0, maxHossz) + "...";
        }


        private async Task kepBetoltes(string url)
        {
            kepKeresSorszam++;
            int mostani = kepKeresSorszam;

            kepTorles();

            if (string.IsNullOrWhiteSpace(url))
            {
                return;
            }

            if (url.EndsWith(".webp", StringComparison.OrdinalIgnoreCase))
            {
                leirasPreviewTextBox.Text = leirasPreviewTextBox.Text + Environment.NewLine +
                                            "(A kép WEBP formátumú, cserélje JPG/PNG-re a txt-ben.)";
                return;
            }

            try
            {
                byte[] data;

                if (kepCache.ContainsKey(url))
                {
                    data = kepCache[url];
                }
                else
                {
                    data = await http.GetByteArrayAsync(url);
                    kepCache[url] = data;
                }

                if (mostani != kepKeresSorszam) return;

                using (var ms = new MemoryStream(data))
                {
                    Image img = Image.FromStream(ms);

                    pictureBox1.Image = (Image)img.Clone();
                    img.Dispose();
                }
            }
            catch
            {
                MessageBox.Show("Hiba a kép betöltésekor: " + url, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            Szures();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Szures();
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            int idx = listBox1.SelectedIndex;
            if (idx < 0 || idx >= szurtLista.Count) return;

            Nevezetesseg n = szurtLista[idx];
            NevezetessegReszletekForm f = new NevezetessegReszletekForm(this, n.Nev, n.Leiras, n.Helyszin, n.TurizmusTipus, n.KepFajlNev);
            f.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
