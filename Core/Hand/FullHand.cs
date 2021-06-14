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

        public FullHand(IReadOnlyList<MahjongTile> tiles)
        {
            _tiles = tiles.ToList();
            ParseHand();
        }

        private void ParseHand()
        {
            ParsedHand = new(_tiles);
        }

        public void Calculate(TableContext ctx)
        {
            var (bigPoints, matchedPatterns) = Patterns.MatchPatterns(ctx, ParsedHand);

            BigPoints = bigPoints;
            MatchedPatterns = matchedPatterns.ToList();
        }
    }
}
