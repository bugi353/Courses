using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class Form1 : Form
    {
        #region Zmienne

        string sciezka = "";

        #endregion Zmienne

        #region Funkcje

        private void zapiszplik()
        {
            SaveFileDialog dialogzapis = new SaveFileDialog();
            dialogzapis.Filter = "plik tekstowy(TXT)|*.txt";
            if (dialogzapis.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(dialogzapis.FileName, richTextBox1.Text);
                sciezka = dialogzapis.FileName;

                MessageBox.Show("Zapisano plik.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else return;
        }

        #endregion Funkcje

        #region Konstruktor

        public Form1()
        {
            InitializeComponent();
        }

      

        #endregion Konstruktor

        #region Plik

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sciezka))
            {
                if (!string.IsNullOrWhiteSpace(richTextBox1.Text))
                {
                    DialogResult wynik = MessageBox.Show("Nie zapisano pliku. Czy chcesz zapisać plik?", "Uwaga!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (wynik == DialogResult.Yes)
                    {
                        zapiszJakoToolStripMenuItem_Click(sender, e);
                        
                    }
                    else
                    {
                        richTextBox1.Text = "";
                        sciezka = "";
                    }
                }
                else
                {
                    richTextBox1.Text = "";
                    sciezka = "";
                }
            }

            else if(richTextBox1.Text != File.ReadAllText(sciezka))
            {
                DialogResult wynik = MessageBox.Show("Nie zapisano pliku. Czy chcesz zapisać plik?", "Uwaga!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (wynik == DialogResult.Yes)
                {
                    zapiszJakoToolStripMenuItem_Click(sender, e);
                    
                }
                else
                {
                    richTextBox1.Text = "";
                    sciezka = "";
                }
            }
            else
            {
                richTextBox1.Text = "";
                sciezka = "";
            }
           
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Plik tekstowy(TXT)|*.txt";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sciezka = openFileDialog1.FileName;
                richTextBox1.Text = File.ReadAllText(sciezka);

            }
            else return;

        }


        private void zapiszToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sciezka))
            {
                zapiszplik();
            } 
            else
            {
                File.WriteAllText(sciezka, richTextBox1.Text);
                
                MessageBox.Show("Zapisano plik.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
                zapiszplik();
        }

        

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Plik

        #region Edycja

        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void zaznaczWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void wybórCzcionkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrWhiteSpace(richTextBox1.SelectedText))
                {
                    richTextBox1.Font = dialog.Font;

                }
                else
                {
                    richTextBox1.SelectionFont = dialog.Font;
                }
            }
            else return;
        }

        #endregion Edycja

        #region Informacje

        private void informacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ten notatnik został zrobiony przez Bugiego", "Halooooo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        #endregion Informacje

        #region menukontekstowe

        private void nowyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nowyToolStripMenuItem_Click(sender, e);
        }

        private void kopiujToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void wklejToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void wytnijToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void zaznaczWszystkoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void odznaczWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.DeselectAll();
        }

        private void zamknijToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        #endregion menukontekstowe

        #region skróty


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode.ToString() == "N")
            {
                nowyToolStripMenuItem_Click(sender, e);
            }
            if (e.Control && e.KeyCode.ToString() == "O")
            {
                otwórzToolStripMenuItem_Click(sender, e);
            }
            if (e.Control && e.KeyCode.ToString() == "Z")
            {
                zapiszToolStripMenuItem1_Click(sender,  e);
            }
            if (e.Control && e.KeyCode.ToString() == "A")
            {
                zapiszJakoToolStripMenuItem_Click( sender,  e);
            }
            if (e.Control && e.KeyCode.ToString() == "M")
            {
                zamknijToolStripMenuItem_Click( sender,  e);
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Form1_KeyDown(sender, e);
        }

        #endregion skróty
    }


}
