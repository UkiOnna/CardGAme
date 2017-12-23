using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Game
    {
       public List<Card> Deck { get; set; }
        public List<Player> Player { get; set; }

        public Game()
        {
            Deck = new List<Card>();
            Player = new List<Player>();
        }

        public void ShufflingCards()
        {
            Random random = new Random();
            for (int i = Deck.Count - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                var temp = Deck[j];
                Deck[j] = Deck[i];
                Deck[i] = temp;
            }
        }

        public void SetCardsPlayer()
        {
            for(int i = 0; i < 18; i++)
            {
                Player[0].Cards.Enqueue(Deck[i]);
            }
            for (int i = 18; i < 36; i++)
            {
                Player[1].Cards.Enqueue(Deck[i]);
            }


        }

    }
}
