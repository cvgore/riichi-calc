using System.Collections.Generic;
using System.Linq;
using System.Timers;
using RiichiCalc.Core.Hand;
using RiichiCalc.Core.Tile;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Pattern
{
    class DaisuushiYakumanPattern : IYakumanPattern
    {
        public bool Matches(TableContext ctx, ParsedHand hand)
        {
            return hand.IsRegularCompleteHand
                   && hand.Groups.Where(x => x.FirstTile.IsWind()).Count(x => x is Triple) == 4;
        }

        public string Name() => "Daisuushi";

        public uint BigPoints() => 13;

        public uint BigPointsOpenHanded() => 13;
    }
}