using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiichiCalc.Core.Hand;

namespace RiichiCalc.Core.Pattern
{
    class Patterns
    {
        private static readonly IPattern[] SimplePatterns =
        {
            new YakuhaiPattern(),
            new TanyaoPattern(),
            new IipeekoPattern(),
            new ToitoiPattern(),
            new SanshokuPattern(),
            new SandoukouPattern(),
            new IttsuPattern(),
            new ChantaPattern(),
            new SanankouPattern(),
            new HonroutouPattern(),
            new ChitoitsuPattern(),
            new ShousangenPattern(),
            new HonitsuPattern(),
            new RyanpeekoPattern(),
            new JunchanPattern(),
            new ChinitsuPattern(),
        };

        private static readonly IPattern[] YakumanPatterns =
        {
            new RyuuiisouYakumanPattern(),
            new SuuankouYakumanPattern(),
            new ChinroutouYakumanPattern(),
            new ChuurenPoutouYakumanPattern(),
            new TsuuiisouYakumanPattern(),
            new DaisangenYakumanPattern(),
            new KokushumusouYakumanPattern(),
            new ShousuushiYakumanPattern(),
            new DaisuushiYakumanPattern()
        };

        public static (uint points, IEnumerable<IPattern> matched) MatchPatterns(TableContext ctx, ParsedHand hand)
        {
            uint pts = 0;
            List<IPattern> matched = new();

            foreach (var yakumanPattern in YakumanPatterns)
            {
                if (yakumanPattern.Matches(ctx, hand) > 0)
                { 
                    var newPts = hand.IsOpened
                        ? yakumanPattern.BigPointsOpenHanded()
                        : yakumanPattern.BigPoints();

                    if (newPts != 0)
                    {
                        matched.Add(yakumanPattern);
                        pts += newPts;
                    }
                }
            }

            if (pts > 0)
            {
                return (pts, matched);
            }

            foreach (var simplePattern in SimplePatterns)
            {
                var matchCount = simplePattern.Matches(ctx, hand);
                if (matchCount > 0)
                { 
                    var newPts = hand.IsOpened
                        ? simplePattern.BigPointsOpenHanded()
                        : simplePattern.BigPoints();

                    if (newPts != 0)
                    {
                        for (int i = 0; i < matchCount; i++)
                        {
                            matched.Add(simplePattern);
                            pts += newPts;
                        }
                    }
                }
            }

            return (pts, matched);
        }
    }
}
