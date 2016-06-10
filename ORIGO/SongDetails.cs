using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ORIGO
{
    public partial class SongDetails : Form
    {
        private int numer;
        public SongDetails(int index)
        {
            InitializeComponent();
            numer = index;
        }

        private void SongDetails_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajNowa editBox = new DodajNowa(numer);
            editBox.Show();
        }

        private void SongDetails_Activated(object sender, EventArgs e)
        {
            Piesn detale = new Piesn();
            detale = Piesn.importujWpis(Piesn.pobierzLinie(numer));
            labelTytul.Text = detale.nazwa;
            labelTytul.Left = ((this.Width) / 2) - ((labelTytul.Width) / 2);
            if (detale.numer == 0) labelNumer.Text = "BRAK NUMERU W KOMPUTERZE";
            else labelNumer.Text = "NUMER: " + detale.numer.ToString();
            labelNumer.Left = ((this.Width) / 2) - ((labelNumer.Width) / 2);
            richTextBox1.Text = detale.tekst;
        }
    }
}
