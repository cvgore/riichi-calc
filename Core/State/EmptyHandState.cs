using System.Collections.Generic;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.States
{
    class EmptyHandState : IHandState
    {
        public void AddTile(HandContext ctx, MahjongTile tile)
        {
            ctx.SetState(new SomeHandState(new(new [] {tile})));
        }

        public void RemoveTile(HandContext ctx, int tile)
        {
            // noop
        }

        public IReadOnlyList<MahjongTile> GetItems() => new MahjongTile[]{};
    }
}