using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Pattern
{
    interface IPattern
    {
        string Name();

        /// <summary>
        /// Tests if set matches pattern. Return 0 if match not found, return 1 if match found.
        /// For multi-matches (pattern can exist in set multiple times) return > 1 (if found 2 patterns, return 2)
        /// </summary>
        uint Matches(TableContext ctx, IReadOnlyList<MahjongTile> set);
        /// <summary>
        /// Must be greater than 0, returns points given to player, when pattern matches and hand is not opened
        /// </summary>
        uint BigPoints();
        /// <summary>
        /// Set to zero if pattern is not permitted while hand has been opened.
        /// Set to null, if equals to points given while hand is closed
        /// </summary>
        uint? BigPointsOpenHanded();
    }
}
