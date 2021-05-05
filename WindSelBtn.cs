using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RiichiCalc.Tiles;

namespace RiichiCalc
{
    public partial class WindSelBtn : UserControl
    {
        private readonly uint WindMax = (uint)MahjongTile.WindNorth;

        private MahjongTile _value;

        public MahjongTile Value
        {
            get => _value;
            set => SetValue(value);
        }

        private void SetValue(MahjongTile value)
        {
            if (!value.IsWind())
            {
                throw new TileNotWindException(value);
            }

            _value = value;

            togglerBtn.Text = value.ToTileSymbol();
        }

        public WindSelBtn()
        {
            InitializeComponent();
        }

        private void togglerBtn_Click(object sender, EventArgs e)
        {
            _value = (MahjongTile)((uint)_value + 1 % (WindMax + 1));
        }
    }
}
