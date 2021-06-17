using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Hand
{
    class Triple : Group
    {
        public Triple(IReadOnlyList<MahjongTile> tiles) : base(tiles)
        {
            if (tiles.Count != 3 || tiles.GroupBy(x => x).Count() != 1 || tiles.Any(x => x.IsHonor()))
            {
                throw new InvalidGroupException(this);
            }
        }
    }
}
