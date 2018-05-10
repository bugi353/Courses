namespace arkanoid
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lewo = new System.Windows.Forms.Timer(this.components);
            this.prawo = new System.Windows.Forms.Timer(this.components);
            this.k1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.k3 = new System.Windows.Forms.PictureBox();
            this.k4 = new System.Windows.Forms.PictureBox();
            this.k5 = new System.Windows.Forms.PictureBox();
            this.k6 = new System.Windows.Forms.PictureBox();
            this.k7 = new System.Windows.Forms.PictureBox();
            this.k8 = new System.Windows.Forms.PictureBox();
            this.k9 = new System.Windows.Forms.PictureBox();
            this.k10 = new System.Windows.Forms.PictureBox();
            this.k11 = new System.Windows.Forms.PictureBox();
            this.k12 = new System.Windows.Forms.PictureBox();
            this.k2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.k1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lewo
            // 
            this.lewo.Interval = 20;
            this.lewo.Tick += new System.EventHandler(this.lewo_Tick);
            // 
            // prawo
            // 
            this.prawo.Interval = 20;
            this.prawo.Tick += new System.EventHandler(this.prawo_Tick);
            // 
            // k1
            // 
            this.k1.Image = global::arkanoid.Properties.Resources.klocek;
            this.k1.Location = new System.Drawing.Point(303, 12);
            this.k1.MaximumSize = new System.Drawing.Size(50, 50);
            this.k1.MinimumSize = new System.Drawing.Size(50, 50);
            this.k1.Name = "k1";
            this.k1.Size = new System.Drawing.Size(50, 50);
            this.k1.TabIndex = 2;
            this.k1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::arkanoid.Properties.Resources.paddle;
            this.pictureBox2.ImageLocation = "arkanoid/img/paddle.bmp";
            this.pictureBox2.InitialImage = global::arkanoid.Properties.Resources.paddle;
            this.pictureBox2.Location = new System.Drawing.Point(386, 711);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(150, 30);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(150, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.ImageLocation = "arkanoid/img/ball.bmp";
            this.pictureBox1.InitialImage = global::arkanoid.Properties.Resources.ball;
            this.pictureBox1.Location = new System.Drawing.Point(455, 342);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(30, 30);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(30, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // k3
            // 
            this.k3.Image = global::arkanoid.Properties.Resources.klocek;
            this.k3.Location = new System.Drawing.Point(415, 12);
            this.k3.MaximumSize = new System.Drawing.Size(50, 50);
            this.k3.MinimumSize = new System.Drawing.Size(50, 50);
            this.k3.Name = "k3";
            this.k3.Size = new System.Drawing.Size(50, 50);
            this.k3.TabIndex = 4;
            this.k3.TabStop = false;
            // 
            // k4
            // 
            this.k4.Image = global::arkanoid.Properties.Resources.klocek;
            this.k4.Location = new System.Drawing.Point(471, 12);
            this.k4.MaximumSize = new System.Drawing.Size(50, 50);
            this.k4.MinimumSize = new System.Drawing.Size(50, 50);
            this.k4.Name = "k4";
            this.k4.Size = new System.Drawing.Size(50, 50);
            this.k4.TabIndex = 5;
            this.k4.TabStop = false;
            // 
            // k5
            // 
            this.k5.Image = global::arkanoid.Properties.Resources.klocek;
            this.k5.Location = new System.Drawing.Point(527, 12);
            this.k5.MaximumSize = new System.Drawing.Size(50, 50);
            this.k5.MinimumSize = new System.Drawing.Size(50, 50);
            this.k5.Name = "k5";
            this.k5.Size = new System.Drawing.Size(50, 50);
            this.k5.TabIndex = 6;
            this.k5.TabStop = false;
            // 
            // k6
            // 
            this.k6.Image = global::arkanoid.Properties.Resources.klocek;
            this.k6.Location = new System.Drawing.Point(583, 12);
            this.k6.MaximumSize = new System.Drawing.Size(50, 50);
            this.k6.MinimumSize = new System.Drawing.Size(50, 50);
            this.k6.Name = "k6";
            this.k6.Size = new System.Drawing.Size(50, 50);
            this.k6.TabIndex = 7;
            this.k6.TabStop = false;
            // 
            // k7
            // 
            this.k7.Image = global::arkanoid.Properties.Resources.klocek;
            this.k7.Location = new System.Drawing.Point(359, 68);
            this.k7.MaximumSize = new System.Drawing.Size(50, 50);
            this.k7.MinimumSize = new System.Drawing.Size(50, 50);
            this.k7.Name = "k7";
            this.k7.Size = new System.Drawing.Size(50, 50);
            this.k7.TabIndex = 8;
            this.k7.TabStop = false;
            // 
            // k8
            // 
            this.k8.Image = global::arkanoid.Properties.Resources.klocek;
            this.k8.Location = new System.Drawing.Point(415, 68);
            this.k8.MaximumSize = new System.Drawing.Size(50, 50);
            this.k8.MinimumSize = new System.Drawing.Size(50, 50);
            this.k8.Name = "k8";
            this.k8.Size = new System.Drawing.Size(50, 50);
            this.k8.TabIndex = 9;
            this.k8.TabStop = false;
            // 
            // k9
            // 
            this.k9.Image = global::arkanoid.Properties.Resources.klocek;
            this.k9.Location = new System.Drawing.Point(471, 68);
            this.k9.MaximumSize = new System.Drawing.Size(50, 50);
            this.k9.MinimumSize = new System.Drawing.Size(50, 50);
            this.k9.Name = "k9";
            this.k9.Size = new System.Drawing.Size(50, 50);
            this.k9.TabIndex = 10;
            this.k9.TabStop = false;
            // 
            // k10
            // 
            this.k10.Image = global::arkanoid.Properties.Resources.klocek;
            this.k10.Location = new System.Drawing.Point(527, 68);
            this.k10.MaximumSize = new System.Drawing.Size(50, 50);
            this.k10.MinimumSize = new System.Drawing.Size(50, 50);
            this.k10.Name = "k10";
            this.k10.Size = new System.Drawing.Size(50, 50);
            this.k10.TabIndex = 11;
            this.k10.TabStop = false;
            // 
            // k11
            // 
            this.k11.Image = global::arkanoid.Properties.Resources.klocek;
            this.k11.Location = new System.Drawing.Point(415, 124);
            this.k11.MaximumSize = new System.Drawing.Size(50, 50);
            this.k11.MinimumSize = new System.Drawing.Size(50, 50);
            this.k11.Name = "k11";
            this.k11.Size = new System.Drawing.Size(50, 50);
            this.k11.TabIndex = 12;
            this.k11.TabStop = false;
            // 
            // k12
            // 
            this.k12.Image = global::arkanoid.Properties.Resources.klocek;
            this.k12.Location = new System.Drawing.Point(471, 124);
            this.k12.MaximumSize = new System.Drawing.Size(50, 50);
            this.k12.MinimumSize = new System.Drawing.Size(50, 50);
            this.k12.Name = "k12";
            this.k12.Size = new System.Drawing.Size(50, 50);
            this.k12.TabIndex = 13;
            this.k12.TabStop = false;
            // 
            // k2
            // 
            this.k2.Image = global::arkanoid.Properties.Resources.klocek;
            this.k2.Location = new System.Drawing.Point(359, 12);
            this.k2.MaximumSize = new System.Drawing.Size(50, 50);
            this.k2.MinimumSize = new System.Drawing.Size(50, 50);
            this.k2.Name = "k2";
            this.k2.Size = new System.Drawing.Size(50, 50);
            this.k2.TabIndex = 14;
            this.k2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(271, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(382, 61);
            this.button1.TabIndex = 15;
            this.button1.Text = "Wygrana! Jeszcze raz?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.k2);
            this.Controls.Add(this.k12);
            this.Controls.Add(this.k11);
            this.Controls.Add(this.k10);
            this.Controls.Add(this.k9);
            this.Controls.Add(this.k8);
            this.Controls.Add(this.k7);
            this.Controls.Add(this.k6);
            this.Controls.Add(this.k5);
            this.Controls.Add(this.k4);
            this.Controls.Add(this.k3);
            this.Controls.Add(this.k1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.k1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer lewo;
        private System.Windows.Forms.Timer prawo;
        private System.Windows.Forms.PictureBox k1;
        private System.Windows.Forms.PictureBox k3;
        private System.Windows.Forms.PictureBox k4;
        private System.Windows.Forms.PictureBox k5;
        private System.Windows.Forms.PictureBox k6;
        private System.Windows.Forms.PictureBox k7;
        private System.Windows.Forms.PictureBox k8;
        private System.Windows.Forms.PictureBox k9;
        private System.Windows.Forms.PictureBox k10;
        private System.Windows.Forms.PictureBox k11;
        private System.Windows.Forms.PictureBox k12;
        private System.Windows.Forms.PictureBox k2;
        private System.Windows.Forms.Button button1;
    }
}

