using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagyarorszagNevezetessegek
{
    public partial class NevezetessegReszletekForm : Form
    {
        private readonly Form ownerForm;

        private readonly string nev;
        private readonly string leiras;
        private readonly string helyszin;
        private readonly string tipus;
        private readonly string kepUrl;

        private static readonly HttpClient http = new HttpClient();
        private static readonly Dictionary<string, byte[]> kepCache = new Dictionary<string, byte[]>();

        public NevezetessegReszletekForm(Form owner, string nev, string leiras, string helyszin, string tipus, string kepUrl)
        {
            InitializeComponent();

            this.ownerForm = owner;
            this.nev = nev;
            this.leiras = leiras;
            this.helyszin = helyszin;
            this.tipus = tipus;
            this.kepUrl = kepUrl;

            this.FormClosed += NevezetessegReszletekForm_FormClosed;
            this.Load += NevezetessegReszletekForm_Load;
        }




        private void NevezetessegReszletekForm_Load(object sender, EventArgs e)
        {
            nevValueLabel.Text = nev;
            helyszinValueLabel.Text = helyszin;
            turizmusValueLabel.Text = tipus;
            leirasRichTextBox.Text = leiras.Replace("\\n", Environment.NewLine + Environment.NewLine);



            _ = kepBetoltes(kepUrl);
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

        private async Task kepBetoltes(string url)
        {
            kepTorles();

            if (string.IsNullOrWhiteSpace(url)) return;

            if (url.EndsWith(".webp", StringComparison.OrdinalIgnoreCase))
            {
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

                using (var ms = new MemoryStream(data))
                {
                    Image img = Image.FromStream(ms);
                    pictureBox1.Image = (Image)img.Clone();
                    img.Dispose();
                }
            }
            catch
            {

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (ownerForm != null) ownerForm.Show();
            this.Close();
        }

        private void NevezetessegReszletekForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //x
            if (ownerForm != null) ownerForm.Show();
        }
    }
}
