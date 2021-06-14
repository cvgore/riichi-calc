using System.Collections.Generic;
using System.Linq;
using RiichiCalc.Core.Hand;
using RiichiCalc.Core.Tile;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Pattern
{
    class ChuurenPoutouYakumanPattern : IPattern
    {
        public uint Matches(TableContext ctx, ParsedHand hand)
        {
            if (!hand.IsRegularCompleteHand)
            {
                return 0;
            }

            return !hand.Tiles.Any(x => x.IsHonor())
                   && hand.Tiles.GroupBy(x => x.GetSuit()).Count() == 1
                   && hand.Groups.Any(x => x is Triple && x.FirstTile.GetTileNumber() == 1)
                   && hand.Groups.Any(x => x is Triple && x.FirstTile.GetTileNumber() == 9)
                   && hand.Tiles.ToHashSet().Count == 9
                   ? 1u
                   : 0;
        }

        public string Name() => "Chuuren poutou";

        public uint BigPoints() => 13;

        public uint BigPointsOpenHanded() => 0;
    }
}