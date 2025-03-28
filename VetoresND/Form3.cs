using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetoresND
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }
        int indexado = 0;
        int[] notaAluno = new int[30];
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btngerar_Click(object sender, EventArgs e)
        {
            int i, valorsoma, quantidade;
            valorsoma = 0;
            quantidade = 0;
            for (i = 0; i < 30; i++)
            {
                valorsoma = valorsoma + notaAluno[i];
                quantidade = quantidade + 1;
            }
            txtmedia.Text = (valorsoma / quantidade).ToString();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            notaAluno[indexado] = Convert.ToInt32(txtgrade.Text);
            if ( indexado >= 29)
            {
                lblpermissao.Text = "Todos já foram cadastrados";
            }
            txtgrade.Clear();
            indexado++;
        }
    }
}
