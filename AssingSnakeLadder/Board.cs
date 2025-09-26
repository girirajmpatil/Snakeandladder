using System.Collections.Generic;

namespace SnakesAndLadders
{
    public class Board
    {
        public Dictionary<int, int> Snakes { get; }
        public Dictionary<int, int> Ladders { get; }

        public Board(Dictionary<int, int> snakes, Dictionary<int, int> ladders)
        {
            Snakes = snakes;
            Ladders = ladders;
        }

        public int GetNewPosition(int position)
        {
            if (Snakes.ContainsKey(position))
                return Snakes[position];
            if (Ladders.ContainsKey(position))
                return Ladders[position];

            return position;
        }
    }
}
