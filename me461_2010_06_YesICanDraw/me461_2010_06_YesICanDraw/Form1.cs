using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace me461_2010_06_YesICanDraw
{
    public partial class Form1 : Form
    {
        List<Point> mypoints;

        Bitmap mybmp;
        Graphics myg;
        Point ptCurrent;

        public Form1()
        {
            InitializeComponent();
            // my inits
            ptCurrent = new Point();
            mypoints = new List<Point>();
            resetBMP();
        }

        void resetBMP()
        {
            mybmp = new Bitmap(pBox.Width, pBox.Height);// create a bitmap of the same size with a picturebox tha will be displayed
            myg = Graphics.FromImage(mybmp);//get a graphics reference 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDrawLine_Click(object sender, EventArgs e)
        {
            //manually enforce the paint event
            this.Invalidate();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //this is where things are drawn on the form
            
            Graphics g = e.Graphics;
            int x1=0, y1=0, x2=0, y2=0;
            try
            {
                /*
                x1 = Convert.ToInt16(txtBoxXLine1.Text);
                x2 = Convert.ToInt16(txtBoxXLine2.Text);
                y1 = Convert.ToInt16(txtBoxYLine1.Text);
                y2 = Convert.ToInt16(txtBoxYLine2.Text);
                */
                //now i should have required coordinates to draw a line

                Pen p = new Pen(Color.LimeGreen,5f);
                //ready to draw :)
                //draw by providing coordinates explicitly
                //g.DrawLine(p, x1, y1, x2, y2);
                //g.DrawEllipse(p, x1, y1, x2, y2);
                //g.DrawRectangle(p, x1, y1, x2, y2);
                /*
                Point p1 = new Point(x1, y1);
                Point p2 = new Point(x2, y2);
                Point po = new Point(0, 0);
                Point pmax = new Point(this.Width, this.Height);
                */
                //List<Point> mypoints = new List<Point>();
                //mypoints.Add(po);
                //mypoints.Add(p1);
                //mypoints.Add(p2);
                //mypoints.Add(pmax);

                //g.DrawLine(p, po, p1);
                //g.DrawLine(p, p1, p2);
                //g.DrawLine(p, p2, pmax);

                //draw all lines at the same line

                g.DrawLines(p, mypoints.ToArray());

                //draw a circle at the beginning and the end of each line
                Pen pcircle = new Pen(Color.Purple);
                foreach (Point pt in mypoints)
                {
                    int D = 20;
                    //g.DrawEllipse(pcircle, pt.X-D/2, pt.Y-D/2, D, D);
                    g.FillEllipse(Brushes.Red, pt.X - D / 2, pt.Y - D / 2, D, D);
                }


            }
            catch
            { 
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x, y;
                x = Convert.ToInt16(textBox1.Text);
                y = Convert.ToInt16(textBox2.Text);
                AddPoint(x,y);
            }
            catch
            { 
            
            }
        
            }
        void AddPoint(int x,int y)
        {
        
                Point p = new Point(x, y);
                mypoints.Add(p);
                listBox1.Items.Add(x.ToString() + ";" + y.ToString());
                this.Invalidate();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index2remove = listBox1.SelectedIndex;
            if (index2remove < 0) return;//if nothing is selected,get out

            listBox1.Items.RemoveAt(index2remove);
            mypoints.RemoveAt(index2remove);
            this.Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                AddPoint(e.X, e.Y);
            }
        }

        private void btnCLS_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            mypoints.Clear();
            this.Invalidate();
        }

        private void btnPaintOnBmp_Click(object sender, EventArgs e)
        {
            Pen p1 = new Pen(Color.Plum, 4f);
            Pen p2 = new Pen(Color.PeachPuff, 7f);
            //change the background of picturebox
            myg.FillRectangle(p2.Brush, 0, 0, mybmp.Width, mybmp.Height);
                
            
            
            //draw a cross
            myg.DrawLine(p1, 0, 0, mybmp.Width, mybmp.Height);
            myg.DrawLine(p1, mybmp.Width, 0, 0, mybmp.Height);

            //now the bitmap has a cross on it!
            //problem is,do you see it on a screen?
            //no you don't
            pBox.Image = (Image)mybmp;

        }

        private void pBox_MouseMove(object sender, MouseEventArgs e)
        {
            Pen p1 = new Pen(Color.Plum, 4f);
            Pen p2 = new Pen(Color.PeachPuff, 4f);
            Pen pcurrent=p1;
            int d=10;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                pcurrent = p1;//drawing

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                pcurrent = p2;//erasing
            if (e.Button == System.Windows.Forms.MouseButtons.Left || e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                myg.FillEllipse(pcurrent.Brush, e.X - d / 2, e.Y - d / 2, d, d);
                //myg.DrawEllipse(Pens.Red, e.X - d / 2, e.Y - d / 2, d, d);
                //myg.DrawEllipse(Pens.PeachPuff, e.X - d / 2, e.Y - d / 2, d, d);
                pBox.Image = (Image)mybmp;
            }
           
        }

        private void pBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pBox_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void pBox_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }
    }
}
