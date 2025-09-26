using System;
using System.Collections.Generic;

namespace SnakesAndLadders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snakes and Ladders Game - Console Application");

            
            var snakes = new Dictionary<int, int>
            {
                { 97, 78 },
                { 95, 56 },
                { 88, 24 },
                { 62, 18 },
                { 48, 26 },
                { 36, 6 },
                { 32, 10 }
            };

            var ladders = new Dictionary<int, int>
            {
                { 88, 99 },
                { 71, 92 },
                { 50, 67 },
                { 28, 76 },
                { 21, 42 },
                { 8, 10 },
                { 4, 14 },
                { 1, 38 }
            };

            var board = new Board(snakes, ladders);
            var players = new List<Player>
            {
                new Player("Player 1"),
                new Player("Player 2")
            };

            var engine = new GameEngine(board, players);

            string diceRollsP1 = "34512354612456";
            string diceRollsP2 = "65123412334514";

            var errors = new List<string>();
            errors.AddRange(ValidateDiceRolls(diceRollsP1, "Player 1"));
            errors.AddRange(ValidateDiceRolls(diceRollsP2, "Player 2"));

            if (errors.Count > 0)
            {
                
                foreach (var err in errors)
                {
                    Console.WriteLine(err);
                }
                return; 
            }

            
            engine.Play(diceRollsP1, diceRollsP2);

            Console.WriteLine($"Final Position: {players[0].Name} - {players[0].Position}");
            Console.WriteLine($"Final Position: {players[1].Name} - {players[1].Position}");
        }

        
        public static List<string> ValidateDiceRolls(string diceRolls, string playerName)
        {
            var errors = new List<string>();

            foreach (char roll in diceRolls)
            {
                if (!char.IsDigit(roll) || roll == '0' || roll > '6')
                {
                    errors.Add(
                        $"Invalid dice roll '{roll}' found for {playerName}. Rolls must be between 1 and 6.");
                }
            }

            return errors;
        }
    }
}
