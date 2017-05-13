// Things specific to MechaBoard are defined here
// You are free to change it to suit your convenience
// these settings are for Mechaboard 4.0


// define buttons
#define SW1 PIN_B4
#define SW2 PIN_B5
#define Dip1 PIN_D2
#define Dip2 PIN_D3


// define user friendly LEDs
#define Led1 PIN_D4
#define Led2 PIN_D5
#define Led3 PIN_D6
#define Led4 PIN_D7


// define Analog Input channels
#define POT 0
//#define AN0
#define AN1 1
#define AN2 2
#define AN3 3
#define AN4 4
#define AN5 5


// Define constants related to DC Motor Driver Card
#define Motor1 PIN_C2
#define Motor2 PIN_C1

#define Motor1Dir1 PIN_D0
#define Motor1Dir2 PIN_D1

#define Motor2Dir1 PIN_C0
#define Motor2Dir2 PIN_E2

#define Motor1Current PIN_E0
#define Motor2Current PIN_E1

#define EnableMotor output_high
#define DisableMotor output_low


// Custom functions to be included in the library

//Sets the state of the LEDs on B5, B3, B2, B1 based on the LS nibble on the passed value
// Among the LEDs, B5 is the LS, B1 is the MS bit
void SetLeds(int8 val)
{
   // expect the lower nibble of val to contain LED state bits
   #bit L1 = val.0
   #bit L2 = val.1
   #bit L3 = val.2
   #bit L4 = val.3

   output_bit(Led1, L1);
   output_bit(Led2, L2);
   output_bit(Led3, L3);
   output_bit(Led4, L4);
   return;
}

// this function takes an 8 bit integer and displays the result on 
// the 4 leds to divide the 0-255 interval into 5 different range
void VuMeter(int8 val)
{
   if(val > 204) { SetLeds(15); return;}
   if(val > 153) { SetLeds(7); return; }
   if(val > 102) { SetLeds(3); return; }
   if(val > 51)    SetLeds(1);
   else SetLeds(0);
   return;   
}

void Walker(int8 times = 1)
{
   int8 i, j;
   int8 valz[] = {0, 1, 3, 7, 15, 7, 3, 1, 0};
   //int8 valz[] = {0, 1, 2, 4, 8, 15, 8, 4, 2, 1, 0};
   const int wait4 = 100;
   
   for(i=0; i<times; i++)
   {
      for(j=0; j<9; j++)
      {
         SetLeds(valz[j]);
         delay_ms(wait4);
      }
   }
}
