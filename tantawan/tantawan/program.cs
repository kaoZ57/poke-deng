using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tan.card;

namespace tantawan
{
    class program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Deck deck = new Deck();
            Pokedeng gamePlay = new Pokedeng("dealer", deck);
            Player mook = new Player("mook");
            gamePlay.AddPlayer(mook);
            gamePlay.AddPlayer(new Player("Tan"));
            gamePlay.AddPlayer(new Player("Ton"));
            gamePlay.Play();

            

        }
    }
}
