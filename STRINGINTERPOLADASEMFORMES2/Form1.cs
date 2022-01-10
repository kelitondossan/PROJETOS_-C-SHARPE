using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STRINGINTERPOLADASEMFORMES2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            float sal = 0;
            float.TryParse(Console.ReadLine(), out sal);
            frase.Text = $"Você ganha {sal:c} por mês!";
        }
    }
}
