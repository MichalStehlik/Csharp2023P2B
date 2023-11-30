using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08DwarvenPoker
{
    internal static class Game
    {
        public static int Player1Wins { get; set; } = 0;
        public static int Player2Wins { get; set; } = 0;
        public static Round AddRound(int player)
        {
            return new Round(5, 6);
        }
        public static int ResolveRound(Round pl1, Round pl2)
        {
            if (pl1.Score > pl2.Score)
            {
                Player1Wins++;
                return 1;
            }
            if (pl1.Score < pl2.Score)
            {
                Player2Wins++;
                return 2;
            }
            return 0;
        }
    }
}
