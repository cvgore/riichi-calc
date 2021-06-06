using System;

namespace RiichiCalc.Tiles
{
    static class MahjongWindTilesPresenter
    {
        public static MahjongTile ToMahjongTile(this MahjongWindTile tile) => (MahjongTile)tile;
    }
}
