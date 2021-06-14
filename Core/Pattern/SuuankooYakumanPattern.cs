using System.Collections.Generic;
using System.Linq;
using RiichiCalc.Core.Hand;
using RiichiCalc.Core.Tile;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Pattern
{
    class SuuankouYakumanPattern : IPattern
    {
        public uint Matches(TableContext ctx, ParsedHand hand)
        {
            if (ctx.WinMethod != WinMethod.Tsumo)
            {
                return 0;
            }

            return hand.Groups.Count(x => x is Triple) == 4
                && hand.Groups.Count(x => x is Pair) == 1
                ? 1u
                : 0;
        }

        public string Name() => "Suuankou";

        public uint BigPoints() => 13;

        public uint BigPointsOpenHanded() => 0;
    }
}