using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign1 = new Campaign() { CampaignId = 1, CampaignName = "Fırsat20", Discount = 20 };
            Campaign campaign2 = new Campaign() { CampaignId = 1, CampaignName = "Fırsat50", Discount = 50 };
         

            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign2);
            campaignManager.List();
            campaignManager.Update(campaign1);

            Gamer gamer = new Gamer()
            {
                NationalityId = 11111111111,
                GamerId = 1,
                FirstName = "Fatma Gül",
                LastName = "Yıldırım",
                Age = 19,
                UserName = "fatmikkkk",
                Mail = "aaaaaaaaa@gmail.com",
                Password = "123",
                BirthDate = new DateTime(2001, 11, 13)
            };
            SteamGamerManager steamGamerManager = new SteamGamerManager(new EDevletServiceAdaptor());
            steamGamerManager.Add(gamer);

            Game game1 = new Game() { GameId = 1, GameName = "Counter Strike-Global Offensive", Kind = "FPS", GamePrice = 100 };

            IOrderService orderManager = new OrderManager();

            orderManager.Order(gamer, game1);
            orderManager.OrderWithCampaign(gamer, game1, campaign1);
        }
    }
}
