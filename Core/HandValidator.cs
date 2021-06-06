using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core
{
    class HandValidator
    {
        public static bool IsValidSet(IReadOnlyList<MahjongTile> set)
        {
            
        }

        public static int CountSets(IReadOnlyList<MahjongTile> set)
        {
            set.Count(x => x.IsDragon())
        }
    }
}
