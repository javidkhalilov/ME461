using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace me461_2010_03_dynamic_object_creation
{
    public partial class Form1 : Form
    {
        
        int ArraySize = 4;
        const int clearence = 5;
        Random rnd;
        Button[,] MyButtons;

        public Form1()
        {
            InitializeComponent();
            rnd = new Random(DateTime.Now.Millisecond);
            CreateBoard(ArraySize);
        }

        /// <summary>
        /// This function creates the gameboard of size passed to it
        /// </summary>
        /// <param name="size_of_board">Size of game board to be created</param>

        private void CreateBoard(int size_of_board)
        { 
            //first create an array of size size_of_board by size_of_board
            
            Button[,] Mybuttons = new Button[size_of_board, size_of_board];
            //MyButtons is an array ready to contain
            //size_of_board by size_of_board number of Buttons
            Button b;
            int k = 0;
            for (int i=0; i < size_of_board; i++)

                for (int j=0; j < size_of_board; j++)
                {
                    //create a board of array size
                    k++;
                    b = new Button();
                    b.Width = 30;
                    b.Height = 30;
                    b.BackColor = Color.Yellow;
                    b.Visible = true;
                    b.Left = 50+i*(b.Width+clearence);
                    b.Top = 50 + j * (b.Height + clearence); ;
                    b.Text = k.ToString();
                    b.Tag = i.ToString() + "," + j.ToString();
                    b.Click += new EventHandler(btnArray_Click);
                    Mybuttons[i , j] = b;
                    this.Controls.Add(b);
                    //this refers to the runnig copy of the form
                }
            //this.Width = 250;
            //this.Height = 200;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
           Button b = (Button)sender;
           b.BackColor = GivemeRandomColor();

           
        }

        private Color GivemeRandomColor()
        { 
            Color c=Color.FromArgb(rnd.Next(256),rnd.Next(256),rnd.Next(256));
            return c;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        // split the text from tbox and list it if it is a number 
        private void btnParse_Click(object sender, EventArgs e)
        {
            
            string Maintext = textBox1.Text;
            string Currentext = "";
            string[] Subtext = Maintext.Split(',');//comma is the delimeter
            int num_number = 0;
            for (int i = 0; i < Subtext.Length; i++)
            {
                Currentext = Subtext[i];
                //if what you try does not hapen,you can catch it!
                try
                {
                    int res = Convert.ToInt16(Currentext);
                    listBox1.Items.Add(res.ToString());
                }
                catch
                {
                    num_number++;
                }
                //listBox1.Items.Add(Subtext[i]);
                
            }
            if (num_number > 0)
                MessageBox.Show("there are" + num_number.ToString() + "error");
        }
    }
}
