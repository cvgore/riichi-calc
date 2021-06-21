using System.Collections.Generic;
using RiichiCalc.Core.Hand;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.States
{
    class EmptyHandState : IHandState
    {
        public bool AddTile(HandContext ctx, MahjongTile tile)
        {
            ctx.SetState(new SomeHandState(new[] {tile}));

            return true;
        }

        public bool RemoveTile(HandContext ctx, int tile)
        {
            return false;
        }

        public IReadOnlyList<MahjongTile> GetTiles() => new List<MahjongTile>();
        public IReadOnlyList<Group> GetGroups() => new List<Group>();
    }
}