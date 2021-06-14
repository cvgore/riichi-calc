using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiichiCalc.Tiles
{
    class MahjongFontInstance
    {
        private readonly Control _ctr;

        public MahjongFontInstance(Control ctr, float em)
        {
            _ctr = ctr;

            MahjongFont.InitCustomFontForControl(ctr, em);
        }

        public void PaintText(Graphics g, MahjongTile tile)
        {
            MahjongFont.PaintUsingFont(g, tile, _ctr);
        }
        
        ~MahjongFontInstance()
        {
            MahjongFont.DisposeControl();
        }
    }
}
