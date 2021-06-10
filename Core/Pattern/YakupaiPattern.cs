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
    class YakupaiPattern : IPattern
    {
        public uint Matches(TableContext ctx, ParsedHand hand)
        {
            var tableWind = ctx.TableWind.ToMahjongTile();
            var ownWind = ctx.TableWind.ToMahjongTile();
            int occurrences = 0;

            if (hand.Groups.Any(x => x.FirstTile == tableWind && x is Triple))
            {
                occurrences++;
            }

            if (hand.Groups.Any(x => x.FirstTile == ownWind && x is Triple))
            {
                occurrences++;
            }

            return (uint) (occurrences + hand.Groups.Count(x => x.FirstTile.IsDragon() && x is Triple));
        }

        public string Name() => "Yakupai";

        public uint BigPoints() => 1;

        public uint BigPointsOpenHanded() => 1;
    }
}
