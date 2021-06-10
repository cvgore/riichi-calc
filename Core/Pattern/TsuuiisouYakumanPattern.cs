using System.Collections.Generic;
using System.Linq;
using System.Timers;
using RiichiCalc.Core.Hand;
using RiichiCalc.Core.Tile;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Pattern
{
    class TsuuiisouYakumanPattern : IYakumanPattern
    {
        public bool Matches(TableContext ctx, ParsedHand hand)
        {
            return hand.IsRegularCompleteHand
                   && hand.Tiles.All(x => x.IsHonor());
        }

        public string Name() => "Tsuuiisou";

        public uint BigPoints() => 13;

        public uint BigPointsOpenHanded() => 13;
    }
}