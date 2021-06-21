using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Hand
{
    class Pair : Group
    {
        public Pair(IReadOnlyList<MahjongTile> tiles, int startIndex) : base(tiles, startIndex, false)
        {
            if (tiles.Count != 2 || tiles[0] != tiles[1])
            {
                throw new InvalidGroupException(this);
            }
        }
    }
}
