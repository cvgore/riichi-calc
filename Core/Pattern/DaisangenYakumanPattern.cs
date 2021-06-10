using System.Collections.Generic;
using System.Linq;
using System.Timers;
using RiichiCalc.Core.Hand;
using RiichiCalc.Core.Tile;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Pattern
{
    class DaisangenYakumanPattern : IYakumanPattern
    {
        public bool Matches(TableContext ctx, ParsedHand hand)
        {
            return hand.IsRegularCompleteHand
                && hand.Groups.Where(x => x.FirstTile.IsDragon() && x is Triple)
                    .GroupBy(x => x).Count() == 3;
        }

        public string Name() => "Daisangen";

        public uint BigPoints() => 13;

        public uint BigPointsOpenHanded() => 13;
    }
}