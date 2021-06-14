using System;
using System.Collections.Generic;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.States
{
    /// <summary>
    /// Required to denote an invalid, full hand state
    /// </summary>
    class InvalidFullHandState : FullHandState
    {
        public InvalidFullHandState(IReadOnlyList<MahjongTile> collection) : base(collection)
        {
        }
    }
}
