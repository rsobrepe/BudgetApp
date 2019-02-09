using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DesktopApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        //Calculates Revenue Inputted by User
        private void btnRev_Click(object sender, EventArgs e)
        {          
            int res = ((Int32.Parse(txtTL.Text))*15) + ((Int32.Parse(txtNorm.Text))*14);

            lblRev.Text = "$"+res.ToString()+".00";

        }

        //Calculates Expenses Inputted By User
        private void btnExp_Click(object sender, EventArgs e)
        {

        }
    }
}
