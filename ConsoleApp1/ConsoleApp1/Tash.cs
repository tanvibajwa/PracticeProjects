using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tash
    {
        public string[] pattay;   
        public string[] pattay2;

        public static string[] buniyadi_pattay = new string[] {
            "H2", "H3", "H4", "H5", "H6", "H7", "H8", "H9",
            "H10", "HJ", "HQ", "HK", "HA",
            "I2", "I3", "I4", "I5", "I6", "I7", "I8", "I9",
            "I10", "IJ", "IQ", "IK", "IA",
            "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9",
            "C10", "CJ", "CQ", "CK", "CA",
            "P2", "P3", "P4", "P5", "P6", "P7", "P8", "P9",
            "P10", "PJ", "PQ", "PK", "PA",
            "J1", "J2",
        };

        

        // pattay is null
        // pattay da size ni pta
        // encapsulate the stuff you don't want the consumer to be confused with
        // reference type variable and value type variables
        // equating/assigning a reference variable to another reference variable, simply
        // copies it's contents (i.e. the reference that it held for an object).
        // SO now you have 2 reference variables that are pointing to the same object.
        public Tash() : this(52)
        {
            // Tash(52);
            for (int i = 0; i < 52; i++)
            {
                pattay[i] = buniyadi_pattay[i];
            }
            
        }

        public Tash(uint kinnay_pattay_chahiday_nay)
        {
            pattay = new string[kinnay_pattay_chahiday_nay];
        }

        public Tash(uint kinnay_pattay_chahiday_nay, bool fanty_maarni_hai)
        {

        }
        
        // 
        public void create_pattay(uint size)
        {
            pattay = new string[size];
        }

        public void shuffle()
        {
            
        }


        string[] op_codes = { "ADD", "SUB", "MUL" };

        void execute_program(string[] program)
        {
            foreach(var instruction in program)
                if ( instruction == "ADD" )
                {
                    // code inside this will implement "ADD" instruction
                }
                else if (instruction == "SUB")
                {
                    // code inside this will implement "SUB" instruction
                }
        }
    }
}
