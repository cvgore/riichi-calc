using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiichiCalc.Core.Hand;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Pattern
{
    // A hand with at least one group of dragon tiles, seat wind, or round wind tiles. This hand can be valued at 1 han for each group. 
    class ChinitsuPattern : IPattern
    {
        public uint Matches(TableContext ctx, ParsedHand hand)
        {
            return hand.Tiles.All(x => !x.IsHonor()) && hand.Tiles.GroupBy(x => x.GetSuit()).Count() == 1
                ? 1u
                : 0;
        }

        public string Name() => "Chinitsu";

        public uint BigPoints() => 6;

        public uint BigPointsOpenHanded() => 5;
    }
}
