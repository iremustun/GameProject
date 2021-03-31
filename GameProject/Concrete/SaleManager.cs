using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class SaleManager : IEntity
    {
        public void Buy(Gamer gamer, Game game, Campaign campaign, Sale sale)
        {
            Console.WriteLine("The user named " + gamer.FirstName + " " + gamer.LastName + " took advantage of the " + campaign.CampaignName + " on " + sale.SaleDateTime + " and purchased the paid game for " + game.GamePrice + " dolar with a " + "%" + campaign.DiscountRate + " discount.");
        }
    }
}
