using System;
using System.Collections.Generic;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.States
{
    public class HandContext
    {
        public readonly int MaxHandLen = 14;

        public event EventHandler TileAdded;
        public event EventHandler TileRemoved;

        private IHandState _currentState;

        public HandContext(IHandState currentState)
        {
            _currentState = currentState;
        }

        public void SetState(IHandState state)
        {
            _currentState = state;
        }

        public void AddTile(MahjongTile tile)
        {
            _currentState.AddTile(this, tile);
            TileAdded?.Invoke(null, EventArgs.Empty);
        }

        public void RemoveTile(int tile)
        {
            _currentState.RemoveTile(this, tile);
            TileRemoved?.Invoke(null, EventArgs.Empty);
        }

        public IReadOnlyList<MahjongTile> GetHandItems() => _currentState.GetItems();

    }
}
