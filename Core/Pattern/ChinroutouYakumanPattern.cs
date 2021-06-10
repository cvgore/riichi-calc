using System.Collections.Generic;
using System.Linq;
using System.Timers;
using RiichiCalc.Core.Hand;
using RiichiCalc.Core.Tile;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Pattern
{
    class ChinroutouYakumanPattern : IYakumanPattern
    {
        public bool Matches(TableContext ctx, ParsedHand hand)
        {
            return hand.Tiles.All(x => x.IsOneOrNine());
        }

        public string Name() => "Chinroutou";

        public uint BigPoints() => 13;

        public uint BigPointsOpenHanded() => 13;
    }
}