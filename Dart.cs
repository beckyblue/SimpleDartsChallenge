using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dartz
{

    public class Dart
    {
        public int Score { get; set; }
        public bool IsDouble { get; set; } //if lands on "double" area
        public bool IsTriple { get; set; } //if lands on "tripple" area

        private Random _random;

        public Dart(Random random)
        {
            _random = random;
        }

        public void Throw()
        {
            Score = _random.Next(0, 21); // 0-20 scoring

            int multiplier = _random.Next(1, 101); //1-100 number
            if (multiplier > 95) IsTriple = true; // 5% chance of triple
            else if (multiplier > 90) IsDouble = true; //5% chance of double 
        }
    }
}
