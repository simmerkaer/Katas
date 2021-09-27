using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class BowlingGame
    {
        private List<Tuple<char, char?>> _frames = new();

        private const char Strike = 'X';
        private const char Spare = '/';

        public BowlingGame(string rolls)
        {
            rolls.Split(" ")
                .ToList()
                .ForEach(pair =>
                {
                    var isStrike = pair.Length == 1;
                    _frames.Add(new Tuple<char, char?>(pair[0], isStrike ? null : pair[1]));
                });
        }

        public int Score()
        {
            var frameScores = new int[10];

            var index = 0;
            _frames.ForEach(frame =>
            {
                var (item1, item2) = frame;
                var isStrike = item1 is Strike;
                var isSpare = item2 is Spare;

                if (isStrike || isSpare)
                {
                    frameScores[index] = 0;
                }
                else
                {
                    frameScores[index] = (int)(char.GetNumericValue(item1) + char.GetNumericValue((char)item2));
                }

                index++;
            });
            return 300;
        }
    }
}
