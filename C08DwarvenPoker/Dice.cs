using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08DwarvenPoker
{
    internal class Dice
    {
        public Dice(int sides = 6)
        {
            if (sides < 2) { throw new ArgumentException("Kostka s takovým počtem stran je nesmylná"); }
            Sides = sides;
            Lock = false;
            Roll();
        }

        public int Sides { get; private set; }
        public int Value { get; private set; }
        public bool Lock { get; set; }
        //private Random _random = new Random();

        /// <summary>
        /// Hození kostkou = vygenerování náhodné hodnoty
        /// </summary>
        /// <returns>hodnota hodu</returns>
        public int Roll()
        {
            if (!Lock)
            {
                //Random random = new Random();
                //Value = _random.Next(0, Sides);
                Value = Random.Shared.Next(1, Sides + 1);
            }
            return Value;
        }

        public override string ToString()
        {
            return (Lock ? "x" : "-") + Value;
        }
    }
}
