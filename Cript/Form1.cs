using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cript
{
    public partial class Form1 : Form
    {

        String palavra, palavra2, palavra3 = "";
        String frase;
        int paa;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCript_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtBox1.Text))
            {
                MessageBox.Show("Você precisa colocar escrever algo!", "Aviso",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                frase = txtBox1.Text.ToUpper();

                for (int i = 0; i < frase.Length; i++)
                {
                    int pa = (int)frase[i];
                    paa = pa + 10;

                    if (i % 2 == 1)
                    {
                        palavra += Char.ConvertFromUtf32(paa).ToLower();
                    }
                    else
                    {
                        palavra += Char.ConvertFromUtf32(paa).ToUpper();
                    }

                }

                txtBox2.Text = palavra;
                txtBox1.Text = "";

                palavra = "";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBox1.Text = "";
            txtBox2.Text = "";
        }

        private void btnDescript_Click(object sender, EventArgs e)
        {

            if(String.IsNullOrEmpty(txtBox2.Text)){
                MessageBox.Show("Você precisa colocar escrever algo!", "Aviso",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {

                for (int i = 0; i < txtBox2.Text.Length; i++)
                {
                    int pa = (int)txtBox2.Text[i];
                    int paa = pa - 10;

                    palavra2 += Char.ConvertFromUtf32(paa);
                }

                txtBox1.Text = palavra2;
                txtBox2.Text = "";

                palavra2 = "";
            }

        }
            
    }
}
