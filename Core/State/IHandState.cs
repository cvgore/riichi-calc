using System.Collections.Generic;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.States
{
    public interface IHandState
    {
        void AddTile(HandContext ctx, MahjongTile tile);
        void RemoveTile(HandContext ctx, int tile);
        IReadOnlyList<MahjongTile> GetItems();
    }
}