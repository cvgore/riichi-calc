using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
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
        private readonly HandContext _handCtx;

        public MahjongTileSet(HandContext ctx)
        {
            InitializeComponent();

            // _tiles = new();

            // InitObservable();

            _handCtx = ctx;
            _handCtx.TileAdded += TileAdded;
            _handCtx.TileRemoved += TileRemoved;
        }
        
        private void TileAdded(object? sender, EventArgs e)
        {
            var items = _handCtx.GetHandItems();

            for (int i = tilesSet.Controls.Count; i < items.Count; i++)
            {
                var tileBtn = new MahjongTileBtn(items[i]) { Tag = i };
                tileBtn.Click += TileBtn_Click;
            
                tilesSet.Controls.Add(tileBtn);
            }
            
            tilesSet.Invalidate();
        }

        private void TileRemoved(object? sender, EventArgs e)
        {
            tilesSet.Controls.RemoveAt(tilesSet.Controls.Count - 1);
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

        private void TileBtn_Click(object? sender, EventArgs e)
        {
            var tileBtn = (MahjongTileBtn)sender!;

            _handCtx!.RemoveTile((int)tileBtn.Tag);
        }
    }
}
