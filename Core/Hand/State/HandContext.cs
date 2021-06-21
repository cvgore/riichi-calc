using System;
using System.Collections.Generic;
using RiichiCalc.Controls;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.States
{
    public class HandContext
    {
        public int MaxHandLen = 14;

        public event EventHandler<MahjongTile> TileAdded;
        public event EventHandler<int> TileRemoved;
        public event EventHandler<IHandState> StateChanged;

        private IHandState _currentState;

        public HandContext(IHandState currentState)
        {
            _currentState = currentState;
        }

        public void SetState(IHandState state)
        {
            _currentState = state;
            StateChanged?.Invoke(this, state);
        }

        public void AddTile(MahjongTile tile)
        {
            if (_currentState.AddTile(this, tile))
            {
                TileAdded?.Invoke(null, tile);
            }
        }

        public void RemoveTile(int tile)
        {
            if (_currentState.RemoveTile(this, tile))
            {
                TileRemoved?.Invoke(null, tile);
            }
        }

        public IReadOnlyList<MahjongTile> GetHandItems() => _currentState.GetTiles();
    }
}
