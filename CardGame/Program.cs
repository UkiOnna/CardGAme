using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Player player1 = new Player();
            Player player2 = new Player();
            player1.Name = "Игрок 1";
            player2.Name = "Игрок 2";

            game.Player.Add(player1);
            game.Player.Add(player2);
            List<Card> Deck = new List<Card>(36);



            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 9; j++)
                {
                    Card card = new Card();
                    card.Suit = (Suit)i;
                    card.Type = (Type)j;
                    game.Deck.Add(card);
                }

            }


            game.ShufflingCards();
            game.SetCardsPlayer();
            Card cardPlayer1 = new Card();
            Card cardPlayer2 = new Card();

            bool isGameOver = false;
            while (!isGameOver)
            {

                Console.WriteLine("Первый игрок достает карту {0} {1}", game.Player[0].Cards.Peek().Type, game.Player[0].Cards.Peek().Suit);
                Console.ReadLine();
                Console.WriteLine("Второй игрок достает карту {0} {1}", game.Player[1].Cards.Peek().Type, game.Player[1].Cards.Peek().Suit);
                Console.ReadLine();
                cardPlayer1 = game.Player[0].Cards.Dequeue();
                cardPlayer2 = game.Player[1].Cards.Dequeue();

                if (cardPlayer1.Type > cardPlayer2.Type)
                {
                    game.Player[0].Cards.Enqueue(cardPlayer1);

                    Console.WriteLine("Игрок 1 забирает карты");
                    Console.ReadLine();
                }
                else if (cardPlayer1.Type < cardPlayer2.Type)
                {

                    game.Player[1].Cards.Enqueue(cardPlayer2);
                    Console.WriteLine("Игрок 2 забирает карты");
                    Console.ReadLine();
                }
                else
                {
                    game.Player[0].Cards.Enqueue(cardPlayer1);


                    Console.WriteLine("Игрок 1 забирает карты");
                    Console.ReadLine();
                }

                if (game.Player[0].Cards.Count == 0)
                {
                    Console.WriteLine("Игрок 2 Победил!");
                    Console.ReadLine();
                    isGameOver = true;
                }
                else if (game.Player[1].Cards.Count == 0)
                {
                    Console.WriteLine("Игрок 1 Победил!");
                    Console.ReadLine();
                    isGameOver = true;
                }
            }

            Console.WriteLine("Игра окончена!!");
            Console.ReadLine();
        }
    }
}
