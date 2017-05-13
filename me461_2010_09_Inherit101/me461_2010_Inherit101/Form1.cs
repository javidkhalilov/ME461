using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace me461_2010_Inherit101
{
    public partial class Form1 : Form
    {
        Vehicle v1,v2;
        SportsBike sbike1,sbike2;
        SuperSport ss1;

        Vehicle Current_vehicle;

        ICanWriteInterface iYesCan;

        public Form1()
        {
            InitializeComponent();

            //my stuff is beyond this point
            v1 = new Vehicle();
            v2 = new Vehicle(70, 50);
            

            sbike1 = new SportsBike();
            sbike2 = new SportsBike(70, 204);

            ss1 = new SuperSport();

            Current_vehicle = ss1;

            //SuperSport current_ss = (SuperSport)Current_vehicle;

            

            Current_vehicle.Ooops += new Vehicle.Overspeed(Current_vehicle_Ooops);
           // Current_vehicle.Ooops+=new Vehicle.Overspeed(DudeSlowDown);

            rtBox.Text = v1.ToString();
            //rtBox.Text += "\n" + v2.ToString();
            rtBox.Text += "\n" + sbike1.ToString();
            //rtBox.Text += "\n" + sbike2.ToString();
            rtBox.Text += "\n" + ss1.ToString();

            //messing with interface
            //iYesCan= new what ever is Not Valid!!!;
            iYesCan = (ICanWriteInterface) sbike1;

            
            //just to show that we can question whether an object 
            //supports an interface,we will create a list of vehicles
            //

            Tricycle t1 = new Tricycle();

            List<Vehicle> myV = new List<Vehicle>();
            myV.Add(v1);
            myV.Add(v2);
            myV.Add(sbike1);
            myV.Add(sbike2);
            myV.Add(ss1);
            myV.Add(t1);

            foreach (Vehicle v in myV)
            {
                //if vehicle referred to with 'v' supports ICanWriteInterface
                //then i will call some functions over v

                iYesCan = v as ICanWriteInterface;
                if(iYesCan !=null)
                    Debug.WriteLine("i am a sportsbike have " + iYesCan.NumberofWheels.ToString() +
                " wheels and i am stable " +
                    (iYesCan.RUStable() ? "yes" : "no"));
                

                
                
                /*//try catch version
                try
                {
                    iYesCan = (ICanWriteInterface)v;
                    Debug.WriteLine("i am a sportsbike have " + iYesCan.NumberofWheels.ToString() +
               " wheels and i am stable " +
               (iYesCan.RUStable() ? "yes" : "no"));
                }

                catch
                {
                    Debug.WriteLine("oops");
                }
                */
            }


            /*
            Debug.WriteLine("i am a sportsbike have " + iYesCan.NumberofWheels.ToString() +
                " wheels and i am stable " + 
                (iYesCan.RUStable() ? "yes":"no"));
            
            Tricycle t1 = new Tricycle();
            iYesCan = (ICanWriteInterface)t1;

            Debug.WriteLine("i am a tricycle having " + iYesCan.NumberofWheels.ToString() +
                " wheels and i am stable " +
                (iYesCan.RUStable() ? "yes" : "no"));
             //*/
               

        }

        //void DudeSlowDown(int howfastamI)
        //{
        //    MessageBox.Show("you are too fast,slow down");
        //}


        void Current_vehicle_Ooops(int OverLimitBy)
        {
            this.Text = "\n" + "Over the speed limit by " + 
                OverLimitBy.ToString() + "km/hr";
        }

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            rtBox.Text+="\n"+"Current vehicle goes at "+
            Current_vehicle.Accelerate((int)numericUpDown1.Value).ToString()+"km/hr";
        }
    }

    public interface ICanWriteInterface
    { 
        //methods
        bool CanYouSwim();
        bool RUStable();

        //properties as well
        int NumberofWheels { get; }
    }




    /// <summary>
    /// this is a motorized vehicle in general
    /// </summary>
    public class Vehicle
    { 
        protected int max_allowable_speed;//in km/hr
        public int power;
        protected int speed = 0;


        public delegate void Overspeed(int OverLimitBy);
        public event Overspeed Ooops;
       


        //default constructor
        public Vehicle() 
        {
            speed = 0;
            max_allowable_speed = 90; power = 100;
            Debug.WriteLine("Default vehicle is created");
        }

        //an overloaded constructor
        public Vehicle(int maxspd, int pwr)
        {
            speed = 0;
            max_allowable_speed = maxspd;
            power = pwr;
            Debug.WriteLine("overloaded vehicle is created");
        }

        public virtual int Accelerate(int acc)
        {
            speed += acc;
            if (speed > max_allowable_speed && Ooops!=null) 
                Ooops(speed - max_allowable_speed);
            return speed;
        }


        public override string ToString()
        {
            return " with "+power.ToString()+
                " hp I am allowed to go " +max_allowable_speed.ToString()+" km/hr";
        }

    }

    public class SportsBike : Vehicle,ICanWriteInterface
    {

        public int RedLine;//rpm

        //default constructor
        public SportsBike() :base(70,60)
        {
            RedLine = 13000;
            Debug.WriteLine("a sportsbike is born by default");
        }

        public SportsBike(int maxspd, int pwr)
            : base(maxspd, pwr)
        {
            RedLine = 13000;
            Debug.WriteLine("a sportsbike is over born");
        }

        public override int Accelerate(int acc)
        {
            base.Accelerate(acc);
            if (speed < 0) speed = 0;
            return speed;
        }
        
        public override string ToString()
        {
            return "As a sportsbike"+base.ToString();
        }

        //interface implement implicitly
        public bool CanYouSwim()
        {
            return false;
        }

        //interface implemented explicitly
        
        bool ICanWriteInterface.RUStable()
        {
            return false;
        }

        int ICanWriteInterface.NumberofWheels
        {
            get { return 2 ; }
        }
    }

    public class SuperSport : SportsBike
    { 
    
    }

    public class Tricycle : SportsBike,ICanWriteInterface
    {
        //CanYouSwim is not implmented at all
        //
        
        //interface implemented explicitly

        bool ICanWriteInterface.RUStable()
        {
            return true;
        }

        int ICanWriteInterface.NumberofWheels
        {
            get { return 3; }
        }
    }
}
