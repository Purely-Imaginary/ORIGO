using System.IO;
using System.Windows.Forms;

namespace ORIGO
{
    public static class Settings
    {
        public static bool errorColorHandling;
        public static bool errorMessageHandling;
        public static bool nowaDefaultCheck;
        public static bool fasterComputer;

        public static void Load()
        {
            bool parsingSuccess;
            if (!File.Exists("settings.ini"))
            {
                MessageBox.Show("Nie znaleziono pliku settings.ini! \nTwoje ustawienia zostały zresetowane do domyślnych!");
                using (StreamWriter writer = File.CreateText("settings.ini"))
                {
                    writer.WriteLine("false");
                    writer.WriteLine("true");
                    writer.WriteLine("false");
                    writer.WriteLine("false");
                }
            }
            System.IO.StreamReader file = new System.IO.StreamReader("settings.ini");
            errorMessageHandling = bool.Parse(file.ReadLine());
            errorColorHandling = bool.Parse(file.ReadLine());
            nowaDefaultCheck = bool.Parse(file.ReadLine());

            fasterComputer = bool.TryParse(file.ReadLine(), out parsingSuccess);
            if (!parsingSuccess) fasterComputer = false;
            
            file.Close();
        }

        public static void SaveToFile()
        {
            using (StreamWriter writer = new StreamWriter("settings.ini"))
            {
                writer.WriteLine(errorMessageHandling);
                writer.WriteLine(errorColorHandling);
                writer.WriteLine(nowaDefaultCheck);
                writer.WriteLine(fasterComputer);
            }
        }

        public static void Set(bool erMes, bool erCol, bool nowaDef, bool fast)
        {
            errorMessageHandling = erMes;
            errorColorHandling = erCol;
            nowaDefaultCheck = nowaDef;
            fasterComputer = fast;
        }
    }
}