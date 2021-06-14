﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RiichiCalc.Core.States;
using RiichiCalc.Tiles;

namespace RiichiCalc.Controls
{
    public partial class MahjongTileSet : UserControl
    {
        // private ObservableCollection<MahjongTile> _tiles;
        private HandContext _handCtx = null!;

        public MahjongTileSet()
        {
            InitializeComponent();

            // _tiles = new();

            // InitObservable();
        }

        public void SetHandContext(HandContext ctx)
        {
            _handCtx = ctx;
            _handCtx.TileAdded += TileAdded;
            _handCtx.TileRemoved += TileRemoved;
        }
        
        private void TileAdded(object? sender, MahjongTile tile)
        {
            // for (int i = tilesSet.Controls.Count; i < items.Count; i++)
            // {
            var tileBtn = new MahjongTileBtn(tile);
            tileBtn.Click += TileBtn_Click;
        
            tilesSet.Controls.Add(tileBtn);
            List<MahjongTileBtn> ctrls = new(tilesSet.Controls.Count);
            ctrls.AddRange(tilesSet.Controls.Cast<MahjongTileBtn>());

            tilesSet.Controls.Clear();
            tilesSet.Controls.AddRange(ctrls.OrderBy(x => x.Tile).ToArray());

            // }
            
            tilesSet.Invalidate();
        }

        private void TileRemoved(object? sender, int tile)
        {
            tilesSet.Invalidate();
        }

        // private void InitObservable()
        // {
        //     _tiles.CollectionChanged += TilesConnectionChanged;
        // }
        //
        // private void TilesConnectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        // {
        //     tilesSet.SuspendLayout();
        //     tilesSet.Controls.Clear();
        //
        //     for (int i = 0; i < _tiles.Count; i++)
        //     {
        //         var tileBtn = new MahjongTileBtn(_tiles[i]) { Tag = i };
        //         tileBtn.Click += TileBtn_Click;
        //
        //         tilesSet.Controls.Add(tileBtn);
        //     }
        //
        //     tilesSet.Invalidate();
        //     tilesSet.ResumeLayout();
        // }

        private void TileBtn_Click([NotNull] object? sender, EventArgs e)
        {
            var tileBtn = (MahjongTileBtn)sender!;

            var pos = tilesSet.Controls.IndexOf(tileBtn);

            _handCtx.RemoveTile(pos);
            tilesSet.Controls.RemoveAt(pos);
        }
    }
}
