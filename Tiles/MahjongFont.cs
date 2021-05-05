using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiichiCalc.Tiles
{
    class MahjongFont: IDisposable
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        private static PrivateFontCollection? _fontCollection;
        private static IntPtr _fontPtr;
        private static int _counter = 0;
        private const float FontYMargin = 5f;
        private const float FontXMargin = 3f;

        private void InitFontFor()
        {
            _fontCollection = new();

            _fontPtr = Marshal.AllocCoTaskMem(MainRes.MahjongTiles.Length);

            Marshal.Copy(
                MainRes.MahjongTiles,
                0,
                _fontPtr,
                MainRes.MahjongTiles.Length
            );

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                Application.SetCompatibleTextRenderingDefault(true);
            }
            else
            {
                // https://stackoverflow.com/a/1956043
                uint cFonts = 0;
                AddFontMemResourceEx(_fontPtr, (uint)MainRes.MahjongTiles.Length, IntPtr.Zero, ref cFonts);
            }

            _fontCollection.AddMemoryFont(_fontPtr, MainRes.MahjongTiles.Length);
        }

        private void ReleaseUnmanagedResources()
        {
            _fontCollection?.Dispose();
            Marshal.FreeCoTaskMem(_fontPtr);
        }

        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }

        ~MahjongFont()
        {
            ReleaseUnmanagedResources();
        }
    }
}
