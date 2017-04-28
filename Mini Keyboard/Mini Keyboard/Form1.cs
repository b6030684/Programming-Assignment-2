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
    public partial class Mini_Keyboard : Form
    {

        bool firstclick = true;
        int Numberofclicks = -1;




        public Mini_Keyboard()
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
                for (int i = 0; i < listBox_1.Items.Count; i++)
                {
                    listBox_global.Items.Add(listBox_1.Items[i].ToString());

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
            {
                timer.Stop();
                if (firstclick == true)
                {
                    listBox_global.Items.Clear();
                    for (int i = 0; i < listBox_7.Items.Count; i++)
                    {
                        listBox_global.Items.Add(listBox_7.Items[i].ToString());

                    }
                    firstclick = false;

                }

                Numberofclicks++;

                timer.Enabled = true;

            }

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
            Notepad.AppendText(Environment.NewLine);
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
            {
                timer.Stop();
                if (firstclick == true)
                {
                    listBox_global.Items.Clear();
                    for (int i = 0; i < listBox_4.Items.Count; i++)
                    {
                        listBox_global.Items.Add(listBox_4.Items[i].ToString());

                    }
                    firstclick = false;

                }

                Numberofclicks++;

                timer.Enabled = true;

            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            {
                timer.Stop();
                if (firstclick == true)
                {
                    listBox_global.Items.Clear();
                    for (int i = 0; i < listBox_5.Items.Count; i++)
                    {
                        listBox_global.Items.Add(listBox_5.Items[i].ToString());

                    }
                    firstclick = false;

                }

                Numberofclicks++;

                timer.Enabled = true;

            }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            {
                timer.Stop();
                if (firstclick == true)
                {
                    listBox_global.Items.Clear();
                    for (int i = 0; i < listBox_6.Items.Count; i++)
                    {
                        listBox_global.Items.Add(listBox_6.Items[i].ToString());

                    }
                    firstclick = false;

                }

                Numberofclicks++;

                timer.Enabled = true;

            }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            {
                timer.Stop();
                if (firstclick == true)
                {
                    listBox_global.Items.Clear();
                    for (int i = 0; i < listBox_8.Items.Count; i++)
                    {
                        listBox_global.Items.Add(listBox_8.Items[i].ToString());

                    }
                    firstclick = false;

                }

                Numberofclicks++;

                timer.Enabled = true;

            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            {
                timer.Stop();
                if (firstclick == true)
                {
                    listBox_global.Items.Clear();
                    for (int i = 0; i < listBox_9.Items.Count; i++)
                    {
                        listBox_global.Items.Add(listBox_9.Items[i].ToString());

                    }
                    firstclick = false;

                }

                Numberofclicks++;

                timer.Enabled = true;

            }
        }

        private void button_star_Click(object sender, EventArgs e)
        {
            {
                timer.Stop();
                if (firstclick == true)
                {
                    listBox_global.Items.Clear();
                    for (int i = 0; i < listBox_11.Items.Count; i++)
                    {
                        listBox_global.Items.Add(listBox_11.Items[i].ToString());

                    }
                    firstclick = false;

                }

                Numberofclicks++;

                timer.Enabled = true;

            }
        }

        private void button_hashtag_Click(object sender, EventArgs e)
        {
            {
                timer.Stop();
                if (firstclick == true)
                {
                    listBox_global.Items.Clear();
                    for (int i = 0; i < listBox_10.Items.Count; i++)
                    {
                        listBox_global.Items.Add(listBox_10.Items[i].ToString());

                    }
                    firstclick = false;

                }

                Numberofclicks++;

                timer.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Letter_builder_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_0_Click(object sender, EventArgs e)
        {
            Notepad.AppendText( Letter_builder.Text + " ");
            Letter_builder.Text = "";
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}