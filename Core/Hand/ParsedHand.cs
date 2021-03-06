using System.Collections.Generic;
using System.Linq;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Hand
{
    internal class ParsedHand
    {
        public List<Group> Groups { get; }
        public List<MahjongTile> Tiles { get; }
        public MahjongTile LastTile { get; }
        public bool IsRegularCompleteHand { get; }

        public bool IsOpened { get; }

        public ParsedHand(IReadOnlyList<MahjongTile> tiles, IReadOnlyList<Group>? preGroups)
        {
            LastTile = tiles.Last();

            if (preGroups != null)
            {
                Queue<MahjongTile> skipTilesQueue =
                    new(preGroups.SelectMany(x => x.Tiles).OrderBy(x => x));

                Groups = preGroups.ToList();
                Tiles = tiles.OrderBy(x => x).Where(x => skipTilesQueue.Count == 0 || x == skipTilesQueue.Dequeue())
                    .ToList();

                IsOpened = Groups.Any(x => x.Open);
            }
            else
            {
                Groups = new();
                Tiles = tiles.OrderBy(x => x).ToList();
            }

            ParseTiles();

            IsRegularCompleteHand = Groups.Count(x => x is Sequence || x is Triple || x is Quadruple) == 4
                                    && Groups.Any(x => x is Pair);
        }

        private void ParseTiles()
        {
            // We'll manually advance cursor
            for (int i = 0; i < Tiles.Count - 1;)
            {
                // (tileCurrent, tileNext)
                var (tileC, tileN) = (Tiles[i], Tiles[i + 1]);

                // At least we've got pair
                if (tileC == tileN)
                {
                    // Definitely pair (out of range next index)
                    if (i + 2 >= Tiles.Count)
                    {
                        Groups.Add(new Pair(new[] {tileC, tileN}, i));
                        i += 2;
                    }
                    // Got a triple/quadruple?
                    else if (tileC == Tiles[i + 2])
                    {
                        if (i + 3 > Tiles.Count && tileC == Tiles[i + 3])
                        {
                            Groups.Add(new Quadruple(new[] {tileC, tileN, Tiles[i + 2], Tiles[i + 3]}, i));
                            i += 4;
                        }
                        else
                        {
                            Groups.Add(new Triple(new[] {tileC, tileN, Tiles[i + 2]}, i));
                            i += 3;
                        }
                    }
                    // Nah, only pair - what a pity
                    else
                    {
                        i += 2;
                        Groups.Add(new Pair(new[] {tileC, tileN}, i));
                    }
                }
                // Definitely not pair or triple, maybe a sequence?
                else
                {
                    // Definitely not a sequence if tile is a dragon or wind
                    if (tileC.IsDragon() || tileC.IsWind())
                    {
                        i += 1;

                        continue;
                    }

                    // Checking if both (current & next) tiles have same suit
                    if (tileC.GetSuit() != tileN.GetSuit())
                    {
                        i += 1;

                        continue;
                    }

                    // Check if third index will be in bounds
                    if (i + 2 >= Tiles.Count)
                    {
                        i += 1;

                        continue;
                    }

                    // Finally, check if valid
                    if (Sequence.IsValidSequence(new[] {tileC, tileN, Tiles[i + 2]}))
                    {
                        Groups.Add(new Sequence(new[] {tileC, tileN, Tiles[i + 2]}, i));
                        i += 3;

                        continue;
                    }

                    i += 1;
                }
            }
        }
    }
}