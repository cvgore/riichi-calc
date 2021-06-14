using System.Collections.Generic;
using System.Linq;
using System.Timers;
using RiichiCalc.Core.Hand;
using RiichiCalc.Core.Tile;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Pattern
{
    class DaisangenYakumanPattern : IPattern
    {
        public uint Matches(TableContext ctx, ParsedHand hand)
        {
            if (!hand.IsRegularCompleteHand)
            {
                return 0;
            }

            return hand.Groups.Where(x => x.FirstTile.IsDragon() && x is Triple)
                    .GroupBy(x => x).Count() == 3
                ? 1u
                : 0;
        }

        public string Name() => "Daisangen";

        public uint BigPoints() => 13;

        public uint BigPointsOpenHanded() => 13;
    }
}