using System;
using System.Collections.Generic;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.States
{
    class FullHandState : IHandState
    {
        private readonly List<MahjongTile> _collection;

        public FullHandState(List<MahjongTile> collection)
        {
            _collection = collection;
        }

        public void AddTile(HandContext ctx, MahjongTile tile)
        {
            // noop
        }

        public void RemoveTile(HandContext ctx, int index)
        {
            _collection.RemoveAt(index);

            ctx.SetState(new SomeHandState(_collection));
        }

        public IReadOnlyList<MahjongTile> GetItems() => _collection;
    }
}
