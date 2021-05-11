using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiichiCalc.Tiles
{
    public static class BetYakuPresenter
    {
        public static string ToPrettyString(this BetYaku yaku)
        {
            return yaku switch
            {
                BetYaku.NoRiichi => "No Riichi",
                BetYaku.Riichi => "Riichi",
                BetYaku.DoubleRiichi => "Double Riichi",
                _ => throw new ArgumentOutOfRangeException(nameof(yaku), yaku, null)
            };
        }
    }
}
