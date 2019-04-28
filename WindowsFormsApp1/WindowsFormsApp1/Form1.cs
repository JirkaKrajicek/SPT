using System;
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
            //inicializace integeru bez znaménka
            uint cislo = 0;
            //ošetření vstupu (nic není zadáno/zadána je nula)
            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("První pole nesmí zůstat nevyplněno!");
            }
            //ošetření vstupu (pokud je zadáné více než nula znaků, provede es následující)
            if (textBox1.TextLength > 0)
            {
                //funkce pro otypování zadaného řetězce na uint

                try
                {
                    cislo = Convert.ToUInt32(textBox1.Text);
                }
                //chytá neplatný vstup
                catch (FormatException)
                {
                    MessageBox.Show("Musíte zadat pouze čísla");
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Číslo je příliš velké");
                }
            }
            //ošetřuje to, že musí být zvolena alespoň jedna soustava, do které se má číslo převést
            if (!dvojkova.Checked && !sestkova.Checked && !osmickova.Checked && !sestnactkova.Checked)
            {
                MessageBox.Show("Zvolte alespoň jednu soustavu, do které chcete číslo převést!");
            }
            
            //ošetřuje možnost volby převodu do dané soustavy (ošetřeno je i opakované zadání - pokud daná soustava není zvolena, vymaže se její pole)
            if (dvojkova.Checked)
            {
                string C = PrevodyCisel.Binary(cislo);
                textDvojkova.Text = C;
            }
            else textDvojkova.Clear();
            if (sestkova.Checked)
            {
                string C = PrevodyCisel.Hex(cislo);
                textSestkova.Text = C;
            }
            else textSestkova.Clear();
            if (osmickova.Checked)
            {
                string C = PrevodyCisel.Okta(cislo);
                textOsmickova.Text = C;
            }
            else textOsmickova.Clear();
            if (sestnactkova.Checked)
            {
                string C = PrevodyCisel.HexDec(cislo);
                textSestnactkova.Text = C;
            }
            else textSestnactkova.Clear();
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
