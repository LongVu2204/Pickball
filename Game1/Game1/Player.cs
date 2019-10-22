using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Player
    {
        private string Name;

        public void Pickball(Board game)
        {
            Console.Write("Which group do you want to choose? : ");
            int group = int.Parse(Console.ReadLine());
            Console.Write("How many balls do you want to pick? : ");
            int balls = int.Parse(Console.ReadLine());
            game.Pickball(group, balls);
        }

        public Player(string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return this.Name;
        }

    }
}
