using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistCompTestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDistance_Click(object sender, EventArgs e)
        {
           
            string[] results = distComp.CalculateDistanceAndTime(txtStn1.Text, txtStn2.Text);

            txtRes.Text = results[0];
            txtTime.Text = results[1];
            txtChange.Text = results[2];
        }
    }
}
