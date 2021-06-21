using System.Collections.Generic;
using RiichiCalc.Core.Hand;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.States
{
    public interface IHandState
    {
        bool AddTile(HandContext ctx, MahjongTile tile);
        bool RemoveTile(HandContext ctx, int tile);
        IReadOnlyList<MahjongTile> GetTiles();
        IReadOnlyList<Group> GetGroups();
    }
}