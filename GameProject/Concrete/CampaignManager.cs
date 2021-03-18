using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        List<Campaign> _campaigns;
        public CampaignManager()
        {

        }
        public void Add(Campaign campaign)
        {
            _campaigns.Add(campaign);
            Console.WriteLine("Campaign was added: " + campaign.CampaignName);
        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign was deleted: " + campaign.CampaignName);
        }
        public void List()
        {
            Console.WriteLine("Campaigns was listed.");
            foreach (var campaign in _campaigns)
            {
                Console.WriteLine(campaign.CampaignName);
            }
        }
        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign was updated: " + campaign.CampaignName);
        }
    }
}
