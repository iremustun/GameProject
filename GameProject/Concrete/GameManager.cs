using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " was added.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " was deleted.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " was updated.");
        }
        

    }

}
