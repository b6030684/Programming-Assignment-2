﻿using System;
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
            timer.Stop();
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void Mode_button_Click(object sender, EventArgs e)
        { //if the text in the status button = multi-press then 
          //when the button is clicked the text will change to predictive.
            //if not then the text will change to multi-press
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
            timer.Stop();
         if (firstclick == true)
         {
             listBox_global.Items.Clear();
             for (int i = 0; i < listBox_1.Items.Count; i++ )
             {
                  listBox_global.Items.Add (listBox_1.Items [i].ToString());
                 
             }
             firstclick = false;
                 
         }
         
         Numberofclicks++;
            
         timer.Enabled = true;
           
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (firstclick == true)
            {
                listBox_global.Items.Clear();
                for (int i = 0; i < listBox_2.Items.Count; i++)
                {
                    listBox_global.Items.Add(listBox_2.Items[i].ToString());

                }
                firstclick = false;

            }

            Numberofclicks++;

            timer.Enabled = true;

        }
            
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_7_Click(object sender, EventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Letter_builder.AppendText(listBox_global.Items[Numberofclicks].ToString());
            timer.Stop();
            firstclick = true;
            Numberofclicks = -1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Enter_key_Click(object sender, EventArgs e)
        {

        }

        private void button_3_Click(object sender, EventArgs e)
        {
            {
                timer.Stop();
                if (firstclick == true)
                {
                    listBox_global.Items.Clear();
                    for (int i = 0; i < listBox_3.Items.Count; i++)
                    {
                        listBox_global.Items.Add(listBox_3.Items[i].ToString());

                    }
                    firstclick = false;

                }

                Numberofclicks++;

                timer.Enabled = true;

            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {

        }
    }
}
