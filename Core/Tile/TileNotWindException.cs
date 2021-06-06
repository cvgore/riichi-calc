using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiichiCalc.Tiles
{
    class TileNotWindException : UnexpectedTileException
    {
        public TileNotWindException(MahjongTile given) : base(given)
        {
        }
    }
}
