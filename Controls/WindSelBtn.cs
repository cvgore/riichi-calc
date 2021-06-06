using System;
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
        }
        
        private void toggleBtn_Paint(object sender, PaintEventArgs e)
        {
            _mfi.PaintText(e.Graphics, (MahjongTile)Value);
        }
    }
}
