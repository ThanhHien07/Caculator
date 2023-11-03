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
<<<<<<< HEAD
            if (txtA.Text != String.Empty)
=======
            if(txtA.Text!=String.Empty && txtB.Text!=String.Empty)
>>>>>>> feature-ca
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = a + b;
                txtKQ.Text = c.ToString();
            }
<<<<<<< HEAD
=======
            

>>>>>>> feature-ca
        }
        
   

        private void btTru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = a - b;
            txtKQ.Text = c.ToString();

        }
    }
}
