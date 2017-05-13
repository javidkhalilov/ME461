using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace me461_2010_04_more_on_toolbox_objects
{
    public partial class Form1 : Form
    {
        int pval = 0;
        List<int> myints; //declared a list variable(i.e. object)

        public Form1()
        {
            InitializeComponent();
            myints = new List<int>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pctBox1.Image = imageList1.Images[listBox1.SelectedIndex];
        }

        private void btnChangeBackColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            this.BackColor = colorDialog1.Color;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
           
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.Text = hScrollBar1.Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pval++;
            progressBar1.Value = pval;
            if (pval == 100) pval = 0;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            myints.Add((int)numericUpDown1.Value);
            this.Text="";
            listBox2.Items.Clear();


            foreach (int currentvalue in myints)
            {
                this.Text += currentvalue.ToString() + ",";
                listBox2.Items.Add(currentvalue);
            }
            //for (int i = 0; i < myints.Count; i++)
            //    this.Text += myints[i].ToString() + ",";
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            myints.RemoveAt(listBox2.SelectedIndex);
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            this.Text = "";
            foreach (int currentvalue in myints)
                this.Text += currentvalue.ToString() + ",";
        }
    }
}
