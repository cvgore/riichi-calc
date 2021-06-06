using System;
using System.Collections.Generic;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.States
{
    class SomeHandState : IHandState
    {
        private readonly List<MahjongTile> _collection;

        public SomeHandState(List<MahjongTile> collection)
        {
            _collection = collection;
        }

        public void AddTile(HandContext ctx, MahjongTile tile)
        {
            _collection.Add(tile);

            if (ctx.MaxHandLen == _collection.Count)
            {
                ctx.SetState(new FullHandState(_collection));
            }
        }

        public void RemoveTile(HandContext ctx, int index)
        {
            _collection.RemoveAt(index);

            if (0 == _collection.Count)
            {
                ctx.SetState(new EmptyHandState());
            }
        }

        public IReadOnlyList<MahjongTile> GetItems() => _collection;
    }
}
