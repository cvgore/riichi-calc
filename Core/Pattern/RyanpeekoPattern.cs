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
    class RyanpeekoPattern : IPattern
    {
        public uint Matches(TableContext ctx, ParsedHand hand)
        {
            return hand.Groups.Where(x => x is Sequence)
                .GroupBy(x => x.FirstTile.GetSuit())
                .Count(x => x.GroupBy(y => y.FirstTile).Count() == 2) == 2 ? 1u : 0;
        }

        public string Name() => "Ryanpeeko";

        public uint BigPoints() => 3;

        public uint BigPointsOpenHanded() => 0;
    }
}
