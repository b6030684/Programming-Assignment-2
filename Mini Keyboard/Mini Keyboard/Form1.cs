using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Keyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void Mode_button_Click(object sender, EventArgs e)
        {
            if (button_status.Text == "Multi-press")
            {
                button_status.Text = "Predictive";
            }
            else
            {
                button_status.Text = "Multi-press";
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
         
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if(button_2
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
