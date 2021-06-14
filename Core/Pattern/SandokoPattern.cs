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
    class SandoukouPattern : IPattern
    {
        public uint Matches(TableContext ctx, ParsedHand hand)
        {
            if (!hand.IsRegularCompleteHand)
            {
                return 0;
            }

            var groups = hand.Groups.Where(x => x is Triple && !x.FirstTile.IsHonor())
                .GroupBy(x => {
                    var mx = new Queue<int>(new []{100, 10, 1});

                    return x.Tiles.Sum(val => mx.Dequeue() * (int) val);
                });

            if (groups.Count() != 1)
            {
                return 0;
            }

            var grp = groups.First();

            return grp.GroupBy(x => x.FirstTile.GetSuit()).All(x => x.Count() == 1) ? 1u : 0;
        }

        public string Name() => "Sandoukou";

        public uint BigPoints() => 2;

        public uint BigPointsOpenHanded() => 1;
    }
}
