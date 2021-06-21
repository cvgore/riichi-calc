using System;
using System.Collections.Generic;
using System.Linq;
using RiichiCalc.Core.Hand;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.States
{
    class SomeHandState : IHandState
    {
        private readonly List<MahjongTile> _collection;

        private readonly List<Group> _preGroups;

        public SomeHandState(IReadOnlyList<MahjongTile> collection, IReadOnlyList<Group>? preGroups = null)
        {
            _collection = collection.ToList();
            _preGroups = preGroups != null ? preGroups.ToList() : new();
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
            if (_preGroups.Any(x => x.StartIndex == index))
            {
                var grp = _preGroups.First(x => x.StartIndex == index);

                if (grp is not Sequence)
                {
                    for (int i = 0; i < grp.Tiles.Count; i++)
                    {
                        _collection.RemoveAt(grp.StartIndex + i);
                    }
                }
                else
                {

                }
            }
            _collection.RemoveAt(index);

            if (0 == _collection.Count)
            {
                ctx.SetState(new EmptyHandState());
            }

            return true;
        }

        public IReadOnlyList<MahjongTile> GetTiles() => _collection;

        public IReadOnlyList<Group> GetGroups() => _preGroups;
    }
}