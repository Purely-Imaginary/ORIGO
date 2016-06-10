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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        public void Settings_Load(object sender, EventArgs e)
        {
            nowaCheck.Checked = Settings.nowaDefaultCheck;
            tekstCheck.Checked = Settings.errorMessageHandling;
            kolorCheck.Checked = Settings.errorColorHandling;
            fastCheckbox.Checked = Settings.fasterComputer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Set(tekstCheck.Checked, kolorCheck.Checked, nowaCheck.Checked,fastCheckbox.Checked);
            Settings.SaveToFile();
            MessageBox.Show("Ustawienia zostały zapisane pomyślnie!");
            this.Close();

        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["MainMenu"].BringToFront();
        }
    }
}
