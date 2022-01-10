using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENTRADADADOWINDOWSFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = TXTNOME.Text;
            LBLMSG.Text = "MUITO PRAZER EM TE CONHECER, " + nome + "!" ;
            LBLMSG.Visible = true;
        }

        private void LBLMSG_Click(object sender, EventArgs e)
        {

        }
    }
}
