﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace me461_2010_Classes101
{
    public partial class Form1 : Form
    {
        bugCircle c1, c2, c3;
        bugPoint p1, p2, p3;

        public Form1()
        {
            InitializeComponent();

            // create c1 by using the default constructor
            c1 = new bugCircle(); // unit cirlce
            c1.Radius = 10.0;
            c1.center.X = 5;
            c1.center.Y = 10;
            c1.name = " a cute circle ";
            
             

            // create c2 and c3 by using the overloaded constructor
            c2 = new bugCircle(-5.0, new Point(3, 3)); // another unit circle
            c3 = new bugCircle(3.0, new Point(5, 4)); // yet another one

            p1 = new bugPoint(); // locate at the origin
            p2 = new bugPoint(3F, 4F);
            p3 = new bugPoint(2F, 4F);
           
            bugPoint p4; // = p2.Add(p3);

            p4 = p2 + p3;
            
            this.Text = p4.ToString();
            this.Text += "dist " + p1.Distance2(p2).ToString();
            this.Text += "ang = " + p2.SlopeWChoice(bugPoint.AngleType.Degree).ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //this.Text = c1.Summary();
            //this.Text = c1.ToString();
        }
    }

    /// <summary>
    /// My way of implementing a 2D point
    /// </summary>
    public class bugPoint
    {

        public enum AngleType
        { 
            Radian = 0,
            Degree = 1
        }


        public PointF Location;

        public override string ToString()
        {
            return "Point @ " + this.Location.X.ToString() +
                "," + this.Location.Y.ToString() +
                " slope is " + this.SlopeAngle.ToString() +
                " length is " + this.Length.ToString() ;
        }

        /// <summary>
        /// default point contructor
        /// </summary>
        public bugPoint()
        { Location = new PointF(0F, 0F); }

        /// <summary>
        /// Overloaded constructor using a PointF object
        /// </summary>
        /// <param name="p">a PointF Object</param>        
        public bugPoint(PointF p)
        { this.Location = new PointF(p.X, p.Y);}

        /// <summary>
        /// Overloaded constructor using a bugPoint object
        /// </summary>
        /// <param name="p">a bugPoint Object</param>
        public bugPoint(bugPoint p)
        { Location = new PointF(p.Location.X, p.Location.Y); }

        /// <summary>
        /// Yet another overloaded constructor
        /// </summary>
        /// <param name="x">Location.x</param>
        /// <param name="y">Loacation.y</param>
        public bugPoint(float x, float y)
        { Location = new PointF(x, y);}

        /// <summary>
        /// Compute the distance between this point and point p
        /// </summary>
        /// <param name="p">distance to point p is to be computed</param>
        /// <returns>distance in float</returns>
        public float Distance2(bugPoint p)
        {
            return (float) Math.Sqrt(Math.Pow((double)(this.Location.X - p.Location.X), 2.0) 
                + Math.Pow((double)(this.Location.Y - p.Location.Y), 2.0));
        }

        /// <summary>
        /// Lenght of the vector defined in between this point and origin
        /// </summary>
        public float Length
        {
            get { return Distance2(new bugPoint(0F, 0F)); }
        }
        
        /// <summary>
        /// Add vector p to this one
        /// and return a new vector that represents the sum
        /// </summary>
        /// <param name="p">vector to add to this</param>
        /// <returns>resulting vector</returns>
        public bugPoint Add(bugPoint p)
        {
            return new bugPoint(this.Location.X + p.Location.X, 
                this.Location.Y + p.Location.Y);
        }

        /// <summary>
        /// Subtract vector p from this one
        /// </summary>
        /// <param name="p">vector to subtract</param>
        /// <returns>resulting vector</returns>
        public bugPoint Subtract(bugPoint p)
        {
            return new bugPoint(this.Location.X - p.Location.X, 
                this.Location.Y - p.Location.Y); // yet another stub            
        }

        /// <summary>
        /// Compute the dot prodct between this and vector p
        /// </summary>
        /// <param name="p">vector p</param>
        /// <returns></returns>
        public float DotProduct(bugPoint p)
        {
            return 0F;
        }

        /// <summary>
        /// Angle of the vector formed using origin and this point
        /// wrt to the X axis
        /// </summary>
        public float SlopeAngle
        {
            get { return (float)Math.Atan2(this.Location.Y, this.Location.X); }
        }

        public float SlopeWChoice(AngleType ang)
        {
            float f = this.SlopeAngle;
            if (ang == AngleType.Degree)
                f = f * 180F / (float)Math.PI;
            return f;
        }

        public static bugPoint operator +(bugPoint p1, bugPoint p2)
        { return new bugPoint(p1.Location.X + p2.Location.X, 
            p1.Location.Y + p2.Location.Y); }

        public static bugPoint operator -(bugPoint p1, bugPoint p2)
        { return new bugPoint(p1.Location.X - p2.Location.X, 
            p1.Location.Y - p2.Location.Y); }

        public static bool operator ==(bugPoint p1, bugPoint p2)
        {
            return (p1.Location.X == p2.Location.X && 
                p1.Location.Y == p2.Location.Y);
        }

        public static bool operator !=(bugPoint p1, bugPoint p2)
        { return !(p1.Location.X == p2.Location.X && 
            p1.Location.Y == p2.Location.Y); }

    }

    public class bugCircle
    {
        private double radius = 0.0; // a private variable accessible through a public property
        public Point center; // a public variable
        public string name;

        /// <summary>
        /// Property corresponding to the radius of the circle
        /// </summary>
        public double Radius
        {
            set 
            {
                if (value >= 0) this.radius = value;
                else this.radius = 0.0;
            }
            get { return this.radius; }
        }

        /*
        public void SetRaidus(double r)
        {
            if (r >= 0)
                this.radius = r;
            else
                this.radius = 0;
        }

        public double GetRadius()
        { return this.radius; }
        //*/
         
        /// <summary>
        /// The default contructor of the bugCircle class
        /// </summary>
        public bugCircle()
        { 
            // assume that the default circle is a unit cirlce
            radius = 1.0;
            center.X = 0; center.Y = 0;
            name = "default circle";
        }

        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="r">radius of the circle to be created</param>
        /// <param name="pcenter">center of the circle to be created</param>
        public bugCircle(double radius, Point pcenter)
        {
            this.Radius = radius;
            center.X = pcenter.X;
            center.Y = pcenter.Y;
            name = "overloaded circle";
        }

        /// <summary>
        ///  Area is a read - only property of the circle
        /// </summary>
        public double Area
        {
            get { return Math.PI * radius * radius; }
        }


        public double Perimeter
        {
            get { return 2 * Math.PI * radius; }
        }

        /// <summary>
        /// verbally express the content of the circle
        /// </summary>
        /// <returns>a string</returns>
        public override string ToString()
        {
            string str = "";
            str = "I am " + name + " located at " + this.center.X.ToString() +
                "," + this.center.Y.ToString() + " and my radius is " +
                this.radius.ToString() + " my area is " +
                this.Area.ToString() + " my perimeter is " +
                this.Perimeter.ToString();
            return str;
        }



    }
    
}
