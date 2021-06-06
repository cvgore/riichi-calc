using System;
using System.Collections.Generic;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.States
{
    /// <summary>
    /// Required to denote an invalid hand state
    /// </summary>
    class InvalidFullHandState : FullHandState
    {
        public InvalidFullHandState(List<MahjongTile> collection) : base(collection)
        {
        }
    }
}
