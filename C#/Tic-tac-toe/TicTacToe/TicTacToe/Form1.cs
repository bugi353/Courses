using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        #region zmienne

        char p1, p2, p3, p4, p5, p6, p7, p8, p9;

        



        // pola w grze (ich zawartosc p1 = 'n' lub p1 = 'x' lub p1 = 'o' w zaleznosci kto postil znak)

        char kto;

        #endregion zmienne

        

        public Form1()
        {
            InitializeComponent();
        }

        #region funkcja sprawdzajaca wygrana

        private void reset()
        {
            pictureBox1.Image = Image.FromFile(@"img/puste.bmp");
            pictureBox2.Image = Image.FromFile(@"img/puste.bmp");
            pictureBox3.Image = Image.FromFile(@"img/puste.bmp");
            pictureBox4.Image = Image.FromFile(@"img/puste.bmp");
            pictureBox5.Image = Image.FromFile(@"img/puste.bmp");
            pictureBox6.Image = Image.FromFile(@"img/puste.bmp");
            pictureBox7.Image = Image.FromFile(@"img/puste.bmp");
            pictureBox8.Image = Image.FromFile(@"img/puste.bmp");
            pictureBox9.Image = Image.FromFile(@"img/puste.bmp");
            tura.Image = Image.FromFile(@"img/os.bmp");

            p1 = 'n'; p2 = 'n'; p3 = 'n';
            p4 = 'n'; p5 = 'n'; p6 = 'n';
            p7 = 'n'; p8 = 'n'; p9 = 'n';
            kto = 'o';

            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
        }
        #region oprawa muzyczna

        SoundPlayer sound = new SoundPlayer("img/myk.wav");

        #endregion oprawa muzyczna
        private void sprawdz()
        {
            if ((p1 == p2 && p2 == p3 && p1 != 'n') ||
                    (p4 == p5 && p5 == p6 && p4 != 'n') ||
                    (p7 == p8 && p8 == p9 && p7 != 'n') ||
                    (p1 == p4 && p4 == p7 && p1 != 'n') ||
                    (p2 == p5 && p5 == p8 && p2 != 'n') ||
                    (p3 == p6 && p6 == p9 && p3 != 'n') ||
                    (p1 == p5 && p5 == p9 && p1 != 'n') ||
                    (p3 == p5 && p5 == p7 && p3 != 'n'))
            {
                if (kto == 'o')
                {
                    sound.Play();
                    DialogResult reset1 = MessageBox.Show("Wygrał gracz X", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (reset1 == DialogResult.OK)
                    {
                        reset();
                        sound.Stop();
                    }
                }

                if (kto == 'x')
                {
                    
                    
                    sound.Play();
                    DialogResult reset1 = MessageBox.Show("Wygrał gracz O", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (reset1 == DialogResult.OK)
                    {
                        reset();
                        sound.Stop();
                    }
                }
            }

        }

        #endregion funkcja sprawdzajaca wygrana

        #region stan poczatkowy

        private void Form1_Activated(object sender, EventArgs e)
        {
             
            pictureBox1.Image = Image.FromFile(@"img/puste.bmp");
            pictureBox2.Image = Image.FromFile(@"img/puste.bmp");
            pictureBox3.Image = Image.FromFile(@"img/puste.bmp");
            pictureBox4.Image = Image.FromFile(@"img/puste.bmp");
            pictureBox5.Image = Image.FromFile(@"img/puste.bmp");
            pictureBox6.Image = Image.FromFile(@"img/puste.bmp");
            pictureBox7.Image = Image.FromFile(@"img/puste.bmp");
            pictureBox8.Image = Image.FromFile(@"img/puste.bmp");
            pictureBox9.Image = Image.FromFile(@"img/puste.bmp");
            tura.Image = Image.FromFile(@"img/os.bmp");

            p1 = 'n'; p2 = 'n'; p3 = 'n';
            p4 = 'n'; p5 = 'n'; p6 = 'n';
            p7 = 'n'; p8 = 'n'; p9 = 'n';
            kto = 'o';

        }

        #endregion stan poczatkowy

        #region pola gry

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (p1 == 'n')
            {
                if (kto == 'o')
                {
                    pictureBox1.Image = Image.FromFile(@"img/o.bmp");
                    p1 = 'o';
                    kto = 'x';
                    tura.Image = Image.FromFile(@"img/xs.bmp");
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(@"img/x.bmp");
                    p1 = 'x';
                    kto = 'o';
                    tura.Image = Image.FromFile(@"img/os.bmp");
                }
                pictureBox1.Enabled = false;
                sprawdz();
            }
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (p2 == 'n')
            {
                if (kto == 'o')
                {
                    pictureBox2.Image = Image.FromFile(@"img/o.bmp");
                    p2 = 'o';
                    kto = 'x';
                    tura.Image = Image.FromFile(@"img/xs.bmp");
                }
                else
                {
                    pictureBox2.Image = Image.FromFile(@"img/x.bmp");
                    p2 = 'x';
                    kto = 'o';
                    tura.Image = Image.FromFile(@"img/os.bmp");
                }
                pictureBox2.Enabled = false;
                sprawdz();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (p3 == 'n')
            {
                if (kto == 'o')
                {
                    pictureBox3.Image = Image.FromFile(@"img/o.bmp");
                    p3 = 'o';
                    kto = 'x';
                    tura.Image = Image.FromFile(@"img/xs.bmp");
                }
                else
                {
                    pictureBox3.Image = Image.FromFile(@"img/x.bmp");
                    p3 = 'x';
                    kto = 'o';
                    tura.Image = Image.FromFile(@"img/os.bmp");
                }
                pictureBox3.Enabled = false;
                sprawdz();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (p4 == 'n')
            {
                if (kto == 'o')
                {
                    pictureBox4.Image = Image.FromFile(@"img/o.bmp");
                    p4 = 'o';
                    kto = 'x';
                    tura.Image = Image.FromFile(@"img/xs.bmp");
                }
                else
                {
                    pictureBox4.Image = Image.FromFile(@"img/x.bmp");
                    p4 = 'x';
                    kto = 'o';
                    tura.Image = Image.FromFile(@"img/os.bmp");
                }
                pictureBox4.Enabled = false;
                sprawdz();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (p5 == 'n')
            {
                if (kto == 'o')
                {
                    pictureBox5.Image = Image.FromFile(@"img/o.bmp");
                    p5 = 'o';
                    kto = 'x';
                    tura.Image = Image.FromFile(@"img/xs.bmp");
                }
                else
                {
                    pictureBox5.Image = Image.FromFile(@"img/x.bmp");
                    p5 = 'x';
                    kto = 'o';
                    tura.Image = Image.FromFile(@"img/os.bmp");
                }
                pictureBox5.Enabled = false;
                sprawdz();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (p6 == 'n')
            {
                if (kto == 'o')
                {
                    pictureBox6.Image = Image.FromFile(@"img/o.bmp");
                    p6 = 'o';
                    kto = 'x';
                    tura.Image = Image.FromFile(@"img/xs.bmp");
                }
                else
                {
                    pictureBox6.Image = Image.FromFile(@"img/x.bmp");
                    p6 = 'x';
                    kto = 'o';
                    tura.Image = Image.FromFile(@"img/os.bmp");
                }
                pictureBox6.Enabled = false;
                sprawdz();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (p7 == 'n')
            {
                if (kto == 'o')
                {
                    pictureBox7.Image = Image.FromFile(@"img/o.bmp");
                    p7 = 'o';
                    kto = 'x';
                    tura.Image = Image.FromFile(@"img/xs.bmp");
                }
                else
                {
                    pictureBox7.Image = Image.FromFile(@"img/x.bmp");
                    p7 = 'x';
                    kto = 'o';
                    tura.Image = Image.FromFile(@"img/os.bmp");
                }
                pictureBox7.Enabled = false;
                sprawdz();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (p8 == 'n')
            {
                if (kto == 'o')
                {
                    pictureBox8.Image = Image.FromFile(@"img/o.bmp");
                    p8 = 'o';
                    kto = 'x';
                    tura.Image = Image.FromFile(@"img/xs.bmp");
                }
                else
                {
                    pictureBox8.Image = Image.FromFile(@"img/x.bmp");
                    p8 = 'x';
                    kto = 'o';
                    tura.Image = Image.FromFile(@"img/os.bmp");
                }
                pictureBox8.Enabled = false;
                sprawdz();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (p9 == 'n')
            {
                if (kto == 'o')
                {
                    pictureBox9.Image = Image.FromFile(@"img/o.bmp");
                    p9 = 'o';
                    kto = 'x';
                    tura.Image = Image.FromFile(@"img/xs.bmp");
                }
                else
                {
                    pictureBox9.Image = Image.FromFile(@"img/x.bmp");
                    p9 = 'x';
                    kto = 'o';
                    tura.Image = Image.FromFile(@"img/os.bmp");
                }
                pictureBox9.Enabled = false;
                sprawdz();
            }
        }
        #endregion pola gry

        #region restart

        private void Breset_Click(object sender, EventArgs e)
        {
            reset();
        }

        

        #endregion restart


    }
}
