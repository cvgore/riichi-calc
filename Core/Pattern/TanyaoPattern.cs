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
    class TanyaoPattern : IPattern
    {
        public uint Matches(TableContext ctx, ParsedHand hand)
        {
            return hand.IsRegularCompleteHand && hand.Tiles.Count(x => x.IsTerminal()) == 0 ? 1u : 0;
        }

        public string Name() => "Tanyao";

        public uint BigPoints() => 1;

        public uint BigPointsOpenHanded() => 1;
    }
}
