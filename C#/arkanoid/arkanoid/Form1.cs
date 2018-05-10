using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace arkanoid
{
    public partial class Form1 : Form
    {
        #region zmienne

        int x=4, y=4;
        int xp, yp;
        char klawisz;
        int do_wygranej=12;



        #endregion zmienne

        


        public Form1()
        {
            InitializeComponent();
            pictureBox2.Top = this.Size.Height - pictureBox2.Size.Height -50;
            
        }

        static bool Kolizja(PictureBox pilka, PictureBox klocek)
        {
            if (pilka.Left >= klocek.Left - pilka.Width && pilka.Left <= klocek.Left + klocek.Width &&
                pilka.Top >= klocek.Top - pilka.Height && pilka.Top <= klocek.Top + klocek.Height)
            {
                return true;
            }
            else
                return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += x;
            pictureBox1.Top += y;

            if (pictureBox1.Left+35>=this.Size.Width|| pictureBox1.Left - 5<=0)
            {
                x = -x;
            }
            if (pictureBox1.Top + 5 <= 0)
            {
                y = -y;
            }
            if (pictureBox1.Top >= pictureBox2.Top+15)
            {
                timer1.Enabled = false;

                DialogResult pytanie = MessageBox.Show("PRZEGRANA!", "PRZEGRANA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pytanie == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
                
            }
            else if (((pictureBox1.Left >= pictureBox2.Left - pictureBox1.Width / 2) && (pictureBox1.Left + pictureBox1.Width / 2 <= pictureBox2.Left + pictureBox2.Width))&&(pictureBox1.Top+pictureBox1.Height>=pictureBox2.Top))
            {
                if (y > 0)
                {
                    y = -y;
                }
            }

            #region bloki

            if (Kolizja(pictureBox1,k1) && k1.Visible == true)
            {
                x = -x; y = -y; k1.Visible = false; do_wygranej--;
            }

            if (Kolizja(pictureBox1, k2) && k2.Visible == true)
            {
                x = -x; y = -y; k2.Visible = false; do_wygranej--;
            }

            if (Kolizja(pictureBox1, k3) && k3.Visible == true)
            {
                x = -x; y = -y; k3.Visible = false; do_wygranej--;
            }

            if (Kolizja(pictureBox1, k4) && k4.Visible == true)
            {
                x = -x; y = -y; k4.Visible = false; do_wygranej--;
            }

            if (Kolizja(pictureBox1, k5) && k5.Visible == true)
            {
                x = -x; y = -y; k5.Visible = false; do_wygranej--;
            }

            if (Kolizja(pictureBox1, k6) && k6.Visible == true)
            {
                x = -x; y = -y; k6.Visible = false; do_wygranej--;
            }

            if (Kolizja(pictureBox1, k7) && k7.Visible == true)
            {
                x = -x; y = -y; k7.Visible = false; do_wygranej--;
            }

            if (Kolizja(pictureBox1, k8) && k8.Visible == true)
            {
                x = -x; y = -y; k8.Visible = false; do_wygranej--;
            }

            if (Kolizja(pictureBox1, k9) && k9.Visible == true)
            {
                x = -x; y = -y; k9.Visible = false; do_wygranej--;
            }

            if (Kolizja(pictureBox1, k10) && k10.Visible == true)
            {
                x = -x; y = -y; k10.Visible = false; do_wygranej--;
            }

            if (Kolizja(pictureBox1, k11) && k11.Visible == true)
            {
                x = -x; y = -y; k11.Visible = false; do_wygranej--;
            }

            if (Kolizja(pictureBox1, k12) && k12.Visible == true)
            {
                x = -x; y = -y; k12.Visible = false; do_wygranej--;
            }

            #endregion bloki

            if (do_wygranej<=0)
            {
                timer1.Enabled = false;
                pictureBox1.Visible = false;
                button1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        #region sterowanie

        private void lewo_Tick(object sender, EventArgs e)
        {
            
            if (pictureBox2.Left - 5 >= 0)
            {
                pictureBox2.Left -= 10;
            }
        }

        private void prawo_Tick(object sender, EventArgs e)
        {
            
            if (pictureBox2.Left + pictureBox2.Size.Width +25 <= this.Size.Width)
            {
                pictureBox2.Left += 10;
            }
        }

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                lewo.Enabled = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                prawo.Enabled = true;
            }
        }

        

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                lewo.Enabled = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                prawo.Enabled = false;
            }
        }

        #endregion sterowanie

        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }
    }
}
