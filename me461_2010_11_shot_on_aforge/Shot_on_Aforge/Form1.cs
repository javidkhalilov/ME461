using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Shot_on_Aforge
{
    public partial class Form1 : Form
    {

        string Filename;
        Bitmap OriginalBmp,grayBmp,EdgeBmp,BinBmp,BlobBmp;
        int Threshold; //threshold value of binary filter
        Blob[] BlobArray = new Blob[10];
        Boolean GrayIsOn,EdgeBmpIsOn;


        static FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        static VideoCaptureDevice videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);

        Bitmap Video,VideoClone;

        //filters
        GrayscaleBT709 grayFilter = new GrayscaleBT709(); //Grayscale filter
        SobelEdgeDetector Sobeledgededector = new SobelEdgeDetector();//sobel edge dedector
        Threshold BinFilter = new Threshold(); //binary filter
        BlobsFiltering BlobFilter = new BlobsFiltering();//blob filter
        BlobCounter BlobCountFilter = new BlobCounter(); //blob counter
        HoughCircleTransformation circleTransform = new HoughCircleTransformation(100);

        public Form1()
        {
            
            
            InitializeComponent();
        }

        void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Video = (Bitmap)eventArgs.Frame.Clone();
            VideoClone = (Bitmap)Video.Clone();
            original.Image = Video;
            
            if (GrayIsOn)
            {
                grayBmp = grayFilter.Apply(VideoClone);
                process.Image = grayBmp;  
            }

            if (EdgeBmpIsOn)
            {
                grayBmp = grayFilter.Apply(VideoClone);
                EdgeBmp = Sobeledgededector.Apply(grayBmp);
                process.Image = EdgeBmp;
            }
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); //shows the file dialog
            Filename = openFileDialog1.FileName; //get the filename
            OriginalBmp = new Bitmap(Filename);
            original.Image = OriginalBmp;

            this.Text = Filename;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grayBmp = grayFilter.Apply(OriginalBmp);
            process.Image = grayBmp;//set the picturebox
            GrayIsOn = true;
            //grayBmp = grayFilter.Apply(Video);
            //process.Image = grayBmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //EdgeBmp = Sobeledgededector.Apply(grayBmp); //apply the edge dedector to the gray image
            //process.Image = EdgeBmp; //set the pictureboc image to the edge bitmap
            EdgeBmpIsOn = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text,out Threshold);
            BinFilter.ThresholdValue = Threshold;
            BinBmp = BinFilter.Apply(grayBmp);
            process.Image = BinBmp;
            this.Text = Threshold.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BlobFilter.MaxHeight = Convert.ToInt16( textBox2.Text.ToString());
            BlobFilter.MinHeight = Convert.ToInt16(textBox3.Text.ToString());
            BlobFilter.MaxWidth = Convert.ToInt16( textBox4.Text.ToString());
            BlobFilter.MinWidth = Convert.ToInt16(textBox5.Text.ToString());
            
            BlobBmp = BlobFilter.Apply(BinBmp);
            BlobCountFilter.ProcessImage(BlobBmp);
            BlobArray = BlobCountFilter.GetObjects(BlobBmp, true); //apply blob counting 

            process.Image = BlobBmp;
            this.Text += ";" + BlobBmp.Width.ToString();
            //this.Text = BlobArray[0].Area.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            videoSource.DesiredFrameSize = new Size(320, 40);
            videoSource.Start();
            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            circleTransform.ProcessImage(grayBmp);
            Bitmap houghCircleTransform = circleTransform.ToBitmap();
            process.Image = houghCircleTransform;
        } 
    }
}
