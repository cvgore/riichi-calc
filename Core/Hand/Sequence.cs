using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiichiCalc.Controls;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Hand
{
    /// <summary>
    /// Sequence is a wrapper for collection of 3 tiles f.e (1,2,3; 6,7,8).
    /// A sequence cannot be constructed of dragons, winds.
    /// Sequence cannot loop (i.e: 9,1,2 is invalid)
    ///
    /// See <see cref="ValidSequences"/> for examples of valid sequences
    /// </summary>
    class Sequence : Group
    {
        public static readonly MahjongTile[][] ValidSequences = {
            new[] {MahjongTile.Manzu1, MahjongTile.Manzu2, MahjongTile.Manzu3},
            new[] {MahjongTile.Manzu2, MahjongTile.Manzu3, MahjongTile.Manzu4},
            new[] {MahjongTile.Manzu3, MahjongTile.Manzu4, MahjongTile.Manzu5},
            new[] {MahjongTile.Manzu4, MahjongTile.Manzu5, MahjongTile.Manzu6},
            new[] {MahjongTile.Manzu5, MahjongTile.Manzu6, MahjongTile.Manzu7},
            new[] {MahjongTile.Manzu6, MahjongTile.Manzu7, MahjongTile.Manzu8},
            new[] {MahjongTile.Manzu7, MahjongTile.Manzu8, MahjongTile.Manzu9},

            new[] {MahjongTile.Souzu1, MahjongTile.Souzu2, MahjongTile.Souzu3},
            new[] {MahjongTile.Souzu2, MahjongTile.Souzu3, MahjongTile.Souzu4},
            new[] {MahjongTile.Souzu3, MahjongTile.Souzu4, MahjongTile.Souzu5},
            new[] {MahjongTile.Souzu4, MahjongTile.Souzu5, MahjongTile.Souzu6},
            new[] {MahjongTile.Souzu5, MahjongTile.Souzu6, MahjongTile.Souzu7},
            new[] {MahjongTile.Souzu6, MahjongTile.Souzu7, MahjongTile.Souzu8},
            new[] {MahjongTile.Souzu7, MahjongTile.Souzu8, MahjongTile.Souzu9},

            new[] {MahjongTile.Pinzu1, MahjongTile.Pinzu2, MahjongTile.Pinzu3},
            new[] {MahjongTile.Pinzu2, MahjongTile.Pinzu3, MahjongTile.Pinzu4},
            new[] {MahjongTile.Pinzu3, MahjongTile.Pinzu4, MahjongTile.Pinzu5},
            new[] {MahjongTile.Pinzu4, MahjongTile.Pinzu5, MahjongTile.Pinzu6},
            new[] {MahjongTile.Pinzu5, MahjongTile.Pinzu6, MahjongTile.Pinzu7},
            new[] {MahjongTile.Pinzu6, MahjongTile.Pinzu7, MahjongTile.Pinzu8},
            new[] {MahjongTile.Pinzu7, MahjongTile.Pinzu8, MahjongTile.Pinzu9},
        };

        public Sequence(IReadOnlyList<MahjongTile> tiles, int startIndex, bool open = false) : base(tiles, startIndex, open)
        {
            if (tiles.Count != 3
                || tiles.Any(x => x.IsHonor())
                || tiles.GroupBy(x => x.GetSuit()).Count() != 1
                || !IsValidSequence(tiles)
            )
            {
                throw new InvalidGroupException(this);
            }
        }

        public static bool IsValidSequence(IReadOnlyList<MahjongTile> tiles)
        {
            var sortedTiles = tiles.OrderBy(x => x).ToList();

            return ValidSequences.Any(s => s.SequenceEqual(sortedTiles));
        }
    }
}
