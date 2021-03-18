using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SteamGamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public SteamGamerManager()
        {
        }

        public SteamGamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
     
        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.Validate(gamer) == true)
            {
                Console.WriteLine("Player Added : " + gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Player validation error. ");
            }
        }

        public void Delete(Gamer player)
        {

        }

        public void Update(Gamer player)
        {

        }

        internal void Add(Game gamer1)
        {
            throw new NotImplementedException();
        }
    }
}
