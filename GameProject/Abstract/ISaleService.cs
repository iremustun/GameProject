using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface ISaleService
    {
        void Buy(Gamer gamer, Game game, Campaign campaign, Sale sale);
        void Return(Gamer gamer, Game game, Campaign campaign, Sale sale);

    }
}
