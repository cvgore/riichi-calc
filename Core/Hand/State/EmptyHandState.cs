using System.Collections.Generic;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.States
{
    class EmptyHandState : IHandState
    {
        public bool AddTile(HandContext ctx, MahjongTile tile)
        {
            ctx.SetState(new SomeHandState(new(new [] {tile})));
            return true;
        }

        public bool RemoveTile(HandContext ctx, int tile)
        {
            return false;
        }

        public IReadOnlyList<MahjongTile> GetTiles() => new MahjongTile[]{};
    }
}