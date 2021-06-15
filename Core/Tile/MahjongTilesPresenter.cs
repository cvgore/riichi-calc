using System;
using RiichiCalc.Core.Tile;

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

        private const uint HonorMin = (uint)MahjongTile.WindEast;
        private const uint HonorMax = (uint)MahjongTile.DragonWhite;

        private const uint SuitMaxTiles = 9;

        public static string GetWindName(this MahjongTile tile)
        {
            return tile switch
            {
                MahjongTile.WindEast => "East",
                MahjongTile.WindSouth => "South",
                MahjongTile.WindWest => "West",
                MahjongTile.WindNorth => "North",
                _ => throw new TileNotWindException(tile)
            };
        }

        public static string GetDragonName(this MahjongTile tile)
        {
            return tile switch
            {
                MahjongTile.DragonRed => "Red",
                MahjongTile.DragonGreen => "Green",
                MahjongTile.DragonWhite => "White",
                _ => throw new TileNotDragonException(tile)
            };
        }

        public static MahjongTileSuit GetSuit(this MahjongTile tile)
        {
            if (tile.IsPinzu())
            {
                return MahjongTileSuit.Pinzu;
            }

            if (tile.IsManzu())
            {
                return MahjongTileSuit.Manzu;
            }

            if (tile.IsSouzu())
            {
                return MahjongTileSuit.Souzu;
            }

            throw new TileNotSuitException(tile);
        }

        public static bool IsHonor(this MahjongTile tile)
        {
            var id = (uint) tile;

            return id >= HonorMin && id <= HonorMax;
        }

        public static bool IsTerminal(this MahjongTile tile)
        {
            var id = (uint) tile;

            if (id > ManzuMin && id < ManzuMax)
            {
                return false;
            }

            if (id > SouzuMin && id < SouzuMax)
            {
                return false;
            }

            if (id > PinzuMin && id < PinzuMax)
            {
                return false;
            }

            return true;
        }

        public static string GetSuitName(this MahjongTile tile)
        {
            if (tile.IsPinzu())
            {
                return "Pinzu";
            }

            if (tile.IsManzu())
            {
                return "Manzu";
            }

            if (tile.IsSouzu())
            {
                return "Souzu";
            }

            throw new TileNotSuitException(tile);
        }

        public static bool IsOneOrNine(this MahjongTile tile)
        {
            if (tile.IsHonor())
            {
                return false;
            }

            var no = tile.GetTileNumber();

            return no == 1 || no == 9;
        }

        public static uint GetTileNumber(this MahjongTile tile)
        {
            if (tile.IsWind() || tile.IsDragon())
            {
                throw new TileNotSuitException(tile);
            }

            var id = (uint)tile;

            return ((id - HonorMax - 1) % SuitMaxTiles) + 1;
        }

        public static bool IsPinzu(this MahjongTile tile)
        {
            var id = (uint)tile;

            return id is <= PinzuMax and >= PinzuMin;
        }

        public static bool IsSouzu(this MahjongTile tile)
        {
            var id = (uint)tile;

            return id is <= SouzuMax and >= SouzuMin;
        }

        public static bool IsManzu(this MahjongTile tile)
        {
            var id = (uint)tile;

            return id is <= ManzuMax and >= ManzuMin;
        }

        public static bool IsWind(this MahjongTile tile)
        {
            switch (tile)
            {
                case MahjongTile.WindSouth:
                case MahjongTile.WindEast:
                case MahjongTile.WindWest:
                case MahjongTile.WindNorth:
                    return true;
            }

            return false;
        }

        public static bool IsDragon(this MahjongTile tile)
        {
            switch (tile)
            {
                case MahjongTile.DragonGreen:
                case MahjongTile.DragonWhite:
                case MahjongTile.DragonRed:
                    return true;
            }

            return false;
        }

        public static string ToPrettyString(this MahjongTile tile)
        {
            if (tile.IsWind())
            {
                return $"Wind: {tile.GetWindName()}";
            }

            if (tile.IsDragon())
            {
                return $"Dragon: {tile.GetDragonName()}";
            }

            var idx = tile.GetTileNumber();

            return $"{tile.GetSuitName()}: {idx}";
        }

        public static string ToTileSymbol(this MahjongTile tile)
        {
            return tile switch
            {
                MahjongTile.WindEast => "1",
                MahjongTile.WindSouth => "2",
                MahjongTile.WindWest => "3",
                MahjongTile.WindNorth => "4",
                MahjongTile.DragonRed => "7",
                MahjongTile.DragonGreen => "6",
                MahjongTile.DragonWhite => "5",
                MahjongTile.Pinzu1 => "z",
                MahjongTile.Pinzu2 => "x",
                MahjongTile.Pinzu3 => "c",
                MahjongTile.Pinzu4 => "v",
                MahjongTile.Pinzu5 => "b",
                MahjongTile.Pinzu6 => "n",
                MahjongTile.Pinzu7 => "m",
                MahjongTile.Pinzu8 => ",",
                MahjongTile.Pinzu9 => ".",
                MahjongTile.Souzu1 => "a",
                MahjongTile.Souzu2 => "s",
                MahjongTile.Souzu3 => "d",
                MahjongTile.Souzu4 => "f",
                MahjongTile.Souzu5 => "g",
                MahjongTile.Souzu6 => "h",
                MahjongTile.Souzu7 => "j",
                MahjongTile.Souzu8 => "k",
                MahjongTile.Souzu9 => "l",
                MahjongTile.Manzu1 => "q",
                MahjongTile.Manzu2 => "w",
                MahjongTile.Manzu3 => "e",
                MahjongTile.Manzu4 => "r",
                MahjongTile.Manzu5 => "t",
                MahjongTile.Manzu6 => "y",
                MahjongTile.Manzu7 => "u",
                MahjongTile.Manzu8 => "i",
                MahjongTile.Manzu9 => "o",
                // Odd if happens
                _ => throw new InvalidTileException(tile)
            };
        }
    }
}
