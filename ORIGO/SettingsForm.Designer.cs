namespace ORIGO
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tekstCheck = new System.Windows.Forms.CheckBox();
            this.kolorCheck = new System.Windows.Forms.CheckBox();
            this.nowaCheck = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fastCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tekstCheck);
            this.groupBox1.Controls.Add(this.kolorCheck);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sygnalizacja błędów";
            // 
            // tekstCheck
            // 
            this.tekstCheck.AutoSize = true;
            this.tekstCheck.Location = new System.Drawing.Point(112, 19);
            this.tekstCheck.Name = "tekstCheck";
            this.tekstCheck.Size = new System.Drawing.Size(53, 17);
            this.tekstCheck.TabIndex = 1;
            this.tekstCheck.Text = "Tekst";
            this.tekstCheck.UseVisualStyleBackColor = true;
            // 
            // kolorCheck
            // 
            this.kolorCheck.AutoSize = true;
            this.kolorCheck.Location = new System.Drawing.Point(6, 19);
            this.kolorCheck.Name = "kolorCheck";
            this.kolorCheck.Size = new System.Drawing.Size(50, 17);
            this.kolorCheck.TabIndex = 1;
            this.kolorCheck.Text = "Kolor";
            this.kolorCheck.UseVisualStyleBackColor = true;
            // 
            // nowaCheck
            // 
            this.nowaCheck.AutoSize = true;
            this.nowaCheck.Location = new System.Drawing.Point(18, 63);
            this.nowaCheck.Name = "nowaCheck";
            this.nowaCheck.Size = new System.Drawing.Size(163, 17);
            this.nowaCheck.TabIndex = 1;
            this.nowaCheck.Text = "Nowa domyślnie zaznaczona";
            this.nowaCheck.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fastCheckbox
            // 
            this.fastCheckbox.AutoSize = true;
            this.fastCheckbox.Location = new System.Drawing.Point(18, 86);
            this.fastCheckbox.Name = "fastCheckbox";
            this.fastCheckbox.Size = new System.Drawing.Size(104, 17);
            this.fastCheckbox.TabIndex = 3;
            this.fastCheckbox.Text = "Szybki komputer";
            this.fastCheckbox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 151);
            this.Controls.Add(this.fastCheckbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nowaCheck);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ustawienia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox tekstCheck;
        private System.Windows.Forms.CheckBox kolorCheck;
        private System.Windows.Forms.CheckBox nowaCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox fastCheckbox;
    }
}