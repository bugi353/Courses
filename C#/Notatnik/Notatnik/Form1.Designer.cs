namespace Notatnik
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopiujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wklejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wytnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.zaznaczWszystkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wybórCzcionkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.mysz2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nowyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kopiujToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wklejToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wytnijToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zaznaczWszystkoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.odznaczWszystkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.mysz2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.informacjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.toolStripMenuItem1,
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem1,
            this.zapiszJakoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.plikToolStripMenuItem.Text = "&Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.nowyToolStripMenuItem.Text = "&Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(156, 6);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.otwórzToolStripMenuItem.Text = "&Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem1
            // 
            this.zapiszToolStripMenuItem1.Name = "zapiszToolStripMenuItem1";
            this.zapiszToolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
            this.zapiszToolStripMenuItem1.Text = "&Zapisz";
            this.zapiszToolStripMenuItem1.Click += new System.EventHandler(this.zapiszToolStripMenuItem1_Click);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.zapiszJakoToolStripMenuItem.Text = "Z&apisz jako";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(156, 6);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.zamknijToolStripMenuItem.Text = "Za&mknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopiujToolStripMenuItem,
            this.wklejToolStripMenuItem,
            this.wytnijToolStripMenuItem,
            this.toolStripMenuItem2,
            this.zaznaczWszystkoToolStripMenuItem,
            this.wybórCzcionkiToolStripMenuItem});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.edycjaToolStripMenuItem.Text = "E&dycja";
            // 
            // kopiujToolStripMenuItem
            // 
            this.kopiujToolStripMenuItem.Name = "kopiujToolStripMenuItem";
            this.kopiujToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.kopiujToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.kopiujToolStripMenuItem.Text = "&Kopiuj";
            this.kopiujToolStripMenuItem.Click += new System.EventHandler(this.kopiujToolStripMenuItem_Click);
            // 
            // wklejToolStripMenuItem
            // 
            this.wklejToolStripMenuItem.Name = "wklejToolStripMenuItem";
            this.wklejToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.wklejToolStripMenuItem.Text = "&Wklej";
            this.wklejToolStripMenuItem.Click += new System.EventHandler(this.wklejToolStripMenuItem_Click);
            // 
            // wytnijToolStripMenuItem
            // 
            this.wytnijToolStripMenuItem.Name = "wytnijToolStripMenuItem";
            this.wytnijToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.wytnijToolStripMenuItem.Text = "&Wytnij";
            this.wytnijToolStripMenuItem.Click += new System.EventHandler(this.wytnijToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(197, 6);
            // 
            // zaznaczWszystkoToolStripMenuItem
            // 
            this.zaznaczWszystkoToolStripMenuItem.Name = "zaznaczWszystkoToolStripMenuItem";
            this.zaznaczWszystkoToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.zaznaczWszystkoToolStripMenuItem.Text = "&Zaznacz wszystko";
            this.zaznaczWszystkoToolStripMenuItem.Click += new System.EventHandler(this.zaznaczWszystkoToolStripMenuItem_Click);
            // 
            // wybórCzcionkiToolStripMenuItem
            // 
            this.wybórCzcionkiToolStripMenuItem.Name = "wybórCzcionkiToolStripMenuItem";
            this.wybórCzcionkiToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.wybórCzcionkiToolStripMenuItem.Text = "&Wybór czcionki";
            this.wybórCzcionkiToolStripMenuItem.Click += new System.EventHandler(this.wybórCzcionkiToolStripMenuItem_Click);
            // 
            // informacjeToolStripMenuItem
            // 
            this.informacjeToolStripMenuItem.Name = "informacjeToolStripMenuItem";
            this.informacjeToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.informacjeToolStripMenuItem.Text = "&Informacje";
            this.informacjeToolStripMenuItem.Click += new System.EventHandler(this.informacjeToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.mysz2;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(584, 425);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // mysz2
            // 
            this.mysz2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mysz2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem1,
            this.kopiujToolStripMenuItem1,
            this.wklejToolStripMenuItem1,
            this.wytnijToolStripMenuItem1,
            this.zaznaczWszystkoToolStripMenuItem1,
            this.odznaczWszystkoToolStripMenuItem,
            this.zamknijToolStripMenuItem1});
            this.mysz2.Name = "mysz2";
            this.mysz2.Size = new System.Drawing.Size(204, 186);
            // 
            // nowyToolStripMenuItem1
            // 
            this.nowyToolStripMenuItem1.Name = "nowyToolStripMenuItem1";
            this.nowyToolStripMenuItem1.Size = new System.Drawing.Size(203, 26);
            this.nowyToolStripMenuItem1.Text = "Nowy";
            this.nowyToolStripMenuItem1.Click += new System.EventHandler(this.nowyToolStripMenuItem1_Click);
            // 
            // kopiujToolStripMenuItem1
            // 
            this.kopiujToolStripMenuItem1.Name = "kopiujToolStripMenuItem1";
            this.kopiujToolStripMenuItem1.Size = new System.Drawing.Size(203, 26);
            this.kopiujToolStripMenuItem1.Text = "Kopiuj";
            this.kopiujToolStripMenuItem1.Click += new System.EventHandler(this.kopiujToolStripMenuItem1_Click);
            // 
            // wklejToolStripMenuItem1
            // 
            this.wklejToolStripMenuItem1.Name = "wklejToolStripMenuItem1";
            this.wklejToolStripMenuItem1.Size = new System.Drawing.Size(203, 26);
            this.wklejToolStripMenuItem1.Text = "Wklej";
            this.wklejToolStripMenuItem1.Click += new System.EventHandler(this.wklejToolStripMenuItem1_Click);
            // 
            // wytnijToolStripMenuItem1
            // 
            this.wytnijToolStripMenuItem1.Name = "wytnijToolStripMenuItem1";
            this.wytnijToolStripMenuItem1.Size = new System.Drawing.Size(203, 26);
            this.wytnijToolStripMenuItem1.Text = "Wytnij";
            this.wytnijToolStripMenuItem1.Click += new System.EventHandler(this.wytnijToolStripMenuItem1_Click);
            // 
            // zaznaczWszystkoToolStripMenuItem1
            // 
            this.zaznaczWszystkoToolStripMenuItem1.Name = "zaznaczWszystkoToolStripMenuItem1";
            this.zaznaczWszystkoToolStripMenuItem1.Size = new System.Drawing.Size(203, 26);
            this.zaznaczWszystkoToolStripMenuItem1.Text = "Zaznacz wszystko";
            this.zaznaczWszystkoToolStripMenuItem1.Click += new System.EventHandler(this.zaznaczWszystkoToolStripMenuItem1_Click);
            // 
            // odznaczWszystkoToolStripMenuItem
            // 
            this.odznaczWszystkoToolStripMenuItem.Name = "odznaczWszystkoToolStripMenuItem";
            this.odznaczWszystkoToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.odznaczWszystkoToolStripMenuItem.Text = "Odznacz wszystko";
            this.odznaczWszystkoToolStripMenuItem.Click += new System.EventHandler(this.odznaczWszystkoToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem1
            // 
            this.zamknijToolStripMenuItem1.Name = "zamknijToolStripMenuItem1";
            this.zamknijToolStripMenuItem1.Size = new System.Drawing.Size(203, 26);
            this.zamknijToolStripMenuItem1.Text = "Zamknij";
            this.zamknijToolStripMenuItem1.Click += new System.EventHandler(this.zamknijToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 453);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.Text = "Notatnik";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mysz2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem zaznaczWszystkoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjeToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem wybórCzcionkiToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip mysz2;
        private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zaznaczWszystkoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem odznaczWszystkoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem1;
    }
}

