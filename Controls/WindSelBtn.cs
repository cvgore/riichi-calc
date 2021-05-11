using System;
using System.Windows.Forms;
using RiichiCalc.Tiles;

namespace RiichiCalc.Controls
{
    public partial class WindSelBtn : UserControl
    {
        private readonly uint WindMax = (uint)MahjongTile.WindNorth;
        private readonly MahjongFontInstance _mfi;

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
        }

        public WindSelBtn()
        {
            InitializeComponent();

            _mfi = new(togglerBtn, 24f);
        }

        private void togglerBtn_Click(object sender, EventArgs e)
        {
            _value = (MahjongTile)(((uint)_value + 1) % (WindMax + 1));

            Refresh();
        }

        private void togglerBtn_Paint(object sender, PaintEventArgs e)
        {
            _mfi.PaintText(e.Graphics, Value);
        }
    }
}
