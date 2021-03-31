using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface IGamerValidationService
    {
        void Validation(IGamerService gamer);
    }
}
