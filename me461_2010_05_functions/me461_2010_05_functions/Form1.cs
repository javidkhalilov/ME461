using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace me461_2010_05_functions
{
    public partial class Form1 : Form
    {
        #region Event Handlers //these are the system events handled
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            //I want to swap the content of txtBoxA and txtBoxB
            int x=0,y=0;
            try
            {
                x=Convert.ToInt16(txtBoxa.Text);
                y=Convert.ToInt16(txtBoxB.Text);
                //now i have two integers read into int type variables
                swap(ref x,ref y);// hope for the best,now x==y and y==x
                txtBoxa.Text = x.ToString();
                txtBoxB.Text = y.ToString();

            }
            catch
            {
                MessageBox.Show("you can only swap only itegers");
            }
        }

        private void btnSwap2_Click(object sender, EventArgs e)
        {
            SwapButtonBackColors(ref btnSwap1, ref btnSwap2);
        }

        private void btnStupidAdd_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            try
            {
                x = Convert.ToInt16(txtBoxa.Text);
                y = Convert.ToInt16(txtBoxB.Text);
                //now i have two integers read into int type variables
                // i simply add them
                this.Text = add(x, y).ToString();

            }
            catch
            {
                MessageBox.Show("you can only swap only itegers");
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double meanval = 0;
            int mymin = 0, mymax = 0;
            List<int> myintvals = new List<int>();
            // read integers from the listbox into this list objec myintvals
            int problem_counter = 0;
            int tempi = 0;

            foreach (object o in listBox1.Items)
            {
                try
                {
                    tempi = Convert.ToInt16(o);
                    myintvals.Add(tempi);
                }
                catch(Exception mybeautifulException2Handle)
                {
                    problem_counter++;
                    // remember messageboxes in loops is BAD!
                    //MessageBox.Show(mybeautifulException2Handle.Message, "oops");
                    System.Diagnostics.Debug.WriteLine(o.ToString() + "has the problem\n" + mybeautifulException2Handle);
                }
            }

            //pass the variables to the stats function

           if( stats(myintvals.ToArray(), ref meanval, ref mymin, ref mymax))
            //stats(null, ref meanval, ref mymin, ref mymax);
            //display the results

            this.Text = "Mean=" + meanval.ToString() + "min=" + mymin.ToString() + "max=" + mymax.ToString();
            else
            this.Text="stats did not compute the values";
        }
        
        #endregion
        
        #region My functions // stuff I wrote
        //stupid add function

        int add(int a, int b) { return a + b; }

        bool stats(int[] myarr,ref double mean,ref int minval,ref int maxval)
        {
            if (myarr == null || myarr.Length==0) return false;
            mean = 0;
            minval = myarr[0];
            maxval = myarr[0];

            foreach (int i in myarr)
            {
                mean += i;
                if (i < minval) minval = i;
                if (i > maxval) maxval = i;
            }

            mean /= myarr.Length;
            return true;
        }
        
        void swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        void SwapButtonBackColors(ref Button b1, ref Button b2)
        {
            Color c = b1.BackColor;
            b1.BackColor = b2.BackColor;
            b2.BackColor = c;
        }
        
        //compute n!
        int Factorial_classical(int n)
        {
            
            if (n>=0 && n< 2) return 1;
            if (n < 0) return -1;
            int rm = 1;
           
            for (int i = 1; i <= n; i++)
                rm *= i;
            return rm;
        }

        int Factorial(int n)
        {
            if (n < 2) return 1;
            else
                return n * Factorial(n - 1);
        }

        #endregion

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            //display factorial of n from the numerical updown on the title
            this.Text =numericUpDown1.Value.ToString()+"!"+ Factorial((int)numericUpDown1.Value).ToString();
        }

        

        

     
    }
}
