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

        public static string ToTileSymbol(this MahjongTile tile)
        {
            switch (tile)
            {
                case MahjongTile.WindEast:
                    return "1";
                case MahjongTile.WindSouth:
                    return "2";
                case MahjongTile.WindWest:
                    return "3";
                case MahjongTile.WindNorth:
                    return "4";
                case MahjongTile.DragonRed:
                    return "7";
                case MahjongTile.DragonGreen:
                    return "6";
                case MahjongTile.DragonWhite:
                    return "5";
                case MahjongTile.Pinzu1:
                    return "z";
                case MahjongTile.Pinzu2:
                    return "x";
                case MahjongTile.Pinzu3:
                    return "c";
                case MahjongTile.Pinzu4:
                    return "v";
                case MahjongTile.Pinzu5:
                    return "b";
                case MahjongTile.Pinzu6:
                    return "n";
                case MahjongTile.Pinzu7:
                    return "m";
                case MahjongTile.Pinzu8:
                    return ",";
                case MahjongTile.Pinzu9:
                    return ".";
                case MahjongTile.Souzu1:
                    return "a";
                case MahjongTile.Souzu2:
                    return "s";
                case MahjongTile.Souzu3:
                    return "d";
                case MahjongTile.Souzu4:
                    return "f";
                case MahjongTile.Souzu5:
                    return "g";
                case MahjongTile.Souzu6:
                    return "h";
                case MahjongTile.Souzu7:
                    return "j";
                case MahjongTile.Souzu8:
                    return "k";
                case MahjongTile.Souzu9:
                    return "l";
                case MahjongTile.Manzu1:
                    return "q";
                case MahjongTile.Manzu2:
                    return "w";
                case MahjongTile.Manzu3:
                    return "e";
                case MahjongTile.Manzu4:
                    return "r";
                case MahjongTile.Manzu5:
                    return "t";
                case MahjongTile.Manzu6:
                    return "y";
                case MahjongTile.Manzu7:
                    return "u";
                case MahjongTile.Manzu8:
                    return "i";
                case MahjongTile.Manzu9:
                    return "o";
            }

            // Odd if happens
            throw new InvalidTileException(tile);
        }

        public static string ToRawString(this MahjongTile tile) => Enum.GetName(tile)!;
    }
}
