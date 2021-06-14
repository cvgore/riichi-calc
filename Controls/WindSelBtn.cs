using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using RiichiCalc.Tiles;

namespace RiichiCalc.Controls
{
    public class WindSelBtn : EnumBtn<MahjongWindTile>
    {
        private readonly MahjongFontInstance _mfi;

        public WindSelBtn(): base(ownerDraw: true)
        {
            _mfi = new(toggleBtn, 24f);

            toggleBtn.Paint += toggleBtn_Paint;

            ValueChanged += WindSelBtn_ValueChanged;
        }

        private void WindSelBtn_ValueChanged([NotNull] object? sender, EventArgs e)
        {
            MahjongFont.Colorize(this, Value.ToMahjongTile());
        }

        private void toggleBtn_Paint([NotNull] object? sender, PaintEventArgs e)
        {
            _mfi.PaintText(e.Graphics, (MahjongTile)Value);
        }
    }
}
