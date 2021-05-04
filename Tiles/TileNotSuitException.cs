using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiichiCalc.Tiles
{
    class TileNotSuitException : UnexpectedTileException
    {
        public TileNotSuitException(MahjongTile given) : base(given)
        {
        }
    }
}
