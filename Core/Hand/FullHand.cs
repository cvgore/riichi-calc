using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiichiCalc.Core.Pattern;
using RiichiCalc.Core.States;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Hand
{
    class FullHand
    {
        private readonly List<MahjongTile> _tiles;
        public ParsedHand ParsedHand { get; private set; }
        public uint BigPoints { get; private set; }
        public uint SmallPoints { get; private set; }
        public List<IPattern> MatchedPatterns { get; private set; }

        private readonly List<Group> _preGroups;

        public FullHand(IReadOnlyList<MahjongTile> tiles, IReadOnlyList<Group>? preGroups)
        {
            _tiles = tiles.ToList();
            _preGroups = _preGroups = preGroups != null ? preGroups.ToList() : new();

            ParseHand();
        }

        private void ParseHand()
        {
            ParsedHand = new(_tiles, _preGroups);
        }

        public void Calculate(TableContext ctx)
        {
            var (bigPoints, matchedPatterns) = Patterns.MatchPatterns(ctx, ParsedHand);

            BigPoints = bigPoints;
            MatchedPatterns = matchedPatterns.ToList();
        }
    }
}
