using System;
using System.Collections.Generic;
using System.Linq;
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

        public bool AddTile(HandContext ctx, MahjongTile tile)
        {
            // Allow adding no more than 3 tiles per variant
            if (_collection.Count(x => x == tile) > 2)
            {
                return false;
            }

            _collection.Add(tile);

            if (ctx.MaxHandLen == _collection.Count)
            {
                ctx.SetState(new FullHandState(_collection));
            }

            return true;
        }

        public bool RemoveTile(HandContext ctx, int index)
        {
            _collection.RemoveAt(index);

            if (0 == _collection.Count)
            {
                ctx.SetState(new EmptyHandState());
            }

            return true;
        }

        public IReadOnlyList<MahjongTile> GetItems() => _collection;
    }
}
