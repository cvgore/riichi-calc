using System;

namespace RiichiCalc.Tiles
{
    static class MahjongTilesPresenter
    {
        private const uint PinzuMin = (uint)MahjongTile.Pinzu1;
        private const uint PinzuMax = (uint)MahjongTile.Pinzu9;

        private const uint SouzuMin = (uint)MahjongTile.Souzu1;
        private const uint SouzuMax = (uint)MahjongTile.Souzu9;

        private const uint ManzuMin = (uint)MahjongTile.Manzu1;
        private const uint ManzuMax = (uint)MahjongTile.Manzu9;

        private const uint TerminalMax = (uint) MahjongTile.DragonWhite;

        private const uint SuitMaxTiles = 9;

        public static string GetWindName(this MahjongTile tile)
        {
            switch (tile)
            {
                case MahjongTile.WindEast:
                    return "East";
                case MahjongTile.WindSouth:
                    return "South";
                case MahjongTile.WindWest:
                    return "West";
                case MahjongTile.WindNorth:
                    return "North";
            }

            throw new TileNotWindException(tile);
        }

        public static string GetDragonName(this MahjongTile tile)
        {
            switch (tile)
            {
                case MahjongTile.DragonRed:
                    return "Red";
                case MahjongTile.DragonGreen:
                    return "Green";
                case MahjongTile.DragonWhite:
                    return "White";
            }

            throw new TileNotDragonException(tile);
        }

        public static string GetSuitName(this MahjongTile tile)
        {
            switch ((uint)tile)
            {
                case <= PinzuMax:
                    return "Pinzu";
                case <= SouzuMax:
                    return "Souzu";
                case <= ManzuMax:
                    return "Manzu";
            }

            throw new TileNotSuitException(tile);
        }

        public static string ToString(this MahjongTile tile)
        {
            switch (tile)
            {
                case MahjongTile.WindEast:
                case MahjongTile.WindSouth:
                case MahjongTile.WindWest:
                case MahjongTile.WindNorth:
                    return $"Wind: {tile.GetWindName()}";

                case MahjongTile.DragonRed:
                case MahjongTile.DragonGreen:
                case MahjongTile.DragonWhite:
                    return $"Dragon: {tile.GetDragonName()}";
            }

            var id = (uint) tile;
            var idx = (id - TerminalMax) % SuitMaxTiles;

            return $"{tile.GetSuitName()}: {idx + 1}";
        }

        public static string ToRawString(this MahjongTile tile) => Enum.GetName(tile)!;
    }
}
