using System.Collections.Generic;
using System.Linq;
using System.Timers;
using RiichiCalc.Core.Hand;
using RiichiCalc.Core.Tile;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Pattern
{
    class KokushumusouYakumanPattern : IPattern
    {
        private static readonly MahjongTile[] Pattern =
        {
            MahjongTile.WindEast, MahjongTile.WindSouth, MahjongTile.WindWest, MahjongTile.WindNorth,
            MahjongTile.DragonRed, MahjongTile.DragonGreen, MahjongTile.DragonWhite,
            MahjongTile.Pinzu1, MahjongTile.Pinzu9,
            MahjongTile.Souzu1, MahjongTile.Souzu9,
            MahjongTile.Manzu1, MahjongTile.Manzu9
        };

        public uint Matches(TableContext ctx, ParsedHand hand)
        {
            return hand.Groups.Count(x => x is Pair) == 1
                   && hand.Tiles.All(x => x.IsTerminal()) 
                   && hand.Tiles.SequenceEqual(Pattern)
                   ? 1u
                   : 0;
        }

        public string Name() => "Kokushumusou";

        public uint BigPoints() => 13;

        public uint BigPointsOpenHanded() => 0;
    }
}