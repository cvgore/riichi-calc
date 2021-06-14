using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiichiCalc.Tiles
{
    class MahjongFont
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        private static PrivateFontCollection _fontCollection = null!;
        private static IntPtr _fontPtr = IntPtr.Zero;
        private const float FontYMargin = 2f;
        private const float FontXMargin = 5f;
        private static uint _counter = 0;

        private static void EnsureFontIsInitialized()
        {
            if (_counter != 0)
            {
                return;
            }

            _fontCollection = new();

            _fontPtr = Marshal.AllocCoTaskMem(MainRes.MahjongTiles.Length);

            Marshal.Copy(
                MainRes.MahjongTiles,
                0,
                _fontPtr,
                MainRes.MahjongTiles.Length
            );

            // if (!InDesignMode())
            // {
                // https://stackoverflow.com/a/1956043
                uint cFonts = 0;
                AddFontMemResourceEx(_fontPtr, (uint)MainRes.MahjongTiles.Length, IntPtr.Zero, ref cFonts);
            // }

            _fontCollection.AddMemoryFont(_fontPtr, MainRes.MahjongTiles.Length);
        }

        internal static void InitCustomFontForControl(Control ctr, float em)
        {
            EnsureFontIsInitialized();
            _counter++;

            ctr.Font = new(_fontCollection.Families[0], em);
        }

        // This font is a little bit buggy and it's rendering needs to be adjusted (Font*Margin)
        internal static void PaintUsingFont(Graphics g, MahjongTile tile, Control ctr)
        {
            g.DrawString(
                tile.ToTileSymbol(),
                ctr.Font,
                new SolidBrush(ctr.ForeColor),
                new PointF(ctr.Width / 2f - ctr.Font.Size / 2f - FontXMargin, ctr.Height / 2f - ctr.Font.Size / 2f - FontYMargin)
            );
        }

        public static void Colorize(Control target, MahjongTile tile)
        {
            target.ForeColor = tile switch
            {
                MahjongTile.WindSouth => Color.Blue,
                MahjongTile.WindEast => Color.Blue,
                MahjongTile.WindWest => Color.Blue,
                MahjongTile.WindNorth => Color.Blue,
                MahjongTile.DragonWhite => Color.White,
                MahjongTile.DragonGreen => Color.Green,
                MahjongTile.DragonRed => Color.DarkRed,
                var t when t.IsPinzu() => Color.MediumVioletRed,
                var t when t.IsManzu() => Color.DarkBlue,
                var t when t.IsSouzu() => Color.DarkGreen,
                _ => Control.DefaultForeColor
            };
        }

        public static void Tooltipize(Control target, ToolTip presenter, MahjongTile tile)
        {
            presenter.SetToolTip(target, tile.ToPrettyString());
        }

        internal static void DisposeControl()
        {
            if (--_counter == 0)
            {
                _fontCollection.Dispose();
                Marshal.FreeCoTaskMem(_fontPtr);
            }
        }
    }
}
