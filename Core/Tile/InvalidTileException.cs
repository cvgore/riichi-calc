using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiichiCalc.Tiles
{
    class InvalidTileException : Exception
    {
        private readonly object _given;

        public InvalidTileException(object given)
        {
            _given = given;
        }

        public override string ToString()
        {
            return $"{GetType().Name} - got {_given} instead of valid {nameof(MahjongTile)}";
        }
    }
}
