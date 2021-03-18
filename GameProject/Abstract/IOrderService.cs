using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
      interface IOrderService
    {
        void Order(Gamer gamer, Game game);
        void OrderWithCampaign(Gamer gamer, Game game, Campaign campaing);
    }
}
