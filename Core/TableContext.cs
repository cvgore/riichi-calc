using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiichiCalc.Core.States;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core
{
    public class TableContext
    {
        public MahjongWindTile TableWind { get; set; }
        public MahjongWindTile PlayerWind { get; set; }
        public WinMethod WinMethod { get; set; }
        public BetYaku BetYaku { get; set; }
        public ExtraYaku ExtraYaku { get; set; }
        public HandContext Hand { get; }
        public uint DoraCount { get; set; }

        public TableContext()
        {
            Hand = new(new EmptyHandState());
            ExtraYaku = ExtraYaku.None;
            BetYaku = BetYaku.NoRiichi;
            WinMethod = WinMethod.Tsumo;
            PlayerWind = TableWind = MahjongWindTile.WindEast;
        }
    }
}
