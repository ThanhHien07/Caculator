using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btCong_Click(object sender, EventArgs e)
        {
            if (txtA.Text != String.Empty)
                if (txtA.Text != String.Empty && txtB.Text != String.Empty)
                {
                    int a = int.Parse(txtA.Text);
                    int b = int.Parse(txtB.Text);
                    Caculation c = new Caculation(a, b);
                    c.Execute("+");
                }
        }
        private void btTru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            Caculation c = new Caculation(a, b);
            c.Execute("-");
        }
    }
}
