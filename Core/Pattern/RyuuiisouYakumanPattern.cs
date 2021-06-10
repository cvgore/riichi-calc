using System.Collections.Generic;
using System.Linq;
using RiichiCalc.Core.Hand;
using RiichiCalc.Core.Tile;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Pattern
{
    class RyuuiisouYakumanPattern : IYakumanPattern
    {
        public bool Matches(TableContext ctx, ParsedHand hand)
        {
            return hand.Tiles.All(x => x == MahjongTile.DragonGreen || !x.IsTerminal() && x.GetSuit() == MahjongTileSuit.Souzu);
        }

        public string Name() => "Ryuuiisou";

        public uint BigPoints() => 13;

        public uint BigPointsOpenHanded() => 13;
    }
}