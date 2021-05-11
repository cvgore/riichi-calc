using System;
using System.Windows.Forms;
using RiichiCalc.Tiles;

namespace RiichiCalc.Controls
{
    public class WindSelBtn : EnumBtn<MahjongWindTile>
    {
        private readonly MahjongFontInstance _mfi;

        public WindSelBtn()
        {
            _mfi = new(toggleBtn, 24f);

            toggleBtn.Paint += toggleBtn_Paint;

            OwnerDraw = true;
        }
        
        private void toggleBtn_Paint(object sender, PaintEventArgs e)
        {
            _mfi.PaintText(e.Graphics, (MahjongTile)Value);
        }
    }
}
