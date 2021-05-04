using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RiichiCalc.Tiles;

namespace RiichiCalc
{
    public partial class MahjongTileBtn : UserControl
    {
        private static PrivateFontCollection? _fontCollection;
        private static IntPtr _fontPtr;
        private static int _counter = 0;

        private MahjongTile _tile = MahjongTile.WindSouth;

        public MahjongTile Tile
        {
            get => _tile;
            set
            {
                _tile = value;
                PostUpdateTile();
            }
        }


        private static void InitFont()
        {
            _fontCollection = new();

            _fontPtr = Marshal.AllocCoTaskMem(MainRes.MahjongTiles.Length);

            Marshal.Copy(
                MainRes.MahjongTiles,
                0,
                _fontPtr,
                MainRes.MahjongTiles.Length
            );

            _fontCollection.AddMemoryFont(_fontPtr, MainRes.MahjongTiles.Length);
        }

        public MahjongTileBtn()
        {
            if (null == _fontCollection)
            {
                InitFont();
            }

            InitializeComponent();

            Make(MahjongTile.WindSouth);
        }

        public MahjongTileBtn(MahjongTile tile)
        {
            if (null == _fontCollection)
            {
                InitFont();
            }

            InitializeComponent();

            Make(tile);
        }

        private void Make(MahjongTile tile)
        {
            Tile = tile;
            tileBtn.Font = new Font(_fontCollection!.Families[0], 32f);

            _counter++;
        }

        private void PostUpdateTile()
        {
            tileBtn.Text = Tile.ToTileSymbol();
            tileTip.SetToolTip(tileBtn, Tile.ToPrettyString());

            tileBtn.ForeColor = Tile switch
            {
                MahjongTile.WindSouth => Color.Blue,
                MahjongTile.WindEast => Color.Blue,
                MahjongTile.WindWest => Color.Blue,
                MahjongTile.WindNorth => Color.Blue,
                MahjongTile.DragonWhite => Color.White,
                MahjongTile.DragonGreen => Color.Green,
                MahjongTile.DragonRed => Color.DarkRed,
                var tile when tile.IsPinzu() => Color.MediumVioletRed,
                var tile when tile.IsManzu() => Color.DarkBlue,
                var tile when tile.IsSouzu() => Color.DarkGreen,
                _ => DefaultForeColor
            };

            Refresh();
        }

        public new static void Dispose()
        {
            // Let last component dispose memory

            if (0 >= --_counter)
            {
                _fontCollection?.Dispose();
                Marshal.FreeCoTaskMem(_fontPtr);
            }
        }
    }
}
