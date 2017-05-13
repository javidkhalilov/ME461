using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace me461_2010_UserControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            myColorfulStupidSquareButton1.myneighbours.Add(myColorfulStupidSquareButton2);
            //myColorfulStupidSquareButton2.myneighbours.Add(myColorfulStupidSquareButton1);
            //myColorfulStupidSquareButton2.myneighbours.Add(myColorfulStupidSquareButton3);
            //myColorfulStupidSquareButton3.myneighbours.Add(myColorfulStupidSquareButton2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
