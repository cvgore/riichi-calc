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
                Refresh();
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

            Tile = MahjongTile.WindSouth;
            _counter++;
        }

        public MahjongTileBtn(MahjongTile tile)
        {
            if (null == _fontCollection)
            {
                InitFont();
            }

            Tile = tile;
            _counter++;

            InitializeComponent();
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
