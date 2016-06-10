using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ORIGO
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            Settings.Load();
        }

        public void sprawdzpliki()
        {
            string featureList = null;

            if (!File.Exists("baza.txt"))
            {
                MessageBox.Show("NIE ZNALEZIONO PLIKU baza.txt! \nNASTĘPUJE TWORZENIE PUSTEGO PLIKU!\nJEŚLI TO NIE JEST PIERWSZE OTWARCIE PROGRAMU, ODZYSKAJ POPRZEDNIĄ WERSJĘ BAZY DANYCH NATYCHMIAST!");
                using (StreamWriter sw = File.CreateText("baza.txt"))
                {
                    sw.Write("");
                }
            }

            if (!File.Exists("notatnik.txt"))
            {
                MessageBox.Show("NIE ZNALEZIONO PLIKU notatnik.txt! \nNASTĘPUJE TWORZENIE PUSTEGO PLIKU!\n");
                using (StreamWriter sw = File.CreateText("notatnik.txt"))
                {
                    sw.Write("");
                }
            }

            if (!File.Exists("main.txt"))
            {
                MessageBox.Show("Nie znaleziono pliku main.txt! \nSkontaktuj się z twórcą programu.");
            }
            else
            {
                System.IO.StreamReader file = new System.IO.StreamReader("main.txt");

                featureList = file.ReadToEnd();
                file.Close();
            }
            richTextBox1.Text = featureList;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            BazaPiesni bazaPiesni = new BazaPiesni();
            bazaPiesni.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"baza.txt");
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            sprawdzpliki();
        }
        
        

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Kliknij \"Baza Pieśni\" aby przejść dalej.\n\nKliknij \"Plik Bazy\" ";
            message += "aby podejrzeć bazę w notatniku. NIE EDYTUJ!\n\nKliknij \"Ustawienia\" aby przejrzeć możliwe ustawienia programu.\n\nPod przyciskami znajduje się lista ";
            message += "przyszłych funkcji w kolejności w jakiej prawdopodobnie będą wprowadzane jak i lista dotychczasowych zmian.";
            MessageBox.Show(message,"Okno pomocy");
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm ustawienia = new SettingsForm();
            ustawienia.Show();
        }

        private void generatorButt_Click(object sender, EventArgs e)
        {

        }

        private void rebuildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int wielkosc = Piesn.policzBaze();
            Piesn[] nowa = new Piesn[wielkosc];
            wielkoscBazy baza = new wielkoscBazy();
            int i = 0;
            System.IO.StreamReader file = new System.IO.StreamReader("baza.txt");
            string linia;
            while ((linia = file.ReadLine()) != null)
            {
                nowa[i] = Piesn.importujWpisold(linia);
                i++;
                baza.wielkosc = i;
            }

            file.Close();
            Piesn.zapiszBaze(nowa, Piesn.policzBaze());
        }

        private void tabelaChwytówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChordsForm chwyty = new ChordsForm();
            chwyty.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonNotepad_Click(object sender, EventArgs e)
        {
            Notepad notatnik = new Notepad();
            notatnik.Show();
        }
    }
   
}