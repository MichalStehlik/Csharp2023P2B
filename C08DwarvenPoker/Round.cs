using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08DwarvenPoker
{
    internal class Round
    {
        public Round(int dices, int size)
        {
            if (dices < 1)
            {
                throw new ArgumentException("Nemuzes hrat s mene nez jednou kostkou.");
            }
            Dices = new Dice[dices];
            for (int i = 0; i < dices; i++)
            {
                Dices[i] = new Dice(size);
            }
        }

        public int Count { get { return Dices.Count(); } }
        public int DiceSize { get { return Dices[0].Sides; } }
        public Dice[] Dices { get; init; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var d in Dices)
            {
                sb.Append(d.ToString());
            }
            sb.Append("=");
            sb.Append(Score);
            return sb.ToString();
        }

        public int Sum
        {
            get
            {
                int s = 0;
                for (int i = 0; i < Count; i++) { s += Dices[i].Value; }
                return s;
            }
        }

        public RoundResult Score
        {
            get
            {
                int[] amounts = Amount(Values);
                if (amounts[1] == 1 && amounts[2] == 1 && amounts[3] == 1 && amounts[4] == 1 && amounts[5] == 1) return RoundResult.SixHighStraight;
                if (amounts[0] == 1 && amounts[1] == 1 && amounts[2] == 1 && amounts[3] == 1 && amounts[4] == 1) return RoundResult.FiveHighStraight;

                bool threeSameDice = false;
                uint countPairs = 0;

                for (int i = 0; i < amounts.Length; i++)
                {
                    int value = amounts[i];
                    switch (value)
                    {
                        case 5:
                            return RoundResult.FiveOfKind;
                        case 4:
                            return RoundResult.FourOfKind;
                        case 3:
                            threeSameDice = true;
                            break;
                        case 2:
                            countPairs++;
                            break;
                    }
                }
                if (threeSameDice && countPairs == 1)
                    return RoundResult.FullHouse;
                if (threeSameDice)
                    return RoundResult.ThreeOfKind;
                if (countPairs == 2)
                    return RoundResult.TwoPairs;
                if (countPairs == 1)
                    return RoundResult.Pair;
                return RoundResult.Nothing;
            }
        }

        public int[] Values
        {
            get
            {
                int[] vals = new int[Count];
                for (int i = 0; i < Count; i++) { vals[i] = Dices[i].Value; }
                return vals;
            }
        }

        public bool[] Locks
        {
            get
            {
                bool[] loc = new bool[Count];
                for (int i = 0; i < Count; i++) { loc[i] = Dices[i].Lock; }
                return loc;
            }
        }

        private int[] Amount(int[] values)
        {
            int[] amnts = new int[DiceSize];
            for (int i = 0; i < Count; i++) { amnts[values[i] - 1]++; }
            return amnts;
        }

        public void Roll()
        {
            for (int i = 0; i < Count; i++) { Dices[i].Roll(); }
        }
        public Dice GetDice(int index)
        {
            return Dices[index];
        }
        /// <summary>
        /// Sets lock of dice on specified index
        /// </summary>
        /// <param name="index">index of dice</param>
        /// <param name="state">new state of lock</param>
        public void SetLock(int index, bool state)
        {
            Dices[index].Lock = state;
        }
        /// <summary>
        /// Gets state of lock for dice on specified index
        /// </summary>
        /// <param name="index">index of dice in set</param>
        /// <returns></returns>
        public bool GetLock(int index)
        {
            return Dices[index].Lock;
        }
    }
}
