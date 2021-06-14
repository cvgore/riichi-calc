using System.Collections.Generic;
using System.Linq;
using RiichiCalc.Core.Hand;
using RiichiCalc.Core.Tile;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Pattern
{
    class RyuuiisouYakumanPattern : IPattern
    {
        public uint Matches(TableContext ctx, ParsedHand hand)
        {
            if (!hand.IsRegularCompleteHand)
            {
                return 0;
            }

            return hand.Tiles.All(x => x == MahjongTile.DragonGreen || !x.IsTerminal() && x.GetSuit() == MahjongTileSuit.Souzu)
                ? 1u
                : 0;
        }

        public string Name() => "Ryuuiisou";

        public uint BigPoints() => 13;

        public uint BigPointsOpenHanded() => 13;
    }
}