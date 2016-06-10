using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ORIGO
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void Notepad_Load(object sender, EventArgs e)
        {
            string notepad = "NULL";

             System.IO.StreamReader file = new System.IO.StreamReader("notatnik.txt");

                notepad = file.ReadToEnd();
                file.Close();
            
            richTextBox1.Text = notepad;
        }

        private void Notepad_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["MainMenu"].BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("notatnik.txt"))
            {
                writer.Write(richTextBox1.Text);
            }
            this.Close();
        }
    }
}
