﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            uint cislo = 0;
            
            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("První pole nesmí zůstat nevyplněno!");
            }
            if (textBox1.TextLength > 0)
            {
                try
                {
                    cislo = Convert.ToUInt32(textBox1.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Musíte zadat pouze čísla");
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Číslo je příliš velké");
                }
            }
            if (!dvojkova.Checked && !sestkova.Checked && !osmickova.Checked && !sestnactkova.Checked)
            {
                MessageBox.Show("Zvolte alespoň jednu soustavu, do které chcete číslo převést!");
            }
            
            if (dvojkova.Checked)
            {
                string C = PrevodyCisel.Binary(cislo);
                textDvojkova.Text = C;
            }
            if (sestkova.Checked)
            {
                string C = PrevodyCisel.Hex(cislo);
                textSestkova.Text = C;
            }
            if (osmickova.Checked)
            {
                string C = PrevodyCisel.Okta(cislo);
                textOsmickova.Text = C;
            }
            if (sestnactkova.Checked)
            {
                string C = PrevodyCisel.HexDec(cislo);
                textSestnactkova.Text = C;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
