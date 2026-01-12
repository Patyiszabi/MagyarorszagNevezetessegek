using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagyarorszagNevezetessegek
{
    public partial class MagyarorszagNevezetessegekForm : Form
    {
        private readonly List<Nevezetesseg> nevezetessegek = new List<Nevezetesseg>();
        private readonly string dataFilePath = Path.Combine(Application.StartupPath, "magyarorszag_nevezetessegek.txt");

        public MagyarorszagNevezetessegekForm()
        {
            InitializeComponent();
        }


        public class Nevezetesseg
        {
            public string Nev { get; set; }
            public string Leiras { get; set; }
            public string Helyszin { get; set; }
            public string TurizmusTipus { get; set; }
            public string KepFajlNev { get; set; }

            public Nevezetesseg(string nev, string leiras, string helyszin, string turizmusTipus, string kepFajlNev)
            {
                Nev = nev;
                Leiras = leiras;
                Helyszin = helyszin;
                TurizmusTipus = turizmusTipus;
                KepFajlNev = kepFajlNev;
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            // kereso mezo szovegvaltozas kezelese
          
        }
    }
}
