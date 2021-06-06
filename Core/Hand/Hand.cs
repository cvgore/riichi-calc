using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Hand
{
    class Hand
    {
        private readonly List<MahjongTile> _tiles;
        public CalculatedHand CalculatedHand { get; private set; }

        public Hand(IReadOnlyList<MahjongTile> tiles)
        {
            _tiles = tiles.ToList();
        }

        public void Calculate()
        {
            CalculatedHand = new(_tiles);
        }
    }
}
