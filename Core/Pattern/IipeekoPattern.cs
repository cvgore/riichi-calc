using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiichiCalc.Core.Hand;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Pattern
{
    class IipeekoPattern : IPattern
    {
        public uint Matches(TableContext ctx, ParsedHand hand)
        {
            return hand.Groups.Where(x => x is Sequence)
                .GroupBy(x => x.FirstTile.GetSuit())
                .Count(x => x.GroupBy(y => y.FirstTile).Count() == 2) == 1 ? 1u : 0;
        }

        public string Name() => "Iipeeko";

        public uint BigPoints() => 1;

        public uint BigPointsOpenHanded() => 0;
    }
}
