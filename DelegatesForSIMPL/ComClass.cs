
using System;
using System.Text;
using Crestron.SimplSharp;                          				// For Basic SIMPL# Classes

namespace DelegatesForSIMPL
{
    public class ComClass
    {



        public delegate void myDelegate(ushort data, SimplSharpString txt);
        public myDelegate myEvent { get; set; }




        static private Random i = new Random();
      
     

        public void func1()
        {
            

            ushort myInt;
   

            myInt = (UInt16)i.Next(1, 32000);
            myEvent(Convert.ToUInt16(myInt), "The number is " + Convert.ToString(myInt));
        }
    }
}

