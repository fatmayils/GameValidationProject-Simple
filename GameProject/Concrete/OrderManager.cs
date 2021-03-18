using GameProject.Abstract;
using GameProject.Entities;
using System;

namespace GameProject
{
     class OrderManager : IOrderService
    {
       

        public void Order(Gamer gamer, Game game)
        {
            Console.WriteLine("Satın alma başarılı: " + game.GameName + " Tutar: " + game.GamePrice + "TL  Keyifli oyunlar " + gamer.FirstName + "!");

        }

        public void OrderWithCampaign(Gamer gamer, Game game, Campaign campaign)
        {
            double orderPrice = game.GamePrice - (game.GamePrice * (campaign.Discount / 100));
            Console.WriteLine("Tebrikler " + campaign.CampaignName + " kampanyasından yararlandınız. Ödenecek Tutar: " + orderPrice + " TL");
        }
    }
}