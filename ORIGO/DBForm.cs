using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ORIGO
{
    public partial class BazaPiesni : Form
    {
        public static int iloscWpisow = 0;
        private Piesn pamiecDrukowania1 = new Piesn();
        private Piesn pamiecDrukowania2 = new Piesn();


        private Piesn[] data = new Piesn[1000];

        public BazaPiesni()
        {
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            Piesn[] data = Piesn.importujBaze();
            wczytajTabele(data);
            int szerokosc = 622 + DGV.Columns[0].Width;
            this.Width = szerokosc;
            if (Settings.fasterComputer) buttonSearch.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajNowa noweOkno = new DodajNowa();
            noweOkno.Show();
        }

        private Color kolorujBraki(Piesn dane)
        {
            if (dane.chwyty.Count == 0) return Color.Yellow;     // BRAK CHWYTOW
            if (dane.numer == 0) return Color.SkyBlue;         // BRAK NUMERU

            return Color.Empty;
        }

        public void wczytajTabele(Piesn[] data)
        {
            
            int RowIndex = 0;

           // int wielkoscBazy = Piesn.policzBaze();
            for (int i = 0; i < data.Length; i++)
            {
                DGV.Rows.Add();
                DataGridViewRow Row = DGV.Rows[RowIndex]; // wybor wiersza do zapisu
                    Row.Cells["tytul"].Value = data[i].nazwa;
                    Row.Cells["wyjscie"].Value = data[i].wyjscie;
                    Row.Cells["wejscie"].Value = data[i].wejscie;
                    Row.Cells["komunia"].Value = data[i].komunia;
                    Row.Cells["ofiarowanie"].Value = data[i].ofiarowanie;
                    Row.Cells["uwielbienie"].Value = data[i].uwielbienie;
                    Row.Cells["krotka"].Value = data[i].krotka;
                    Row.Cells["srednia"].Value = data[i].srednia;
                    Row.Cells["dluga"].Value = data[i].dluga;
                    Row.Cells["starsi"].Value = data[i].starsi;
                    Row.Cells["mlodsi"].Value = data[i].mlodsi;
                    Row.Cells["post"].Value = data[i].post;
                    Row.Cells["wielkanoc"].Value = data[i].wielkanoc;
                    Row.Cells["koledy"].Value = data[i].koledy;
                    Row.Cells["adwent"].Value = data[i].adwent;
                    Row.Cells["maryjne"].Value = data[i].maryjne;
                    Row.Cells["zwykle"].Value = data[i].zwykle;
                    Row.Cells["nowa"].Value = data[i].nowa;

                    Row.DefaultCellStyle.BackColor = kolorujBraki(data[i]);
                
                RowIndex++;
                iloscWpisow++;
                if (iloscWpisow < data.Length)
                    label1.Text = iloscWpisow.ToString();
                else
                    label1.Text = data.Length.ToString();
            }
        }

        public void wyczyscTabele()
        {
            while (iloscWpisow > 0 && DGV.RowCount > 0)
            {
                DataGridViewRow R = DGV.Rows[DGV.RowCount - 1];
                DGV.Rows.Remove(R);
                iloscWpisow--;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Piesn[] data = Piesn.importujBaze();
            wyczyscTabele();
            wczytajTabele(data);
        }

        public Piesn[] zapiszTabele()
        {
            Piesn[] eksport = Piesn.importujBaze();

            for (int i = 0; i < DGV.RowCount; i++)
            {
                DataGridViewRow Row = DGV.Rows[i]; // wybor wiersza do zapisu

                eksport[i].nazwa = Row.Cells["tytul"].Value.ToString();
                eksport[i].wyjscie = bool.Parse(Row.Cells["wyjscie"].Value.ToString());
                eksport[i].wejscie = bool.Parse(Row.Cells["wejscie"].Value.ToString());
                eksport[i].komunia = bool.Parse(Row.Cells["komunia"].Value.ToString());
                eksport[i].ofiarowanie = bool.Parse(Row.Cells["ofiarowanie"].Value.ToString());
                eksport[i].uwielbienie = bool.Parse(Row.Cells["uwielbienie"].Value.ToString());
                eksport[i].krotka = bool.Parse(Row.Cells["krotka"].Value.ToString());
                eksport[i].srednia = bool.Parse(Row.Cells["srednia"].Value.ToString());
                eksport[i].dluga = bool.Parse(Row.Cells["dluga"].Value.ToString());
                eksport[i].starsi = bool.Parse(Row.Cells["starsi"].Value.ToString());
                eksport[i].mlodsi = bool.Parse(Row.Cells["mlodsi"].Value.ToString());
                eksport[i].post = bool.Parse(Row.Cells["post"].Value.ToString());
                eksport[i].wielkanoc = bool.Parse(Row.Cells["wielkanoc"].Value.ToString());
                eksport[i].koledy = bool.Parse(Row.Cells["koledy"].Value.ToString());
                eksport[i].adwent = bool.Parse(Row.Cells["adwent"].Value.ToString());
                eksport[i].maryjne = bool.Parse(Row.Cells["maryjne"].Value.ToString());
                eksport[i].zwykle = bool.Parse(Row.Cells["zwykle"].Value.ToString());
                eksport[i].nowa = bool.Parse(Row.Cells["nowa"].Value.ToString());
            }

            return eksport;
        }

        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection sel = DGV.SelectedRows;
            string selName = sel[0].Cells[0].Value.ToString();

            int index = Piesn.szukajPoNazwie(selName);

            SongDetails details = new SongDetails(index);
            details.Show();
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Poniżej znajduje się tablica ze wszystkimi pieśniami aktualnie znajdującymi się ";
            message += "w bazie danych. Można tutaj edytować ich parametry i tytuły poprzez duwkrotne kliknięcie na ";
            message += "odpowiadającą kratkę i wybranie opcji \"Edytuj\". Sortowanie listy następuje poprzez kliknięcie odpowiedniej ";
            message += "kolumny. \n\nPrzyciskiem \"Nowa pieśń\" przechodzisz do okna wpisu nowej pieśni\n\n";
            message += "Poprzez dwukrotne kliknięcie na nazwę statystyki w prawym górnym rogu";
            message += " wyświetlisz listę pieśni do których dana statystyka się odnosi.\n\n";
            message += "Aby wydrukować daną pieśń, zaznacz żądany wpis lewym przyciskiem myszy, następnie kliknij prawym przyciskiem";
            message += " i z menu wybierz Drukuj. Możesz zaznaczyć i wydrukować dwie pieśni na raz, trzymając przycisk Control podczas zaznaczania.";
            message += "\n\nKolory w tabeli:\nżółty - brak chwytów w danej pieśni\n";
            message += "niebieski - brak wpisanego numeru z komputera";
            MessageBox.Show(message, "Okno pomocy");
        }

        private void BazaPiesni_Activated(object sender, EventArgs e)
        {
            Piesn[] data = Piesn.importujBaze();
            wyczyscTabele();
            wczytajTabele(data);
            ladujStatystyki(Piesn.statystyka(data));
        }

        private void BazaPiesni_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["MainMenu"].BringToFront();
        }

        private void ladujStatystyki(int[] statArr)
        {
            nowaInt.Text = statArr[0].ToString();
            labelBezNumeruInt.Text = statArr[1].ToString();
            // mlodsiInt.Text = statArr[2].ToString();
            bezchwytInt.Text = statArr[3].ToString();

            if (statArr[0] != 0)
            {
                nowaInt.ForeColor = Color.Blue;
                nowaText.ForeColor = Color.Blue;
            }
            else
            {
                nowaInt.ForeColor = Color.Empty;
                nowaText.ForeColor = Color.Empty;
            }

            if (statArr[1] != 0)
            {
                labelBezNumeruInt.ForeColor = Color.SkyBlue;
                labelBezNumeru.ForeColor = Color.SkyBlue;
            }
            else
            {
                nowaInt.ForeColor = Color.Empty;
                nowaText.ForeColor = Color.Empty;
            }

            if (statArr[3] != 0)
            {
                bezchwytInt.ForeColor = Color.Olive;
                bezchwytText.ForeColor = Color.Olive;
            }
            else
            {
                bezchwytInt.ForeColor = Color.Green;
                bezchwytText.ForeColor = Color.Green;
            }
        }

        private void bezchwytText_DoubleClick(object sender, EventArgs e)
        {
            System.IO.StreamReader file = new System.IO.StreamReader("baza.txt");
            string linia, lista = null;
            Piesn bufor = new Piesn();
            while ((linia = file.ReadLine()) != null)
            {
                bufor = Piesn.importujWpis(linia);
                if (bufor.chwyty.Count == 0) lista += bufor.nazwa + "\n";
            }
            file.Close();
            MessageBox.Show(lista, "BEZ CHWYTÓW");
        }

        private void nowaText_DoubleClick(object sender, EventArgs e)
        {
            System.IO.StreamReader file = new System.IO.StreamReader("baza.txt");
            string linia, lista = null;
            Piesn bufor = new Piesn();
            while ((linia = file.ReadLine()) != null)
            {
                bufor = Piesn.importujWpis(linia);
                if (bufor.nowa) lista += bufor.nazwa + "\n";
            }
            file.Close();
            MessageBox.Show(lista, "DO PRZEĆWICZENIA");
        }

        public void columnResize(int index, string name, int size)
        {
            DGV.Columns[index].HeaderText = name;
            DGV.Columns[index].Width = size;
        }

        private void BazaPiesni_ResizeEnd(object sender, EventArgs e)
        {
            resize();
        }

        private void DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }
        public void drukujZNazw(string nazwa1, string nazwa2)
        {
            Piesn target1, target2;
            int index1 = Piesn.szukajPoNazwie(nazwa1);
            target1 = Piesn.importujWpis(Piesn.pobierzLinie(index1));
            string tekst1 = target1.tekst;
            string size1 = target1.size; 
            string title1 = (int.Parse(size1) + 3).ToString();
            
            tekst1 = tekst1.Replace("@", " ");
            tekst1 = tekst1.Replace("\n", "<br>");

            int index2 = Piesn.szukajPoNazwie(nazwa2);
            target2 = Piesn.importujWpis(Piesn.pobierzLinie(index2));
            string tekst2 = target2.tekst;
            string size2 = target2.size;
            string title2 = (int.Parse(size2) + 3).ToString();
            tekst2 = tekst2.Replace("@", " ");
            tekst2 = tekst2.Replace("\n", "<br>");

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
			    "<b><u><h1 style=\"font-size:"+title1+"pt;\">",
                Piesn.importujWpis(Piesn.pobierzLinie(index1)).nazwa,
                "</h1></u></b><h3 style=\"font-size:"+size1+"pt; font-weight:normal;\">",
                tekst1,
			    "</h3>",
			    "</td>",
			    "<td width=50% align=center valign=top>",
    			"<br>",
			    "<b><u><h1 style=\"font-size:"+title2+"pt;\">",
                Piesn.importujWpis(Piesn.pobierzLinie(index2)).nazwa,
                "</h1></u></b><h3 style=\"font-size:"+size2+"pt; font-weight:normal;\">",
                tekst2,
    			"</h3>",
		        "</td></tr></table>",
	            "</body>",
                "<script>javascript:window.print()</script>",
                "</html>",
            };
            File.WriteAllLines("wydruk.html", html);
            System.Diagnostics.Process.Start(@"wydruk.html");
        }
        public void drukujZNazw(string nazwa1)
        {
            string size = "14";
            int index1 = Piesn.szukajPoNazwie(nazwa1);
            Piesn target = Piesn.importujWpis(Piesn.pobierzLinie(index1));
            string tekst1 = target.tekst;
            size = target.size;
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
                Piesn.importujWpis(Piesn.pobierzLinie(index1)).nazwa,
                "</h1></u></b><h3 style=\"font-size:"+size+"pt; font-weight:normal;\">",
                tekst1,
			    "</h3>",
			    "</td>",
			    "<td width=50% align=center valign=top>",
    			"<br>",
			    "<b><u><h1 style=\"font-size:"+title+"pt;\">",
                Piesn.importujWpis(Piesn.pobierzLinie(index1)).nazwa,
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
        public void drukujZPiesn(Piesn piesn)
        {
            // TO DO
        }
        private void drukujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection sel = DGV.SelectedRows;
            string selName1 = sel[0].Cells[0].Value.ToString();
            if (sel.Count > 1)
            {
                string selName2 = sel[1].Cells[0].Value.ToString();

                drukujZNazw(selName1, selName2);
            }
            else
            {
                drukujZNazw(selName1);
            }
        }

        private void labelBezNumeru_DoubleClick(object sender, EventArgs e)
        {
            Piesn[] baza = Piesn.importujBaze();
 
            string lista = null;
            for (int i = 0; i < Piesn.policzBaze(); i++)
                if (baza[i].numer == 0) lista += baza[i].nazwa + "\n";
                        
            MessageBox.Show(lista, "BEZ NUMERU");
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (Settings.fasterComputer)
            {
                Piesn[] baza = Piesn.importujBaze();
                Piesn[] wyniki;
                wyniki = Piesn.szukajPoCzesci(textBoxSearch.Text, baza);
                wyczyscTabele();
                wczytajTabele(wyniki);
                resize();
                ladujStatystyki(Piesn.statystyka(wyniki));
            }
        }
        private void resize()
        {
            int szerokosc = 622 + DGV.Columns[0].Width;

            if (this.Width > szerokosc + 10) columnResize(7, "Średnia", 50);
            else columnResize(7, "Śrdnia", 40);

            if (this.Width > szerokosc + 35) columnResize(12, "Wielkanoc", 65);
            else columnResize(12, "Wlknc", 40);

            if (this.Width > szerokosc + 45) columnResize(13, "Kolędy", 45);
            else columnResize(13, "Koldy", 40);

            if (this.Width > szerokosc + 50) columnResize(14, "Adwent", 50);
            else columnResize(14, "Adwnt", 40);

            if (this.Width > szerokosc + 60) columnResize(15, "Maryjne", 50);
            else columnResize(15, "Mrjne", 40);

            if (this.Width > szerokosc + 70) columnResize(16, "Zwykłe", 50);
            else columnResize(16, "Zwkłe", 40);

            if (this.Width > szerokosc + 90) columnResize(17, "Nowa", 40);
            else columnResize(17, "N", 20);

            if (this.Width > szerokosc + 120) columnResize(1, "Wejście", 50);
            else columnResize(1, "W", 20);

            if (this.Width > szerokosc + 170) columnResize(2, "Ofiarowanie", 70);
            else columnResize(2, "O", 20);

            if (this.Width > szerokosc + 205) columnResize(3, "Komunia", 55);
            else columnResize(3, "K", 20);

            if (this.Width > szerokosc + 255) columnResize(4, "Uwielbienie", 70);
            else columnResize(4, "U", 20);

            if (this.Width > szerokosc + 310) columnResize(5, "Zakończenie", 75);
            else columnResize(5, "Z", 20);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Piesn[] baza = Piesn.importujBaze();
            Piesn[] wyniki;
            wyniki = Piesn.szukajPoCzesci(textBoxSearch.Text, baza);
            wyczyscTabele();
            wczytajTabele(wyniki);
            resize();
            ladujStatystyki(Piesn.statystyka(wyniki));
        }

        private void zapiszDo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection sel = DGV.SelectedRows;
            string selName1 = sel[0].Cells[0].Value.ToString();
            zapiszDo1ToolStripMenuItem.Text = selName1;
        }

        private void zapiszDo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection sel = DGV.SelectedRows;
            string selName1 = sel[0].Cells[0].Value.ToString();
            zapiszDo2ToolStripMenuItem.Text = selName1;
        }

        private void drukujToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string save1 = zapiszDo1ToolStripMenuItem.Text;
            string save2 = zapiszDo2ToolStripMenuItem.Text;
            if (save1 == "Zapisz do 1" && save2 == "Zapisz do 2") MessageBox.Show("Brak pieśni w pamięci! Użyj opcji powyżej aby zapisać pieśni do pamięci!", "BŁĄD");
            else if (save1 == "Zapisz do 1") drukujZNazw(save2);
            else if (save2 == "Zapisz do 2") drukujZNazw(save1);
            else drukujZNazw(save1,save2);
        }

        private void wyczyśćPamięćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zapiszDo1ToolStripMenuItem.Text = "Zapisz do 1";
            zapiszDo2ToolStripMenuItem.Text = "Zapisz do 2";
        }

        private void textBoxSearch_MouseEnter(object sender, EventArgs e)
        {
            textBoxSearch.SelectAll();
        }

    }
}