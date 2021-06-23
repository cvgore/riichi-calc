using System;
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
        private HandContext _handCtx = null!;
        private bool _updating = true;

        public MahjongTileSet()
        {
            InitializeComponent();

            for (int i = 0; i < 18; i++)
            {
                var mtb = new MahjongTileBtn
                {
                    Visible = false
                };
                mtb.Click += TileBtn_Click;

                tilesSet.Controls.Add(mtb);
            }
        }

        public void SetHandContext(HandContext ctx)
        {
            _handCtx = ctx;
            _handCtx.TileAdded += TileAdded;
            _handCtx.TileRemoved += TileRemoved;
            _handCtx.StateChanged += StateChanged;
        }

        private void StateChanged(object? sender, IHandState e)
        {
            if (e is EmptyHandState)
            {
                foreach (Control ctrl in tilesSet.Controls)
                {
                    ctrl.Visible = false;
                }
            }
        }

        private void TileAdded(object? sender, MahjongTile _)
        {
            BeginUpdate();

            var tiles = _handCtx.GetHandTiles().ToList();

            for (int i = tiles.Count; i < tilesSet.Controls.Count; i++)
            {
                tilesSet.Controls[i].Visible = false;
            }

            for (int i = 0; i < tiles.Count; i++)
            {
                var mtb = (MahjongTileBtn) tilesSet.Controls[i];

                mtb.Tile = tiles[i];
                mtb.Visible = true;
            }

            EndUpdate();
        }

        private void TileRemoved(object? sender, int _)
        {
            BeginUpdate();

            var tiles = _handCtx.GetHandTiles().ToList();

            for (int i = tiles.Count; i < tilesSet.Controls.Count; i++)
            {
                tilesSet.Controls[i].Visible = false;
            }

            for (int i = 0; i < tiles.Count; i++)
            {
                var mtb = (MahjongTileBtn) tilesSet.Controls[i];

                mtb.Tile = tiles[i];
                mtb.Visible = true;
            }

            EndUpdate();
        }

        private void TileBtn_Click(object? sender, EventArgs e)
        {
            var tileBtn = (MahjongTileBtn) sender!;
            var pos = tilesSet.Controls.IndexOf(tileBtn);

            _handCtx.RemoveTile(pos);
        }

        public void BeginUpdate() => _updating = false;
        public void EndUpdate() => _updating = true;

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_updating)
            {
                base.OnPaint(e);
            }
        }
    }
}