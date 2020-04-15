using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SlotClassLibrary;

namespace SlotUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Game game = new Game();
            Wheel leftWheel = game.WheelValue();
            Console.Write(leftWheel.SymbolType.ToString());

        
        }
    }
    
}
