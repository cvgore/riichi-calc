using System.Collections.Generic;
using System.Linq;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Hand
{
    internal class CalculatedHand
    {
        public List<Group> Groups { get; init; }
        public uint BigPoints { get; init; }
        public uint SmallPoints { get; init; }

        public CalculatedHand(IReadOnlyList<MahjongTile> tiles)
        {
            Groups = new();

            ParseTiles(tiles);
        }

        private void ParseTiles(IReadOnlyList<MahjongTile> tiles)
        {
            var sortedTiles = tiles.OrderBy(x => x).ToList();

            // We'll manually advance cursor
            for (int i = 0; i < tiles.Count - 1;)
            {
                // (tileCurrent, tileNext)
                var (tileC, tileN) = (tiles[i], tiles[i + 1]);

                // At least we've got pair
                if (tileC == tileN)
                {
                    // Definitely pair (out of range next index)
                    if (i + 2 >= tiles.Count)
                    {
                        Groups.Add(new Pair(new []{ tileC, tileN}));
                        i += 2;
                    }
                    // Got a triple?
                    else if (tileC == tiles[i + 2])
                    {
                        Groups.Add(new Triple(new []{ tileC, tileN, tiles[i+2]}));
                        i += 3;
                    }
                    // Nah, only pair - what a pity
                    else
                    {
                        i += 2;
                        Groups.Add(new Pair(new []{ tileC, tileN}));
                    }
                }
                // Definitely not pair or triple, maybe a sequence?
                else
                {
                    // Definitely not a sequence if tile is a dragon or wind
                    if (tileC.IsDragon() || tileC.IsWind())
                    {
                        i += 1;
                    }
                    // Checking if both (current & next) tiles have same suit
                    else if (tileC.GetSuit() != tileN.GetSuit())
                    {
                        i += 1;
                    }
                    // Check if third index will be in bounds
                    else if (i + 2 >= tiles.Count)
                    {
                        i += 1;
                    }
                    // Finally, check if valid
                    else if (Sequence.IsValidSequence(new[] {tileC, tileN, tiles[i + 2]}))
                    {
                        Groups.Add(new Triple(new []{ tileC, tileN, tiles[i+2]}));
                    }

                    i += 1;
                }
            }
        }
    }
}