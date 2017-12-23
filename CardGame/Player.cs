using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Player
    {
        public string Name { get; set; }
       public Queue<Card> Cards { get; set; }

        public Player()
        {
            Cards = new Queue<Card>();
        }

    }
}
