using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace timer
{
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region zmienne

        int s = 10;
        int godzina, minuta, sekunda;
        string godz, min, sek;
        int zmiana = 1;

       

        string licznik;

        SoundPlayer muzyka = new SoundPlayer("myk.wav");

        #endregion zmienne

        #region liczniki

        private void czas_Tick(object sender, EventArgs e)
        {
            s--;
            godzina = s / 3600;
                minuta = (s - godzina * 3600) / 60;
                sekunda = s - godzina * 3600 - minuta * 60;

            godz = Convert.ToString(godzina);
            if (godzina < 10)
                godz = "0" + godz;
            min = Convert.ToString(minuta);
            if (minuta < 10)
                min = "0" + min;
            sek = Convert.ToString(sekunda);
            if (sekunda < 10)
                sek = "0" + sek;
            licznik = godz + ":" + min + ":" + sek;
            zegar.Text = licznik;

            if(s<=0)
            {
                zegar.Text = "KONIEC CZASU!";
                    czas.Enabled = false;
                muzyka.Play();
                timer1.Enabled = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(zmiana)
            {
                case 1:
                     zegar.BackColor = System.Drawing.Color.Yellow;
                     this.BackColor = System.Drawing.Color.BlanchedAlmond;
                    break;
                case 2:
                    zegar.BackColor = System.Drawing.Color.Pink;
                    this.BackColor = System.Drawing.Color.Aquamarine;
                    break;
                case 3:
                    zegar.BackColor = System.Drawing.Color.Orange;
                    this.BackColor = System.Drawing.Color.Violet;
                    break;
                case 4:
                    zegar.BackColor = System.Drawing.Color.Green;
                    this.BackColor = System.Drawing.Color.Gold;
                    break;
                    

            }
            zmiana++;
            if (zmiana == 5)
            {
                zmiana = 1;
            }
        }

        #endregion liczniki

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            s = Convert.ToInt32(textBox1.Text);
            czas.Enabled = true;
        }
    }
}
