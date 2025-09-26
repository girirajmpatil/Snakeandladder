namespace SnakesAndLadders
{
    public class Player
    {
        public string Name { get; }
        public int Position { get; private set; }

        public Player(string name)
        {
            Name = name;
            Position = 0;
        }

        public void Move(int steps, Board board)
        {
            int newPos = Position + steps;
            if (newPos > 100) return; 
            Position = board.GetNewPosition(newPos);
        }
    }
}
