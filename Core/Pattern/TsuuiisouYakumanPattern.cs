using System.Collections.Generic;
using System.Linq;
using System.Timers;
using RiichiCalc.Core.Hand;
using RiichiCalc.Core.Tile;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Pattern
{
    class TsuuiisouYakumanPattern : IPattern
    {
        public uint Matches(TableContext ctx, ParsedHand hand)
        {
            if (!hand.IsRegularCompleteHand)
            {
                return 0;
            }

            return hand.Tiles.All(x => x.IsHonor())
                ? 1u
                : 0;
        }

        public string Name() => "Tsuuiisou";

        public uint BigPoints() => 13;

        public uint BigPointsOpenHanded() => 13;
    }
}