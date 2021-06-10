using System.Collections.Generic;
using System.Linq;
using RiichiCalc.Core.Hand;
using RiichiCalc.Core.Tile;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Pattern
{
    class SuuankouYakumanPattern : IYakumanPattern
    {
        public bool Matches(TableContext ctx, ParsedHand hand)
        {
            return hand.Groups.Count(x => x is Triple) == 4;
        }

        public string Name() => "Suuankou";

        public uint BigPoints() => 13;

        public uint BigPointsOpenHanded() => 0;
    }
}