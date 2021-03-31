using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerValidationService _gamerValidationService;
        public GamerManager(IGamerValidationService gamerValidationService)
        {
            _gamerValidationService = gamerValidationService;
        }

        public GamerManager(GamerValidationManager gamerValidationManager)
        {

        }

        public string Id { get; internal set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string NationalityId { get; internal set; }
        public DateTime DateOfBirth { get; internal set; }


        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " was deleted.");
        }

        public void Save(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " was saved.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " was updated.");
        }
    }
}
