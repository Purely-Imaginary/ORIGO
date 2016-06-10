using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ORIGO
{
    public partial class DodajNowa : Form
    {

        int editIndex = -1;
        int errorCount = 0;
        public Piesn[] bufor = new Piesn[1000];


        public List<string> names = new List<string>();
        private bool duplicateFound = false;

        public List<string> numbers = new List<string>();
        private bool duplicateNumFound = false;

        List<string> listaChwytow = new List<string>();


        public DodajNowa()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            if (Settings.nowaDefaultCheck) nowaBox.Checked = true;
            button3.Hide();

        }
        public DodajNowa(int index)
        {
            InitializeComponent();

            editIndex = index;
            Piesn editable = new Piesn();
            editable = Piesn.importujWpis(Piesn.pobierzLinie(index));
            textBox1.Text = editable.nazwa;
            wejscieBox.Checked = editable.wejscie;
            ofiarowanieBox.Checked = editable.ofiarowanie;
            komuniaBox.Checked = editable.komunia;
            uwielbienieBox.Checked = editable.uwielbienie;
            wyjscieBox.Checked = editable.wyjscie;
            krotkaBox.Checked = editable.krotka;
            sredniaBox.Checked = editable.srednia;
            dlugaBox.Checked = editable.dluga;
            starsiBox.Checked = editable.starsi;
            mlodsiBox.Checked = editable.mlodsi;
            postBox.Checked = editable.post;
            wielkanocBox.Checked = editable.wielkanoc;
            koledyBox.Checked = editable.koledy;
            adwentBox.Checked = editable.adwent;
            maryjneBox.Checked = editable.maryjne;
            zwykleBox.Checked = editable.zwykle;
            nowaBox.Checked = editable.nowa;
            richTextBox1.Text = editable.tekst;
            numerTextbox.Text = editable.numer.ToString();
            szukajChwytow();
            try { sizePicker.Value = decimal.Parse(editable.size); }
            catch { }
            button1.Hide();
            button3.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Piesn nowa = new Piesn();
            int numer = 0;
            if (numerTextbox.Text != "")
                try { numer = int.Parse(numerTextbox.Text); }
                catch { MessageBox.Show("BLEDNY NUMER"); return; }
            nowa.setPiesn(textBox1.Text.ToUpper(), richTextBox1.Text, wejscieBox.Checked, wyjscieBox.Checked,
                komuniaBox.Checked, ofiarowanieBox.Checked, krotkaBox.Checked, sredniaBox.Checked, dlugaBox.Checked,
                starsiBox.Checked, mlodsiBox.Checked, postBox.Checked, wielkanocBox.Checked, koledyBox.Checked,
                adwentBox.Checked, maryjneBox.Checked, zwykleBox.Checked, uwielbienieBox.Checked, nowaBox.Checked,
                listaChwytow, numer , sizePicker.Value.ToString());

            nowa.dopiszElement();

            MessageBox.Show("Dodano wpis do bazy", "Dodano!", MessageBoxButtons.OK);
            this.Close();
        }

        private void sugestiaFonta(int linijki, System.Windows.Forms.Label label)
        {
            if (linijki > 34) label.Text = "<10!";
            else if (linijki > 30) label.Text = "10";
            else if (linijki > 27) label.Text = "11";
            else if (linijki > 24) label.Text = "12-13";
            else if (linijki > 23) label.Text = "14";
            else if (linijki > 21) label.Text = "15";
            else if (linijki > 18) label.Text = "16";
            else if (linijki > 17) label.Text = "17";
            else if (linijki > 16) label.Text = "18";
            else if (linijki > 15) label.Text = "19";
            else if (linijki > 14) label.Text = "20";
            else label.Text = ">20";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            szukajChwytow();
        }

        public void szukajChwytow()
        {
            listaChwytow.Clear();
            string chwytyRazem = "";
            int licznikChwytow = 0;

            int linijki = Regex.Split(richTextBox1.Text, "\n").Length - 1;
            sugestiaFonta(linijki, label5);
            string bufor = richTextBox1.Text.Replace("@", "\n");

            string[] linie = Regex.Split(bufor, "\n");
            foreach (string linia in linie)
            {
                if (linia.Length != 0)
                    if (linia[0] == '/')
                    {
                        chwytyRazem += " " + linia.Substring(1);
                    }
            }
            string[] chwyty = Regex.Split(chwytyRazem, " ");

            foreach (string chwyt in chwyty)
            {
                licznikChwytow++;
                if (!listaChwytow.Contains(chwyt)) listaChwytow.Add(chwyt);
                if (listaChwytow.Contains(""))
                {
                    listaChwytow.Remove("");
                    licznikChwytow--;
                }
                if (listaChwytow.Contains(" "))
                {
                    listaChwytow.Remove(" ");
                    licznikChwytow--;
                }
                if (listaChwytow.Contains(","))
                {
                    listaChwytow.Remove(",");
                    licznikChwytow--;
                }
            }
            textBox2.Text = "";

            foreach (string chwyt in listaChwytow)
            {
                textBox2.Text += chwyt + " ";
            }
            label2.Text = "Chwytów: " + licznikChwytow;
            label3.Text = "Unikalnych: " + listaChwytow.Count;
        }
        public string missingCheck()
        {
            int errorCounter = 0;
            string errorMessage = "";
            if (Settings.errorMessageHandling)
            {
                if (textBox1.Text == "")
                {
                    errorMessage += "Wpisz tytuł pieśni!\n";
                    errorCounter++;
                }

                if (numerTextbox.Text == "")
                {
                    errorMessage += "Wpisz numer pieśni!\n";
                    errorCounter++;
                }

                if (!wejscieBox.Checked && !uwielbienieBox.Checked && !ofiarowanieBox.Checked ||
                    !komuniaBox.Checked && !wyjscieBox.Checked)
                {
                    errorMessage += "Wybierz miejsce w mszy!\n";
                    errorCounter++;
                }

                if (!krotkaBox.Checked && !sredniaBox.Checked && !dlugaBox.Checked)
                {
                    errorMessage += "Ustal długość pieśni!\n";
                    errorCounter++;
                }

                if (!starsiBox.Checked && !mlodsiBox.Checked)
                {
                    errorMessage += "Zaznacz kto zna pieśń!\n";
                    errorCounter++;
                }

                if (!postBox.Checked && !wielkanocBox.Checked && !koledyBox.Checked &&
                    !adwentBox.Checked && !maryjneBox.Checked)
                {
                    errorMessage += "Wybierz okres w roku!\n";
                    errorCounter++;
                }

                if (richTextBox1.Text == "")
                {
                    errorMessage += "Wprowadź tekst1 pieśni!\n";
                    errorCounter++;
                }

                if (textBox2.Text == "")
                {
                    errorMessage += "Nie wykryto chwytów!\n";
                    errorCounter++;
                }

                if (errorCounter == 0)
                {
                    button1.ForeColor = System.Drawing.Color.ForestGreen;
                }
                else
                {
                    button1.ForeColor = System.Drawing.Color.Black;
                }
            }
            if (Settings.errorColorHandling)
            {

                if (textBox1.Text != "" && !duplicateFound)
                {
                    groupBox1.BackColor = System.Drawing.Color.PaleGreen;
                    errorCounter++;
                }
                else if (!duplicateFound || textBox1.Text == "")
                    groupBox1.BackColor = System.Drawing.Color.Empty;

                if (numerTextbox.Text != "" && !duplicateNumFound)
                {
                    groupBox8.BackColor = System.Drawing.Color.PaleGreen;
                    errorCounter++;
                }
                else if (!duplicateNumFound)
                    groupBox8.BackColor = System.Drawing.Color.Empty;

                if (!(!wejscieBox.Checked && !uwielbienieBox.Checked && !ofiarowanieBox.Checked &&
                    !komuniaBox.Checked && !wyjscieBox.Checked))
                {
                    groupBox2.BackColor = System.Drawing.Color.PaleGreen;
                    errorCounter++;
                }
                else
                    groupBox2.BackColor = System.Drawing.Color.Empty;

                if (!(!krotkaBox.Checked && !sredniaBox.Checked && !dlugaBox.Checked))
                {
                    groupBox3.BackColor = System.Drawing.Color.PaleGreen;
                    errorCounter++;
                }
                else
                    groupBox3.BackColor = System.Drawing.Color.Empty;

                if (!(!starsiBox.Checked && !mlodsiBox.Checked))
                {
                    groupBox4.BackColor = System.Drawing.Color.PaleGreen;
                    errorCounter++;
                }
                else
                    groupBox4.BackColor = System.Drawing.Color.Empty;

                if (richTextBox1.Text != "")
                {
                    groupBox5.BackColor = System.Drawing.Color.PaleGreen;
                    errorCounter++;
                }
                else
                    groupBox5.BackColor = System.Drawing.Color.Empty;

                if (textBox2.Text != "")
                {
                    groupBox6.BackColor = System.Drawing.Color.PaleGreen;
                    errorCounter++;
                }
                else
                    groupBox6.BackColor = System.Drawing.Color.Empty;

                if (!(!postBox.Checked && !wielkanocBox.Checked && !koledyBox.Checked &&
                    !adwentBox.Checked && !maryjneBox.Checked))
                {
                    groupBox7.BackColor = System.Drawing.Color.PaleGreen;
                    errorCounter++;
                }
                else
                    groupBox7.BackColor = System.Drawing.Color.Empty;

                if (errorCounter == 8)
                {
                    button1.ForeColor = System.Drawing.Color.ForestGreen;
                    button3.ForeColor = System.Drawing.Color.ForestGreen;
                    this.BackColor = System.Drawing.Color.PaleGreen;
                    menuStrip1.BackColor = System.Drawing.Color.PaleGreen;
                }
                else
                {
                    button1.ForeColor = System.Drawing.Color.Black;
                    button3.ForeColor = System.Drawing.Color.Black;
                    this.BackColor = System.Drawing.Color.Empty;
                    menuStrip1.BackColor = System.Drawing.Color.Empty;
                }
            }
            return errorMessage;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = missingCheck();
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Poniżej znajduje się okno z możliwymi do zaznaczenia opcjami jakie pieśni posiadają.\n\n";
            message += "Po wypełnieniu każdej z grup prawidłowymi danymi grupa zaświeci się na zielono. Po ";
            message += "wypełnieniu wszystkich z nich całe okno zmieni kolor na zielony pokazując ze wpis jest ";
            message += "gotów do zapisania. Można również zapisać pieśni bez zaświecania wszystkich pól.\n";
            message += "Jeśli pole świeci się na czerwono, oznacza to że w bazie danych istnieje już pieśń o takim parametrze.\n\n";
            message += "Teksty piosenek można wklejać bezpośrednio, lecz chwyty są obsługiwany w następujący sposób:\n";
            message += "Jeśli cała linia zawiera tylko i wyłącznie chwyty, należy przed nią postawić znak slasha (/).\n";
            message += "Jeśli chwyty znajdują się tylko i wyłącznie z prawej strony linijki, należy po tekście ";
            message += "najpierw postawić znak małpy a następnie znak slasha (@/).\n\n";
            message += "Prawidłowość chwytów można śledzić w oknie pod tekstem.\n\n";
            message += "\n\n";
            message += "errorCount = " + errorCount;
            MessageBox.Show(message, "Okno pomocy");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (editIndex == -1)
            {
                MessageBox.Show("editIndex == 1\nBłąd edycji, następuje zamknięcie okna", "BŁĄD!");
                this.Close();
            }
            else
            {
                Piesn[] baza = new Piesn[1000];
                baza = Piesn.importujBaze();
                Piesn nowa = new Piesn();
                nowa.setPiesn(textBox1.Text, richTextBox1.Text, wejscieBox.Checked, wyjscieBox.Checked,
                    komuniaBox.Checked, ofiarowanieBox.Checked, krotkaBox.Checked, sredniaBox.Checked, dlugaBox.Checked,
                    starsiBox.Checked, mlodsiBox.Checked, postBox.Checked, wielkanocBox.Checked, koledyBox.Checked,
                    adwentBox.Checked, maryjneBox.Checked, zwykleBox.Checked, uwielbienieBox.Checked, nowaBox.Checked,
                    listaChwytow, int.Parse(numerTextbox.Text) , sizePicker.Value.ToString());
                baza[editIndex] = nowa;
                Piesn.zapiszBaze(baza, Piesn.policzBaze());
                MessageBox.Show("Edycja pieśni " + nowa.nazwa + " zakończona powodzeniem! Odśwież aby zobaczyć zmiany!", "Edytowano!");
                this.Close();
            }
        }
       
        private void DodajNowa_Load(object sender, EventArgs e)
        {
            bufor = Piesn.importujBaze();
            string temp = null;
            for (int i = 0; i < bufor.Length; i++)
            {
                try { temp = bufor[i].numer.ToString(); }
                catch
                {
                    errorCount++;
                }
                numbers.Add(temp);

                try { temp = bufor[i].nazwa.ToUpper(); }
                catch
                {
                    errorCount++;
                }
                names.Add(temp);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (names == null) { MessageBox.Show("NAMES = NULL"); return; }
            if (names.Contains(textBox1.Text.ToUpper()) && textBox1.Text != "")
                duplicateFound = true;
            else
                duplicateFound = false;

            if (duplicateFound) groupBox1.BackColor = Color.DarkRed;
        }

        private void DodajNowa_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (editIndex == -1) Application.OpenForms["BazaPiesni"].BringToFront();
            else Application.OpenForms["SongDetails"].BringToFront();
        }

        private void numerTextbox_TextChanged(object sender, EventArgs e)
        {
            if (numbers == null) { MessageBox.Show("NUMBERS = NULL"); return; }

            if (numbers.Contains(numerTextbox.Text) && numerTextbox.Text != "")
                duplicateNumFound = true;
            else
                duplicateNumFound = false;

            if (duplicateNumFound) groupBox8.BackColor = Color.DarkRed;
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            string path, search;
            path = "http://teksty.wywrota.pl/search/?utm_content=search_top&q=";
            search = textBox1.Text.Replace(' ', '+');
            path += search;
            Process.Start(path);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string size = "14";
            string tekst1 = richTextBox1.Text;
            size = sizePicker.Value.ToString();
            string title = (int.Parse(size) + 3).ToString();
            tekst1 = tekst1.Replace("@", " ");
            tekst1 = tekst1.Replace("\n", "</font><br><font color=black>");

            tekst1 = tekst1.Replace("[czerwony]", "<font color=red>"); //red
            tekst1 = tekst1.Replace("[zielony]", "<font color=green>"); //green
            tekst1 = tekst1.Replace("[niebieski]", "<font color=blue>"); // blue
            tekst1 = tekst1.Replace("[fioletowy]", "<font color=#660066>"); // violet
            tekst1 = tekst1.Replace("[brazowy]", "<font color=brown>"); // brown

            string[] html = 
            {
                "<html>",
                "<head>",
                "</head>",
                "<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />",
	            "<body>",
		        "<table height=100% width=100% border=1><tr>",
			    "<td width=50% align=center valign=top>",
    			"<br>",
			    "<b><u><h1 style=\"font-size:"+title+"pt;\">",
                textBox1.Text,
                "</h1></u></b><h3 style=\"font-size:"+size+"pt; font-weight:normal;\">",
                tekst1,
			    "</h3>",
			    "</td>",
			    "<td width=50% align=center valign=top>",
    			"<br>",
			    "<b><u><h1 style=\"font-size:"+title+"pt;\">",
                textBox1.Text,
               "</h1></u></b><h3 style=\"font-size:"+size+"pt; font-weight:normal;\">",
                tekst1,
    			"</h3>",
		        "</td></tr></table>",
	            "</body>",
                "<script>javascript:window.print()</script>",
                "</html>",
            };

            File.WriteAllLines("wydruk.html", html);
            System.Diagnostics.Process.Start(@"wydruk.html");
        
        }
    }
}
