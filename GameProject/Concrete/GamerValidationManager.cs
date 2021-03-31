using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;


namespace GameProject.Concrete
{
    public class GamerValidationManager : IEntity
    {
       

        public bool Validation(GamerManager gamer)
        {
            if (gamer.Id == "1" && gamer.FirstName == "İrem" && gamer.LastName == "Üstün" && gamer.NationalityId == "1234567890" && gamer.DateOfBirth == new DateTime(1998, 2, 4))
            {
                return true;
            }

            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
