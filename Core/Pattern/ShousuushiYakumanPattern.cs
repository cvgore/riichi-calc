using System.Collections.Generic;
using System.Linq;
using System.Timers;
using RiichiCalc.Core.Hand;
using RiichiCalc.Core.Tile;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Pattern
{
    class ShousuushiYakumanPattern : IPattern
    {
        public uint Matches(TableContext ctx, ParsedHand hand)
        {
            if (!hand.IsRegularCompleteHand)
            {
                return 0;
            }

            return hand.Groups.Where(x => x.FirstTile.IsWind()).Count(x => x is Triple) == 3
                   && hand.Groups.Where(x => x.FirstTile.IsWind()).Count(x => x is Pair) == 1
                   ? 1u
                   : 0;
        }

        public string Name() => "Shousuushi";

        public uint BigPoints() => 13;

        public uint BigPointsOpenHanded() => 13;
    }
}