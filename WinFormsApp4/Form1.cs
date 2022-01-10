using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(CAIXA.Text);
            int d = n * 2;
            FRASE2.Text = " o DOBRO DE " + n + " E " + d;
            FRASE2.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OK2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(CAIXA.Text);
            int d = n * 3;
            FRASE2.Text = " o TRIPLO DE " + n + " E " + d;
            FRASE2.Visible = true;
        }
    }
}
