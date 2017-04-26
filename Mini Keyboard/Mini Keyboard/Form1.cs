using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDialogs; 


namespace Mini_Keyboard
{
    public partial class Form1 : Form
    {

        bool firstclick = true;
        int Numberofclicks = -1;




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
         if (firstclick == true)
         {
             listBox_global.Items.Clear();

             listBox_global.Items.AddRange(listBox_7.Items);
         }
         Letter_builder.Enabled = false;
         Numberofclicks++;

         Letter_builder.Enabled = true;
           
        }

        private void button_2_Click(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_7_Click(object sender, EventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
