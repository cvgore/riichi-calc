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
    class ChantaPattern : IPattern
    {
        public uint Matches(TableContext ctx, ParsedHand hand)
        {
            return hand.Groups.All(x => x.Tiles.Count(x => x.IsTerminal()) > 0)
                   && hand.Groups.Any(x => x is Sequence)
                ? 1u
                : 0;
        }

        public string Name() => "Chanta";

        public uint BigPoints() => 2;

        public uint BigPointsOpenHanded() => 1;
    }
}
