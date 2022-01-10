using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STRNGINTERPOLADASEMWNDOWSFORMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTMOK_Click(object sender, EventArgs e)
        {
          LBLMSG.Text =$"O ANO ATUAL E {DateTime.Now.Year}!!!";
        }
    }
}
