using SlotClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotConsoleUIApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            
            var gameResult = game.EvaluateAllWheels();
            Console.Write(gameResult);
            Console.ReadLine();



            Game gameTwo = new Game();
            Wheel centerWheel = gameTwo.WheelValue();
            Console.Write(centerWheel.SymbolType.ToString());
            Console.ReadLine();
            //Game gameThree = new Game();
            //Wheel rightWheel = gameThree.WheelValue();
            //Console.Write(rightWheel.SymbolType.ToString());
        }
    }
}
