using System;
using System.Collections.Generic;
using RiichiCalc.Controls;
using RiichiCalc.Core.Hand;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.States
{
    public class HandContext
    {
        public int MaxHandLen = 14;

        public event EventHandler<MahjongTile> TileAdded;
        public event EventHandler<int> TileRemoved;
        public event EventHandler<IHandState> StateChanged;
        public IHandState State { get; private set; }
        private IHandState? PrevState { get; set; }

        public HandContext(IHandState state)
        {
            State = state;
        }

        public void SetState(IHandState state)
        {
            PrevState = State;
            State = state;
            StateChanged?.Invoke(this, state);
        }

        public void AddTile(MahjongTile tile)
        {
            if (State.AddTile(this, tile))
            {
                TileAdded?.Invoke(null, tile);
            }
        }

        public void RemoveTile(int tile)
        {
            if (State.RemoveTile(this, tile))
            {
                TileRemoved?.Invoke(null, tile);
            }
        }

        public void RestorePreviousState()
        {
            if (PrevState != null)
            {
                // Swap prev state with current state
                (State, PrevState) = (PrevState, State);
            }
        }

        public IReadOnlyList<MahjongTile> GetHandTiles() => State.GetTiles();
        public IReadOnlyList<Group> GetHandGroups() => State.GetGroups();
    }
}