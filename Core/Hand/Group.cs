using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Hand
{
    class Group
    {
        protected List<MahjongTile> _tiles;

        public Group(IReadOnlyList<MahjongTile> tiles)
        {
            _tiles = tiles.ToList();
        }

        public IReadOnlyList<MahjongTile> GetTiles() => _tiles;
    }
}
