using System.Collections.Generic;
using System.Linq;
using RiichiCalc.Core.Hand;
using RiichiCalc.Core.Tile;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Pattern
{
    class ChuurenPoutouYakumanPattern : IYakumanPattern
    {
        public bool Matches(TableContext ctx, ParsedHand hand)
        {
            return !hand.Tiles.Any(x => x.IsHonor())
                   && hand.Tiles.GroupBy(x => x.GetSuit()).Count() == 1
                   && hand.Groups.Any(x => x is Triple && x.FirstTile.GetTileNumber() == 1)
                   && hand.Groups.Any(x => x is Triple && x.FirstTile.GetTileNumber() == 9)
                   && hand.Groups.Count(x => x is Triple || x is Sequence) == 2
                   && hand.Tiles.ToHashSet().Count == 9;
        }

        public string Name() => "Chuuren poutou";

        public uint BigPoints() => 13;

        public uint BigPointsOpenHanded() => 0;
    }
}