using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agile.Bowling
{
    public class Scorer
    {
        private readonly int[] _throws = new int[21];
        private int _currentThrow;

        private int _ball;
        private bool Strike => _throws[_ball] == 10;
        private bool Spare => _throws[_ball] + _throws[_ball + 1] == 10;
        private int NextTwoBallsForStrike => _throws[_ball + 1] + _throws[_ball + 2];
        private int NextBallForSpare => _throws[_ball + 2];
        private int TwoBallsInFrame => _throws[_ball] + _throws[_ball + 1];

        public void AddThrow(int pins)
        {
            _throws[_currentThrow++] = pins;
        }

        public int ScoreForFrame(int theFrame)
        {
            _ball = 0;
            var score = 0;
            for (var currentFrame = 0; currentFrame < theFrame; currentFrame++)
            {
                if (Strike)
                {
                    score += 10 + NextTwoBallsForStrike;
                    _ball += 1;
                }
                else if (Spare)
                {
                    score += 10 + NextBallForSpare;
                    _ball += 2;
                }
                else
                {
                    score += TwoBallsInFrame;
                    _ball += 2;

                }
            }
            return score;
        }
    }
}
