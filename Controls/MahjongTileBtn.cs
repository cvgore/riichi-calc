using System.Diagnostics.CodeAnalysis;
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

        // Required for Designer, otherwise crashes
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
            MahjongFont.Colorize(this, Tile);
            MahjongFont.Tooltipize(tileBtn, tileTip, Tile);

            tileBtn.Invalidate();
        }

        private void tileBtn_Paint([NotNull] object? sender, PaintEventArgs e)
        {
            _mfi.PaintText(e.Graphics, Tile);
        }

        private void MahjongTileBtn_Load([NotNull] object? sender, System.EventArgs e)
        {
            tileBtn.Click += MahjongTileBtn_Click;
        }

        private void MahjongTileBtn_Click([NotNull] object? sender, System.EventArgs e)
        {
            OnClick(e);
        }

        private void MahjongTileBtn_EnabledChanged([NotNull] object? sender, System.EventArgs e)
        {
            if (Enabled)
            {
                PostUpdateTile();
            }
            else
            {
                ForeColor = Color.DimGray;
                tileBtn.Invalidate();
            }
        }
    }
}
