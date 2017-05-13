using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace me461_2010_UserControl
{
    public partial class MyColorfulStupidSquareButton : UserControl
    {
        Random r;
        public List<MyColorfulStupidSquareButton> myneighbours;


        public MyColorfulStupidSquareButton()
        {
            InitializeComponent();
            r = new Random(DateTime.Now.Millisecond);
            myneighbours=new List<MyColorfulStupidSquareButton>();
        }

        private void MyColorfulStupidSquareButton_Resize(object sender, EventArgs e)
        {
            this.Width = this.Height;
        }

        private void MyColorfulStupidSquareButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.Randombackcolor();
        }

        private void MyColorfulStupidSquareButton_Load(object sender, EventArgs e)
        {
            this.Width = this.Height;
        }

        public void ChangeBackColor(Color clr)
        {
            this.BackColor = clr;
        }

        public void Randombackcolor()
        {
            this.BackColor = Color.FromArgb(
                r.Next(0, 255),
                r.Next(0, 255),
                r.Next(0, 255));     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (MyColorfulStupidSquareButton btn in myneighbours)
            {
              Randombackcolor();
            }
       }
    }
}
