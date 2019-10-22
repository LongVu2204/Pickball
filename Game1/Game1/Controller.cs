using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Controller
    {
        private Board Game;
        private Player P1, P2;

        public Controller()
        {
            P1 = new Player("Long");
            P2 = new Player("Nhii");
            Game = new Board(3, 5, 7);
        }

        public void PlayGame()
        {
            Game.PrintGame();
            while (true)
            {
                Console.WriteLine(P1.GetName() + " turn ");
                P1.Pickball(Game);
                Game.PrintGame();
                if (Game.IsGameOver())
                {
                    Console.WriteLine(P1.GetName() + " Loses ");
                    Console.WriteLine(P2.GetName() + " Wins ");
                    break;
                }
                Console.WriteLine(P2.GetName() + " a turn ");
                P2.Pickball(Game);
                if (Game.IsGameOver())
                {
                    Console.WriteLine(P2.GetName() + " Loses ");
                    Console.WriteLine(P1.GetName() + " Wins ");
                    break;
                }            
            }
        }
    }
}
