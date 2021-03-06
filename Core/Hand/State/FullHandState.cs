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

        public FullHandState(IReadOnlyList<MahjongTile> collection, IReadOnlyList<Group>? preGroups = null)
        {
            _preGroups = preGroups != null ? preGroups.ToList() : new();
            FullHand = new FullHand(collection, _preGroups);
        }

        public bool AddTile(HandContext ctx, MahjongTile tile)
        {
            return false;
        }

        public bool RemoveTile(HandContext ctx, int index)
        {
            if (_preGroups.Any(x => x.StartIndex == index))
            {
                var grp = _preGroups.First(x => x.StartIndex == index);

                foreach (var tile in grp.Tiles)
                {
                    FullHand.ParsedHand.Tiles.RemoveAt(FullHand.ParsedHand.Tiles.FindIndex(grp.StartIndex, x => x == tile));
                    _preGroups.Remove(grp);
                }

                if (grp is Quadruple)
                {
                    ctx.MaxHandLen--;
                }
            }
            else
            {
                FullHand.ParsedHand.Tiles.RemoveAt(index);
            }
            
            ctx.SetState(new SomeHandState(FullHand.ParsedHand.Tiles, _preGroups));

            return true;
        }
        
        public IReadOnlyList<MahjongTile> GetTiles() => FullHand.ParsedHand.Tiles;

        public IReadOnlyList<Group> GetGroups() => FullHand.ParsedHand.Groups;
    }
}
