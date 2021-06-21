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

        public MahjongTileSet()
        {
            InitializeComponent();
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
                tilesSet.Controls.Clear();
            }
        }

        private void TileAdded(object? sender, MahjongTile tile)
        {
            var tileBtn = new MahjongTileBtn(tile);
            tileBtn.Click += TileBtn_Click;
        
            tilesSet.Controls.Add(tileBtn);
            List<MahjongTileBtn> ctrls = new(tilesSet.Controls.Count);
            ctrls.AddRange(tilesSet.Controls.Cast<MahjongTileBtn>());

            tilesSet.Controls.Clear();
            tilesSet.Controls.AddRange(ctrls.OrderBy(x => x.Tile).ToArray());
        }

        private void TileRemoved(object? sender, int tile)
        {
            List<MahjongTileBtn> ctrls = new(tilesSet.Controls.Count);
            ctrls.AddRange(tilesSet.Controls.Cast<MahjongTileBtn>());

            tilesSet.Controls.Clear();
            tilesSet.Controls.AddRange(ctrls.OrderBy(x => x.Tile).ToArray());
        }

        private void TileBtn_Click(object? sender, EventArgs e)
        {
            var tileBtn = (MahjongTileBtn)sender!;

            var pos = tilesSet.Controls.IndexOf(tileBtn);

            _handCtx.RemoveTile(pos);
        }
    }
}
