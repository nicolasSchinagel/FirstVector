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
    public partial class FormRandom : Form
    {
        public FormRandom()
        {
            InitializeComponent();
        }

        private void FormRandom_Load(object sender, EventArgs e)
        {

        }

        private void btngerar_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int[] vetorpar = new int[15];
            int i;
            for (i = 0; i < 15; i++)
            {
                vetorpar[i] = num.Next(1, 100);
            }
            for (i = 0; i < 15; i++)
            {
                if (vetorpar[i] % 2 == 0)
                {
                    txtrandom.Text += vetorpar.ToString();
                }
            }
        }
    }
}
