using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;

namespace GameProject.Entities
{
    public class Sale:IEntity
    {
        public int SaleId { get; set; }
        public DateTime SaleDateTime { get; set; }

    }
}
