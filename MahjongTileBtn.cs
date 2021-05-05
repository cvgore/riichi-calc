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
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        private static PrivateFontCollection? _fontCollection;
        private static IntPtr _fontPtr;
        private static int _counter = 0;
        private const float FontYMargin = 5f;
        private const float FontXMargin = 3f;

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


        private void InitFont()
        {
            _fontCollection = new();

            _fontPtr = Marshal.AllocCoTaskMem(MainRes.MahjongTiles.Length);

            Marshal.Copy(
                MainRes.MahjongTiles,
                0,
                _fontPtr,
                MainRes.MahjongTiles.Length
            );

            if (DesignMode)
            {
                tileBtn.UseCompatibleTextRendering = true;
            }
            else
            {
                // https://stackoverflow.com/a/1956043
                uint cFonts = 0;
                AddFontMemResourceEx(_fontPtr, (uint)MainRes.MahjongTiles.Length, IntPtr.Zero, ref cFonts);
            }
            
            _fontCollection.AddMemoryFont(_fontPtr, MainRes.MahjongTiles.Length);
        }

        public MahjongTileBtn()
        {
            Make(MahjongTile.WindSouth);
        }

        public MahjongTileBtn(MahjongTile tile)
        {
            Make(tile);
        }

        private void Make(MahjongTile tile)
        {
            if (null == _fontCollection)
            {
                InitFont();
            }

            InitializeComponent();

            Tile = tile;
            tileBtn.Font = new Font(_fontCollection!.Families[0], 32f);

            _counter++;
        }

        private void PostUpdateTile()
        {
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

        private void tileBtn_Paint(object sender, PaintEventArgs e)
        {
            // This font is a little bit buggy and it's rendering needs to be adjusted (FontYMargin)
            e.Graphics.DrawString(
                Tile.ToTileSymbol(),
                tileBtn.Font,
                new SolidBrush(tileBtn.ForeColor),
                new PointF(-FontXMargin, Height / 2f - tileBtn.Font.Size / 2f - FontYMargin)
            );
        }
    }
}
