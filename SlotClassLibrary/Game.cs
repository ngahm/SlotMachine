using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotClassLibrary
{
    public class Game
    {

        //private Wheel variablename = new Wheel();


        //private Wheel _centerwheel = new Wheel();
        //private Wheel _rightwheel = new Wheel();

        //private Wheel wheelExample = new Wheel();

        int _points = 50;
        Random random = new Random();

        public Wheel WheelValue()
        {         
            int randomNumberOne = random.Next(1, 4);
            Wheel leftWheel = new Wheel(randomNumberOne);
            return leftWheel;
        }
        //public int _centerwheel()
        //{
        //    Random engineTwo = new Random();
        //    int randomNumberTwo = engineTwo.Next(1, 4);
        //    return randomNumberTwo;

        //}
        //public int _rightwheel()
        //{
        //    Random engineThree = new Random();
        //    int randomNumberThree = engineThree.Next(1, 4);
        //    return randomNumberThree;



        public string EvaluateAllWheels()
        {
            //var randomNumberTwo = _centerwheel();
            var wheelOne = WheelValue();
            var wheelTwo = WheelValue();
            var wheelThree = WheelValue();
            var selectorSet = wheelOne.SymbolType.ToString();
          
            //wheel3
            bool allWheels = wheelOne.SymbolType == wheelTwo.SymbolType && wheelTwo.SymbolType == wheelThree.SymbolType;
            if (allWheels)
            {
                switch (selectorSet)
                {
                    case "Seven":
                        _points += 30;
                        break;
                    case "Cherry":
                        _points += 20;
                        break;
                    case "Orange":
                        _points += 10;
                        break;
                    default:
                        break;
                }
                        return  $"{wheelOne.SymbolType} {wheelTwo.SymbolType} {wheelThree.SymbolType}\n" +
                    $"Winner, your total is {_points} points.";
                
            }
            // if allWheels == true 
            //Switch case for wheelOne.SymbolType == Cherry
            // _points = _points + 20
            return $"{wheelOne.SymbolType} {wheelTwo.SymbolType} {wheelThree.SymbolType}\n" +
                $"Loser";

        }





        //public bool Lever { get; set; }
      //  public int Points { get; { return _points; } }
        //public string Run()
        //{

        //    int _initialpoints = 50;
        //    int _setSeven = 30;
        //    int _setCherry = 20;
        //    int _setOrange = 10;
        //    bool IsPulled = true;
        //    bool IsMatched = true;
        //}



        //public Wheel RandomAssignment()
        //{
        //    Wheel _leftwheel = new Wheel();
        //    int connectionMade = _leftwheel.SymbolType;
        //    return;
        //}



        //public int TotalPoints()
        //{
        //    return _initialpoints;
        //}

        //public int AddPoints()
        //{
        //    bool IsPulled = true;
        //    bool IsMatched = true;

        //    if (_allwheels)
        //    {
        //        Total;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Loser);
        //    }
        //}

        //public int DeductPoints()
        //{
        //    bool IsPulled = true;
        //    bool IsMatched = bool;
        //}

    }
}
