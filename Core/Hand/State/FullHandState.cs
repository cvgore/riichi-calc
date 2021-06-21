using System;
using System.Collections.Generic;
using System.Linq;
using RiichiCalc.Core.Hand;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.States
{
    class FullHandState : IHandState
    {
        public FullHand FullHand { get; }

        private readonly List<Group> _preGroups;

        public FullHandState(IReadOnlyList<MahjongTile> collection, IReadOnlyList<Group>? preGroups)
        {
            FullHand = new FullHand(collection);
            _preGroups = preGroups != null ? preGroups.ToList() : new();
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
