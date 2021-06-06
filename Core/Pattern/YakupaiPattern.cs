using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Pattern
{
    // A hand with at least one group of dragon tiles, seat wind, or round wind tiles. This hand can be valued at 1 han for each group. 
    class YakupaiPattern : IPattern
    {
        public uint Matches(TableContext ctx, IReadOnlyList<MahjongTile> set)
        {
            var tableWind = ctx.TableWind.ToMahjongTile();
            var ownWind = ctx.TableWind.ToMahjongTile();
            int occs = 0;

            if (set.Count(x => x == tableWind) == 3)
            {
                occs++;
            }

            if (set.Count(x => x == ownWind) == 3)
            {
                occs++;
            }

            return (uint) (occs + set.Where(x => x.IsDragon()).GroupBy(x => x).Count(x => x.Count() == 3));
        }

        public string Name() => "Yakupai";

        public uint BigPoints() => 1;

        public uint? BigPointsOpenHanded() => null;
    }
}
