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
    public partial class TileBtn : UserControl
    {
        private static PrivateFontCollection? _fontCollection;
        private static IntPtr _fontPtr;
        private static uint _counter = 0;

        private readonly MahjongTile _tile;

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

        public TileBtn(MahjongTile tile)
        {
            if (null == _fontCollection)
            {
                InitFont();
            }

            _tile = tile;

            InitializeComponent();

            _counter++;
        }

        public new static void Dispose()
        {
            // Let last component dispose memory
            if (0 == --_counter)
            {
                _fontCollection?.Dispose();
                Marshal.FreeCoTaskMem(_fontPtr);
            }
        }
    }
}
