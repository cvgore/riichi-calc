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
    class IttsuPattern : IPattern
    {
        public uint Matches(TableContext ctx, ParsedHand hand)
        {
            if (!hand.IsRegularCompleteHand)
            {
                return 0;
            }

            if (hand.Groups.Count(x => x is Sequence) < 3)
            {
                return 0;
            }

            return hand.Groups.Where(x => x is Sequence)
                .GroupBy(x => x.FirstTile.GetSuit())
                .Count(x => {
                    var mx = new Queue<uint>(new [] {1u, 4u, 7u});

                    return x.Count() == 3 && x.All(y => y.FirstTile.GetTileNumber() == mx.Dequeue());
                }) == 1
                ? 1u
                : 0;
        }

        public string Name() => "Ittsu";

        public uint BigPoints() => 2;

        public uint BigPointsOpenHanded() => 1;
    }
}
