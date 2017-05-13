using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace me461_2010_01_hello_world
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // my stuff always goes after here if i want to run it at the beginning of the program
            SayHello();
            //System.IO.Ports.SerialPort
            label2.Text = "any text i want";
            label1.ForeColor = Color.Lime;

            //in a loop write numbers from 1 ton 9 to label1
            //and within the same loop write even numbers in this range to label

            // always init things that you will use!
            label2.Text = "";
            label1.Text = "";


            for (int i = 1; i <= 9; i++)
            {
                //label1.Text=label1.Text+i.ToString();
                label1.Text += i.ToString()+" ,";//same as above
                //if i is even add it to label2 as well
                if(i%2==0) label2.Text += i.ToString()+" ,";

            }
        }


        int sum(int a, int b)
        {
            return a + b;
        }

        void SayHello()
        {
            System.Diagnostics.Debug.WriteLine("hello world");
            Debug.WriteLine("here we go again");
        }

    }
}


