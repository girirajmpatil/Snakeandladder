using System;
using System.Collections.Generic;

namespace SnakesAndLadders
{
    public class GameEngine
    {
        private readonly Board _board;
        private readonly List<Player> _players;

        public GameEngine(Board board, List<Player> players)
        {
            _board = board;
            _players = players;
        }

        public void Play(string diceRollsP1, string diceRollsP2)
        {
            var rolls1 = diceRollsP1.ToCharArray();
            var rolls2 = diceRollsP2.ToCharArray();
            int maxTurns = Math.Min(rolls1.Length, rolls2.Length);

            for (int i = 0; i < maxTurns; i++)
            {
                int rollP1 = int.Parse(rolls1[i].ToString());
                _players[0].Move(rollP1, _board);

                int rollP2 = int.Parse(rolls2[i].ToString());
                _players[1].Move(rollP2, _board);

                if (_players[0].Position == 100 || _players[1].Position == 100)
                    break;
            }
        }
    }
}
