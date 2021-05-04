using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiichiCalc.Tiles
{
    class TileNotDragonException : UnexpectedTileException
    {
        public TileNotDragonException(MahjongTile given) : base(given)
        {
        }
    }
}
