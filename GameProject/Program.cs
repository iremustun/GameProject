using System;
using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game
            Game game = new Game();
            game.Id = 1;
            game.GameName = "Battlefield";
            game.GamePrice = 180;

            Game game2 = new Game();
            game.Id = 2;
            game.GameName = "Pummel Party";
            game.GamePrice = 26;

            GameManager gameManager = new GameManager();
            gameManager.Add(game);


            //Campaign
            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.CampaignName = "Cyber Monday";
            campaign.DiscountRate = 35;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign, game);


            //Gamer
            Gamer gamer = new Gamer();
            gamer.Id = 1;
            gamer.FirstName = "İrem";
            gamer.LastName = "Üstün";
            gamer.NationalityId = "1234567890";
            gamer.DateOfBirth = new DateTime(1998, 2, 4);

            Gamer gamer2 = new Gamer();
            gamer2.Id = 2;
            gamer2.FirstName = "Ayşegül";
            gamer2.LastName = "Üstün";
            gamer2.NationalityId = "9087654321";
            gamer2.DateOfBirth = new DateTime(1991, 10, 4);


            GamerManager gamerManager = new GamerManager(new GamerValidationManager());
            gamerManager.Save(gamer);
            gamerManager.Update(gamer2);

           



            //Sales
            Sale sale = new Sale();
            sale.SaleId = 1;
            sale.SaleDateTime = DateTime.Now;
            SaleManager saleManager = new SaleManager();
            saleManager.Buy(gamer, game, campaign, sale);
        }
            
    }
}
