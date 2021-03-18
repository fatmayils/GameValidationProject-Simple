using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager:IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game was added: " + game.GameName);
        }
        public void Delete(Game game)
        {
            Console.WriteLine("Game was deleted: " + game.GameName);
        }
        public void List(List<Game> games)
        {
            Console.WriteLine("Game was listed.");
            foreach (var game in games)
            {
                Console.WriteLine(game.GameName);
            }
        }
        public void Update(Game game)
        {
            Console.WriteLine("Game was updated: " + game.GameName);
        }
    }
}
