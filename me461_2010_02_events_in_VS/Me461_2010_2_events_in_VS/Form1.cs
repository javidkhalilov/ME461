using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Me461_2010_2_events_in_VS
{
    public partial class Form1 : Form
    {

        int i = 0;
        Random rnd;
        
        
        //the class constructor
        public Form1()
        {

            InitializeComponent();
            
            //you do your inits
            button2.Text = "0";

            //create the new random number generator object
            rnd = new Random();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string diffrentiating_text = b.Tag.ToString();

            switch (diffrentiating_text)
            { 
                case "inc1":
                    i++;
                    break;
                case "inc2":
                    i=i+2;
                    break;
                case "inc3":
                    i=i+3;
                    break;
            }

            //if (b.Text == "+2")
            //    i = i + 2;
            //else
            //    i++;//increment i
            button2.Text = i.ToString(); //display it
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            button2.Text = i.ToString();
        }

        private void btnChangeBackColour_Click(object sender, EventArgs e)
        {
            //this function randomly changes the back colour of itself
            //everytime the user clicks on it
            //rnd = new Random();
            int r, g, b;
            r = rnd.Next(256);
            g = rnd.Next(256);
            b = rnd.Next(256);
            
            btnChangeBackColour.BackColor = Color.FromArgb(r, g, b);
            
        }

      

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.Text = e.X.ToString() + "," + e.Y.ToString();
        }

    }
}
