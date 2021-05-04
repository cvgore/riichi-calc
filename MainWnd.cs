using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RiichiCalc.Tiles;

namespace RiichiCalc
{
    public partial class MainWnd : Form
    {
        private readonly List<MahjongTileBtn> _tiles = new();

        public MainWnd()
        {
            InitializeComponent();

            for (var i = 0u; i <= (uint)MahjongTile.MaxTile; i++)
            {
                _tiles.Add(new MahjongTileBtn((MahjongTile)i));
                tilesPane.Controls.Add(_tiles.Last());
            }
        }
    }
}
