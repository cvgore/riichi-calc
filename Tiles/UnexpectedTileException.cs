using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiichiCalc.Tiles
{
    class UnexpectedTileException : Exception
    {
        private readonly MahjongTile _tile;

        protected UnexpectedTileException(MahjongTile given)
        {
            _tile = given;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: unexpected tile {_tile}";
        }
    }
}
