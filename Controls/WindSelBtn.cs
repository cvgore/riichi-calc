using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
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

        protected override void OnEnabledChanged(EventArgs e)
        {
            if (Enabled)
            {
                SetValue(Value); // noop assignment literally, just hack to invoke call tree
            }
            else
            {
                ForeColor = Color.DimGray;
                toggleBtn.Invalidate();
            }
        }

        private void WindSelBtn_ValueChanged(object? sender, EventArgs e)
        {
            MahjongFont.Colorize(this, Value.ToMahjongTile());
        }

        private void toggleBtn_Paint(object? sender, PaintEventArgs e)
        {
            _mfi.PaintText(e.Graphics, (MahjongTile)Value);
        }
    }
}
