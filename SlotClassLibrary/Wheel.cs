using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotClassLibrary
{

    public enum Symbols { Seven = 1, Cherry, Orange }


    public class Wheel
    {
        public Wheel(int randomNumber)
        {
            //assign the property SymbolType by calling the WheelAssignment Method
            WheelAssignment(randomNumber);
        }

        public Symbols SymbolType { get; set; }


        //public int NumberGenerator()

        //{
        //    Random engine = new Random();
        //    int randomNumber = engine.Next(0, 3);
        //    return randomNumber;

        //}



        // in the Game class generate a random number, and pass it into WheelAssignment
        public void WheelAssignment(int randomNumber)
        {

            switch (randomNumber)
            {
                case 1:
                    SymbolType = Symbols.Seven;
                    break;
                case 2:
                    SymbolType = Symbols.Orange;
                    break;
                case 3:
                    SymbolType = Symbols.Cherry;
                    break;
            }



            //switch case to evaluate the number from 0 - 2
            //for case "0" set the value of SymbolType = Symbols.Seven
        }
    }
}
