using System.Drawing;
using System.Windows.Forms;
using RiichiCalc.Tiles;

namespace RiichiCalc.Controls
{
    public partial class MahjongTileBtn : UserControl
    {
        private MahjongTile _tile;
        private readonly MahjongFontInstance _mfi;

        protected override Padding DefaultMargin => new(3);

        public MahjongTile Tile
        {
            get => _tile;
            set
            {
                _tile = value;
                PostUpdateTile();
            }
        }

        /// <summary>
        /// Required for Designer, otherwise crashes
        /// </summary>
        public MahjongTileBtn()
        {
            InitializeComponent();

            _tile = MahjongTile.WindSouth;

            _mfi = new(tileBtn, 28f);
        }

        public MahjongTileBtn(MahjongTile tile = MahjongTile.WindSouth)
        {
            InitializeComponent();

            _tile = tile;

            _mfi = new(tileBtn, 28f);
        }

        private void PostUpdateTile()
        {
            tileTip.SetToolTip(tileBtn, Tile.ToPrettyString());

            ForeColor = Tile switch
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

            Invalidate();
        }

        private void tileBtn_Paint(object sender, PaintEventArgs e)
        {
            _mfi.PaintText(e.Graphics, Tile);
        }

        private void MahjongTileBtn_Load(object sender, System.EventArgs e)
        {
            tileBtn.Click += MahjongTileBtn_Click;
        }

        private void MahjongTileBtn_Click(object? sender, System.EventArgs e)
        {
            OnClick(e);
        }
    }
}
