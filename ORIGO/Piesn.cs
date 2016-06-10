using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ORIGO
{
    public class wielkoscBazy
    {
        public int wielkosc;
    }
    public class Piesn
    {
        public string nazwa, tekst, size;
        public bool wejscie, wyjscie, komunia, ofiarowanie, krotka, srednia, dluga, starsi, mlodsi;
        public bool post, wielkanoc, koledy, adwent, maryjne, zwykle, uwielbienie, nowa;
        public int numer;
        public List<string> chwyty;

        public Piesn setPiesn(string nazw, string teks, bool wejsci, bool wyjsci, bool komuni, bool ofiarowani,
            bool krotk, bool sredni, bool dlug, bool stars, bool mlods, bool pos, bool wielkano,
            bool koled, bool adwen, bool maryjn, bool zwykl, bool uwielbieni, bool pocwic, List<string> chwyt, int nume, string siz)
        //tworzy Piesn z argumentow
        {
            nazwa = nazw;
            tekst = teks;
            wejscie = wejsci;
            wyjscie = wyjsci;
            komunia = komuni;
            ofiarowanie = ofiarowani;
            krotka = krotk;
            srednia = sredni;
            dluga = dlug;
            starsi = stars;
            mlodsi = mlods;
            post = pos;
            wielkanoc = wielkano;
            koledy = koled;
            adwent = adwen;
            maryjne = maryjn;
            zwykle = zwykl;
            uwielbienie = uwielbieni;
            nowa = pocwic;
            chwyty = chwyt;
            numer = nume;
            size = siz;
            return this;
        }

        public string eksportujElement() // konwersja z klasy Piesn na stringa
        {
            this.tekst = this.tekst.Replace("\n", "$");
            this.tekst = this.tekst.Replace("\r", "$");
            string linia = "";
            string rozdzielnik = "|";
            string rozdzielnikChwyt = "&";
            linia += this.nazwa.ToUpper() + rozdzielnik + this.tekst + rozdzielnik + this.wejscie;
            linia += rozdzielnik + this.wyjscie + rozdzielnik + this.komunia + rozdzielnik;
            linia += this.ofiarowanie + rozdzielnik + this.krotka + rozdzielnik + this.srednia;
            linia += rozdzielnik + this.dluga + rozdzielnik + this.starsi + rozdzielnik;
            linia += this.mlodsi + rozdzielnik + this.post + rozdzielnik + this.wielkanoc;
            linia += rozdzielnik + this.koledy + rozdzielnik + this.adwent + rozdzielnik;
            linia += this.maryjne + rozdzielnik + this.zwykle + rozdzielnik + this.uwielbienie;
            linia += rozdzielnik + this.nowa + rozdzielnik;
            bool isChwytExists = false;
            foreach (string chwyt in chwyty)
            {
                isChwytExists = true;
                linia += chwyt + rozdzielnikChwyt;
            }

            if (isChwytExists) linia = linia.Remove(linia.Length - 1);
            linia += rozdzielnik + this.numer + rozdzielnik + this.size + rozdzielnik;
            return linia;
        }

        public void dopiszElement() // dopisuje wpis do pliku bazy danych
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("baza.txt", true);

            string linia = this.eksportujElement();
            file.WriteLine(linia);

            file.Close();
        }

        public static string pobierzLinie(int linia) // pobiera dana linie z bazy danych i zwraca w stringu
        {
            string bufor = "ERROR";
            int numer = linia;
            System.IO.StreamReader file = new System.IO.StreamReader("baza.txt");
            for (int i = 0; i <= linia; i++)
            {
                bufor = file.ReadLine();
                if (bufor == null)
                {
                    bufor = "BLAD, ZA DUZY INDEX";
                    return bufor;
                }
            }
            file.Close();
            return bufor;
        }

        public static int policzBaze() // liczy ilosc wpisów w bazie danych i zwraca inta
        {
            int i = 0;
            System.IO.StreamReader file = new System.IO.StreamReader("baza.txt");
            string linia;
            while ((linia = file.ReadLine()) != null)
                i++;
            file.Close();
            return i;
        }

        public static int[] statystyka(Piesn[] database) // przelicza statystyki z pliku baza.txt i zwraca arraya z danymi
        {
            int[] statArr = { 0, 0, 0, 0 };
            int nowe = 0, numer = 0, mlodsi = 0, noChwyt = 0;
            foreach (var bufor in database)
            {
                if (bufor.nowa) nowe++;
                if (bufor.numer == 0) numer++;
                if (bufor.mlodsi) mlodsi++;
                if (bufor.chwyty.Count == 0) noChwyt++;
            }



            statArr[0] = nowe;
            statArr[1] = numer;
            statArr[2] = mlodsi;
            statArr[3] = noChwyt;
            return statArr;
        }

        public static Piesn[] importujBaze() // importuje baze danych z pliku do tabeli klasy Piesn - uzywa importujWpis
        {
            int wielkosc = policzBaze();
            Piesn[] nowa = new Piesn[wielkosc];
            wielkoscBazy baza = new wielkoscBazy();
            int i = 0;
            System.IO.StreamReader file = new System.IO.StreamReader("baza.txt");
            string linia;
            while ((linia = file.ReadLine()) != null)
            {
                nowa[i] = importujWpis(linia);
                i++;
                baza.wielkosc = i;
            }

            file.Close();
            return nowa;
        }

        public static Piesn importujWpisold(string linia) // konwertuje wpis z bazy ze stringa na klase Piesn (wpisuje w pola)
        {
            Piesn wpis = new Piesn();

            string[] poSplicie = linia.Split('|'); //rozdzielnik wpisow
            // rozbicie linii
            wpis.nazwa = poSplicie[0];
            wpis.tekst = poSplicie[1].Replace("$", "\n");
            wpis.wejscie = bool.Parse(poSplicie[2]);
            wpis.wyjscie = bool.Parse(poSplicie[3]);
            wpis.komunia = bool.Parse(poSplicie[4]);
            wpis.ofiarowanie = bool.Parse(poSplicie[5]);
            wpis.krotka = bool.Parse(poSplicie[6]);
            wpis.srednia = bool.Parse(poSplicie[7]);
            wpis.dluga = bool.Parse(poSplicie[8]);
            wpis.starsi = bool.Parse(poSplicie[9]);
            wpis.mlodsi = bool.Parse(poSplicie[10]);
            wpis.post = bool.Parse(poSplicie[11]);
            wpis.wielkanoc = bool.Parse(poSplicie[12]);
            wpis.koledy = bool.Parse(poSplicie[13]);
            wpis.adwent = bool.Parse(poSplicie[14]);
            wpis.maryjne = bool.Parse(poSplicie[15]);
            wpis.zwykle = bool.Parse(poSplicie[16]);
            wpis.uwielbienie = bool.Parse(poSplicie[17]);
            wpis.nowa = bool.Parse(poSplicie[18]);

            List<string> chwyty = new List<string>();
            int j = 19;
            while (j < poSplicie.Length)
            {
                if (poSplicie[j] == "") { j++; continue; }
                chwyty.Add(poSplicie[j]);
                j++;
            }

            wpis.chwyty = chwyty;
            return wpis;
        }

        public static Piesn importujWpis(string linia) // konwertuje wpis z bazy ze stringa na klase Piesn (wpisuje w pola)
        {
            Piesn wpis = new Piesn();

            string[] poSplicie = linia.Split('|'); //rozdzielnik wpisow
            // rozbicie linii
            wpis.nazwa = poSplicie[0];
            wpis.tekst = poSplicie[1].Replace("$", "\n");
            wpis.wejscie = bool.Parse(poSplicie[2]);
            wpis.wyjscie = bool.Parse(poSplicie[3]);
            wpis.komunia = bool.Parse(poSplicie[4]);
            wpis.ofiarowanie = bool.Parse(poSplicie[5]);
            wpis.krotka = bool.Parse(poSplicie[6]);
            wpis.srednia = bool.Parse(poSplicie[7]);
            wpis.dluga = bool.Parse(poSplicie[8]);
            wpis.starsi = bool.Parse(poSplicie[9]);
            wpis.mlodsi = bool.Parse(poSplicie[10]);
            wpis.post = bool.Parse(poSplicie[11]);
            wpis.wielkanoc = bool.Parse(poSplicie[12]);
            wpis.koledy = bool.Parse(poSplicie[13]);
            wpis.adwent = bool.Parse(poSplicie[14]);
            wpis.maryjne = bool.Parse(poSplicie[15]);
            wpis.zwykle = bool.Parse(poSplicie[16]);
            wpis.uwielbienie = bool.Parse(poSplicie[17]);
            wpis.nowa = bool.Parse(poSplicie[18]);
            string chwytyString = poSplicie[19];
            wpis.numer = int.Parse(poSplicie[20]);
            if (poSplicie.Length < 23)
                wpis.size = "14";
            else
                wpis.size = poSplicie[21];
            //  MessageBox.Show(chwytyString);
            List<string> chwyty = new List<string>();
            string[] chwytyArr = chwytyString.Split('&'); //rozdzielnik chwytów
            //chwyty = chwytyArr.ToList();
            foreach (string chwyt in chwytyArr)
                if (!string.IsNullOrEmpty(chwyt)) chwyty.Add(chwyt);
            wpis.chwyty = chwyty;
            return wpis;
        }

        public static void zapiszBaze(Piesn[] tabela, int iloscWpisow) // zapisuje baze danych w formacie arraya Piesn do baza.txt
        {

            System.IO.StreamWriter file = new System.IO.StreamWriter("baza.txt");
            for (int i = 0; i < iloscWpisow; i++)
            {

                string linia = tabela[i].eksportujElement();
                file.WriteLine(linia);

            }
            file.Close();
        }

        public static int szukajPoNazwie(string nazwa)// wyszukuje nazwe w pliku, zwraca index linii
        {
            int index = -1;
            for (int i = 0; i < policzBaze(); i++)
            {
                if (importujWpis(pobierzLinie(i)).nazwa == nazwa) return i;
            }

            MessageBox.Show("Nie znaleziono " + nazwa);
            return index;
        }

        public static Piesn[] szukajPoCzesci(string nazwa, Piesn[] baza) // szuka czesci nazwy w calej bazie, zwraca tabele z wynikami
        {
            List<Piesn> wynikiList = new List<Piesn>();
            int wielkosc = policzBaze();
            for (int i = 0; i < wielkosc; i++)
            {
                if (baza[i].nazwa.ToUpper().Contains(nazwa.ToUpper())) wynikiList.Add(baza[i]);
            }
            int wynikiWielkosc = wynikiList.Count;
            Piesn[] wyniki = new Piesn[wynikiWielkosc];
            wyniki = wynikiList.ToArray();
            return wyniki;
        }
    }
}
/*
 * public string eksportujElement() - konwersja z klasy Piesn na stringa
 * public static Piesn importujWpis(string linia) - konwertuje ze stringa na klase Piesn
 * public void dopiszElement() - dopisuje wpis do pliku bazy danych
 * public static string pobierzLinie(int linia) - pobiera dana linie z bazy danych i zwraca w stringu
 * public static int policzBaze() - liczy ilosc wpisów w bazie danych i zwraca inta
 * public static int[] statystyka() - przelicza statystyki z pliku baza.txt i zwraca arraya z danymi
 * public static Piesn[] importujBaze() - importuje baze danych z pliku do tabeli klasy Piesn - uzywa importujWpis
 * public static void zapiszBaze(Piesn[] tabela, int iloscWpisow) - zapisuje baze danych w formacie arraya Piesn do baza.txt
 * public static int szukajPoNazwie(string nazwa) - wyszukuje nazwe w pliku, zwraca index linii
 * public static Piesn[] szukajPoCzesci(string nazwa, Piesn[] baza) szuka czesci nazwy w calej bazie, zwraca tabele z wynikami
 * 
 */