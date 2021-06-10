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
    class HonitsuPattern : IPattern
    {
        public uint Matches(TableContext ctx, ParsedHand hand)
        {
            return hand.Tiles.Where(x => !x.IsHonor()).GroupBy(x => x.GetSuit()).Count() == 1
                   && hand.Tiles.Any(x => x.IsHonor())
                ? 1u
                : 0;
        }

        public string Name() => "Honitsu";

        public uint BigPoints() => 3;

        public uint BigPointsOpenHanded() => 2;
    }
}
