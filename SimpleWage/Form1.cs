using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your calculation is complete.");
            float calc = float.Parse(wage.Text) * float.Parse(hours.Text);
            label4.Text = ""+calc;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
