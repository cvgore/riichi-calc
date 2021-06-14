using System;
using System.Collections.Generic;
using RiichiCalc.Core.Hand;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.States
{
    class FullHandState : IHandState
    {
        public FullHand FullHand { get; }

        public FullHandState(IReadOnlyList<MahjongTile> tiles)
        {
            FullHand = new FullHand(tiles);
        }

        public bool AddTile(HandContext ctx, MahjongTile tile)
        {
            return false;
        }

        public bool RemoveTile(HandContext ctx, int index)
        {
            FullHand.ParsedHand.Tiles.RemoveAt(index);

            ctx.SetState(new SomeHandState(FullHand.ParsedHand.Tiles));

            return true;
        }
        
        public IReadOnlyList<MahjongTile> GetItems() => FullHand.ParsedHand.Tiles;
    }
}
