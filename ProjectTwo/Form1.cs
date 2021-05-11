using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string order = "";
            if(mainCourse.SelectedIndex > -1)
            {
                order = order + mainCourse.SelectedItem+", Salad with";
                if (ranch.Checked)
                {
                    order = order + " Ranch, ";
                }
                else if (appleVinegrette.Checked)
                {
                    order = order + " Apple Vinegrette, ";
                }
                else if (blueCheese.Checked)
                {
                    order = order + " Blue Cheese, ";
                }
                if (croutons.Checked)
                {
                    order = order + " add Croutons";
                }
                if (bacon.Checked)
                {
                    order = order + " add Bacon";
                }
                if (pecans.Checked)
                {
                    order = order + " add Glazed pecans";
                }
                if (cranberries.Checked)
                {
                    order = order + " add Cranberries";
                }

                if (pepitas.Checked)
                {
                    order = order + " add Pepitas";
                }
            }
            composed.Items.Add(order);

        }

        private void remove_Click(object sender, EventArgs e)
        {
            if(composed.SelectedIndex > -1)
            {
                composed.Items.RemoveAt(composed.SelectedIndex);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
