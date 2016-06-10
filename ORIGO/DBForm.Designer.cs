namespace ORIGO
{
    partial class BazaPiesni
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BazaPiesni));
            this.button1 = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.tytul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wejscie = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ofiarowanie = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.komunia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uwielbienie = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.wyjscie = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.krotka = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.srednia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dluga = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.starsi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mlodsi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.post = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.wielkanoc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.koledy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.adwent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.maryjne = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.zwykle = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nowa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wpisyText = new System.Windows.Forms.Label();
            this.nowaText = new System.Windows.Forms.Label();
            this.nowaInt = new System.Windows.Forms.Label();
            this.bezchwytText = new System.Windows.Forms.Label();
            this.bezchwytInt = new System.Windows.Forms.Label();
            this.statPanel = new System.Windows.Forms.Panel();
            this.labelBezNumeru = new System.Windows.Forms.Label();
            this.labelBezNumeruInt = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drukujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszDoPamięciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszDo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszDo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drukujToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczyśćPamięćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nowa pieśń";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeColumns = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tytul,
            this.wejscie,
            this.ofiarowanie,
            this.komunia,
            this.uwielbienie,
            this.wyjscie,
            this.krotka,
            this.srednia,
            this.dluga,
            this.starsi,
            this.mlodsi,
            this.post,
            this.wielkanoc,
            this.koledy,
            this.adwent,
            this.maryjne,
            this.zwykle,
            this.nowa});
            this.DGV.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.Location = new System.Drawing.Point(12, 64);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 5;
            this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(760, 199);
            this.DGV.TabIndex = 2;
            this.DGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellDoubleClick);
            this.DGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_CellMouseClick);
            // 
            // tytul
            // 
            this.tytul.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tytul.HeaderText = "Tytuł";
            this.tytul.Name = "tytul";
            this.tytul.ReadOnly = true;
            this.tytul.Width = 57;
            // 
            // wejscie
            // 
            this.wejscie.HeaderText = "W";
            this.wejscie.Name = "wejscie";
            this.wejscie.ReadOnly = true;
            this.wejscie.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wejscie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wejscie.Width = 20;
            // 
            // ofiarowanie
            // 
            this.ofiarowanie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ofiarowanie.HeaderText = "O";
            this.ofiarowanie.Name = "ofiarowanie";
            this.ofiarowanie.ReadOnly = true;
            this.ofiarowanie.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ofiarowanie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ofiarowanie.Width = 20;
            // 
            // komunia
            // 
            this.komunia.HeaderText = "K";
            this.komunia.Name = "komunia";
            this.komunia.ReadOnly = true;
            this.komunia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.komunia.Width = 20;
            // 
            // uwielbienie
            // 
            this.uwielbienie.HeaderText = "U";
            this.uwielbienie.Name = "uwielbienie";
            this.uwielbienie.ReadOnly = true;
            this.uwielbienie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.uwielbienie.Width = 20;
            // 
            // wyjscie
            // 
            this.wyjscie.HeaderText = "Z";
            this.wyjscie.Name = "wyjscie";
            this.wyjscie.ReadOnly = true;
            this.wyjscie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wyjscie.Width = 20;
            // 
            // krotka
            // 
            this.krotka.HeaderText = "Krótka";
            this.krotka.Name = "krotka";
            this.krotka.ReadOnly = true;
            this.krotka.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.krotka.Width = 40;
            // 
            // srednia
            // 
            this.srednia.HeaderText = "Śrdnia";
            this.srednia.Name = "srednia";
            this.srednia.ReadOnly = true;
            this.srednia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.srednia.Width = 40;
            // 
            // dluga
            // 
            this.dluga.HeaderText = "Długa";
            this.dluga.Name = "dluga";
            this.dluga.ReadOnly = true;
            this.dluga.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dluga.Width = 40;
            // 
            // starsi
            // 
            this.starsi.HeaderText = "Starsi";
            this.starsi.Name = "starsi";
            this.starsi.ReadOnly = true;
            this.starsi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.starsi.Width = 40;
            // 
            // mlodsi
            // 
            this.mlodsi.HeaderText = "Młodsi";
            this.mlodsi.Name = "mlodsi";
            this.mlodsi.ReadOnly = true;
            this.mlodsi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.mlodsi.Width = 40;
            // 
            // post
            // 
            this.post.HeaderText = "Post";
            this.post.Name = "post";
            this.post.ReadOnly = true;
            this.post.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.post.Width = 40;
            // 
            // wielkanoc
            // 
            this.wielkanoc.HeaderText = "Wlknc";
            this.wielkanoc.Name = "wielkanoc";
            this.wielkanoc.ReadOnly = true;
            this.wielkanoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wielkanoc.Width = 40;
            // 
            // koledy
            // 
            this.koledy.HeaderText = "Koldy";
            this.koledy.Name = "koledy";
            this.koledy.ReadOnly = true;
            this.koledy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.koledy.Width = 40;
            // 
            // adwent
            // 
            this.adwent.HeaderText = "Adwnt";
            this.adwent.Name = "adwent";
            this.adwent.ReadOnly = true;
            this.adwent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.adwent.Width = 40;
            // 
            // maryjne
            // 
            this.maryjne.HeaderText = "Mrjne";
            this.maryjne.Name = "maryjne";
            this.maryjne.ReadOnly = true;
            this.maryjne.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.maryjne.Width = 40;
            // 
            // zwykle
            // 
            this.zwykle.HeaderText = "Zwkłe";
            this.zwykle.Name = "zwykle";
            this.zwykle.ReadOnly = true;
            this.zwykle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.zwykle.Width = 40;
            // 
            // nowa
            // 
            this.nowa.HeaderText = "N";
            this.nowa.Name = "nowa";
            this.nowa.ReadOnly = true;
            this.nowa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nowa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nowa.Width = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            this.pomocToolStripMenuItem.Click += new System.EventHandler(this.pomocToolStripMenuItem_Click);
            // 
            // wpisyText
            // 
            this.wpisyText.AutoSize = true;
            this.wpisyText.Location = new System.Drawing.Point(3, 5);
            this.wpisyText.Name = "wpisyText";
            this.wpisyText.Size = new System.Drawing.Size(39, 13);
            this.wpisyText.TabIndex = 7;
            this.wpisyText.Text = "Wpisy:";
            // 
            // nowaText
            // 
            this.nowaText.AutoSize = true;
            this.nowaText.Location = new System.Drawing.Point(3, 23);
            this.nowaText.Name = "nowaText";
            this.nowaText.Size = new System.Drawing.Size(94, 13);
            this.nowaText.TabIndex = 12;
            this.nowaText.Text = "Do przećwiczenia:";
            this.nowaText.DoubleClick += new System.EventHandler(this.nowaText_DoubleClick);
            // 
            // nowaInt
            // 
            this.nowaInt.AutoSize = true;
            this.nowaInt.Location = new System.Drawing.Point(103, 23);
            this.nowaInt.Name = "nowaInt";
            this.nowaInt.Size = new System.Drawing.Size(13, 13);
            this.nowaInt.TabIndex = 13;
            this.nowaInt.Text = "0";
            // 
            // bezchwytText
            // 
            this.bezchwytText.AutoSize = true;
            this.bezchwytText.Location = new System.Drawing.Point(122, 5);
            this.bezchwytText.Name = "bezchwytText";
            this.bezchwytText.Size = new System.Drawing.Size(73, 13);
            this.bezchwytText.TabIndex = 14;
            this.bezchwytText.Text = "Bez chwytów:";
            this.bezchwytText.DoubleClick += new System.EventHandler(this.bezchwytText_DoubleClick);
            // 
            // bezchwytInt
            // 
            this.bezchwytInt.AutoSize = true;
            this.bezchwytInt.Location = new System.Drawing.Point(222, 5);
            this.bezchwytInt.Name = "bezchwytInt";
            this.bezchwytInt.Size = new System.Drawing.Size(13, 13);
            this.bezchwytInt.TabIndex = 15;
            this.bezchwytInt.Text = "0";
            // 
            // statPanel
            // 
            this.statPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statPanel.BackColor = System.Drawing.SystemColors.Control;
            this.statPanel.Controls.Add(this.labelBezNumeru);
            this.statPanel.Controls.Add(this.nowaText);
            this.statPanel.Controls.Add(this.label1);
            this.statPanel.Controls.Add(this.wpisyText);
            this.statPanel.Controls.Add(this.labelBezNumeruInt);
            this.statPanel.Controls.Add(this.bezchwytInt);
            this.statPanel.Controls.Add(this.bezchwytText);
            this.statPanel.Controls.Add(this.nowaInt);
            this.statPanel.Location = new System.Drawing.Point(526, 16);
            this.statPanel.Name = "statPanel";
            this.statPanel.Size = new System.Drawing.Size(243, 42);
            this.statPanel.TabIndex = 16;
            // 
            // labelBezNumeru
            // 
            this.labelBezNumeru.AutoSize = true;
            this.labelBezNumeru.Location = new System.Drawing.Point(122, 23);
            this.labelBezNumeru.Name = "labelBezNumeru";
            this.labelBezNumeru.Size = new System.Drawing.Size(66, 13);
            this.labelBezNumeru.TabIndex = 16;
            this.labelBezNumeru.Text = "Bez numeru:";
            this.labelBezNumeru.DoubleClick += new System.EventHandler(this.labelBezNumeru_DoubleClick);
            // 
            // labelBezNumeruInt
            // 
            this.labelBezNumeruInt.AutoSize = true;
            this.labelBezNumeruInt.Location = new System.Drawing.Point(222, 23);
            this.labelBezNumeruInt.Name = "labelBezNumeruInt";
            this.labelBezNumeruInt.Size = new System.Drawing.Size(13, 13);
            this.labelBezNumeruInt.TabIndex = 15;
            this.labelBezNumeruInt.Text = "0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drukujToolStripMenuItem,
            this.zapiszDoPamięciToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 48);
            // 
            // drukujToolStripMenuItem
            // 
            this.drukujToolStripMenuItem.Name = "drukujToolStripMenuItem";
            this.drukujToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.drukujToolStripMenuItem.Text = "Drukuj";
            this.drukujToolStripMenuItem.Click += new System.EventHandler(this.drukujToolStripMenuItem_Click);
            // 
            // zapiszDoPamięciToolStripMenuItem
            // 
            this.zapiszDoPamięciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszDo1ToolStripMenuItem,
            this.zapiszDo2ToolStripMenuItem,
            this.drukujToolStripMenuItem1,
            this.wyczyśćPamięćToolStripMenuItem});
            this.zapiszDoPamięciToolStripMenuItem.Name = "zapiszDoPamięciToolStripMenuItem";
            this.zapiszDoPamięciToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.zapiszDoPamięciToolStripMenuItem.Text = "Pamięć";
            // 
            // zapiszDo1ToolStripMenuItem
            // 
            this.zapiszDo1ToolStripMenuItem.Name = "zapiszDo1ToolStripMenuItem";
            this.zapiszDo1ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.zapiszDo1ToolStripMenuItem.Text = "Zapisz do 1";
            this.zapiszDo1ToolStripMenuItem.Click += new System.EventHandler(this.zapiszDo1ToolStripMenuItem_Click);
            // 
            // zapiszDo2ToolStripMenuItem
            // 
            this.zapiszDo2ToolStripMenuItem.Name = "zapiszDo2ToolStripMenuItem";
            this.zapiszDo2ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.zapiszDo2ToolStripMenuItem.Text = "Zapisz do 2";
            this.zapiszDo2ToolStripMenuItem.Click += new System.EventHandler(this.zapiszDo2ToolStripMenuItem_Click);
            // 
            // drukujToolStripMenuItem1
            // 
            this.drukujToolStripMenuItem1.Name = "drukujToolStripMenuItem1";
            this.drukujToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.drukujToolStripMenuItem1.Text = "Drukuj z pamięci";
            this.drukujToolStripMenuItem1.Click += new System.EventHandler(this.drukujToolStripMenuItem1_Click);
            // 
            // wyczyśćPamięćToolStripMenuItem
            // 
            this.wyczyśćPamięćToolStripMenuItem.Name = "wyczyśćPamięćToolStripMenuItem";
            this.wyczyśćPamięćToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.wyczyśćPamięćToolStripMenuItem.Text = "Wyczyść pamięć";
            this.wyczyśćPamięćToolStripMenuItem.Click += new System.EventHandler(this.wyczyśćPamięćToolStripMenuItem_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(107, 33);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 17;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.MouseEnter += new System.EventHandler(this.textBoxSearch_MouseEnter);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(213, 31);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 18;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // BazaPiesni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 276);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.statPanel);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BazaPiesni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Baza Pieśni";
            this.Activated += new System.EventHandler(this.BazaPiesni_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BazaPiesni_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResizeEnd += new System.EventHandler(this.BazaPiesni_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statPanel.ResumeLayout(false);
            this.statPanel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.Label wpisyText;
        private System.Windows.Forms.Label nowaText;
        private System.Windows.Forms.Label nowaInt;
        private System.Windows.Forms.Label bezchwytText;
        private System.Windows.Forms.Label bezchwytInt;
        private System.Windows.Forms.Panel statPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytul;
        private System.Windows.Forms.DataGridViewCheckBoxColumn wejscie;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ofiarowanie;
        private System.Windows.Forms.DataGridViewCheckBoxColumn komunia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uwielbienie;
        private System.Windows.Forms.DataGridViewCheckBoxColumn wyjscie;
        private System.Windows.Forms.DataGridViewCheckBoxColumn krotka;
        private System.Windows.Forms.DataGridViewCheckBoxColumn srednia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dluga;
        private System.Windows.Forms.DataGridViewCheckBoxColumn starsi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mlodsi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn post;
        private System.Windows.Forms.DataGridViewCheckBoxColumn wielkanoc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn koledy;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adwent;
        private System.Windows.Forms.DataGridViewCheckBoxColumn maryjne;
        private System.Windows.Forms.DataGridViewCheckBoxColumn zwykle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nowa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem drukujToolStripMenuItem;
        private System.Windows.Forms.Label labelBezNumeru;
        private System.Windows.Forms.Label labelBezNumeruInt;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ToolStripMenuItem zapiszDoPamięciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszDo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszDo2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drukujToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wyczyśćPamięćToolStripMenuItem;

    }
}