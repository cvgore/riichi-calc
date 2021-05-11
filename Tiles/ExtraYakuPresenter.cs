using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiichiCalc.Tiles
{
    public static class ExtraYakuPresenter
    {
        public static string ToPrettyString(this ExtraYaku yaku)
        {
            return yaku switch
            {
                ExtraYaku.None => "None",
                ExtraYaku.Chankan => "Chankan",
                ExtraYaku.RinshanKaihou => "Rinshan Kaihou",
                ExtraYaku.Haitei => "Haitei",
                ExtraYaku.Houtei => "Houtei",
                ExtraYaku.Ippatsu => "Ippatsu",
            };
        }
    }
}
