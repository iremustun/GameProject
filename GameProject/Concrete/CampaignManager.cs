using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign, Game game)
        {
            Console.WriteLine("The game named " + game.GameName + " was included in " + campaign.CampaignName + " and a " + "%" + campaign.DiscountRate + " discount was applied.");
        }

        public void Delete(Campaign campaign, Game game)
        {
            Console.WriteLine(campaign.CampaignName + " was ended and " +  campaign.DiscountRate + "%" + "discount rate in the game named " + game.GameName + " has been canceled.");
        }

        public void Update(Campaign campaign, Game game)
        {
            Console.WriteLine("The discount rate in the game called " + game.GameName + " which is included in the " + campaign.CampaignName + " has been updated to " + "%" + campaign.DiscountRate); 
        }
    }
}
