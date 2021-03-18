using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
   public class Game
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string Kind { get; set; }
        public double GamePrice { get; set; }

        public static implicit operator Game(Gamer v)
        {
            throw new NotImplementedException();
        }
    }
}
