﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string? CarName { get; set; }
        public float DailyPrice { get; set; }
        public DateTime ModelYear { get; set; }
        public string? Description { get; set; }
        public Brand Brand { get; set; } 
        public Color Color { get; set; }
        public  ICollection<Rental> Rentals { get; set; }

    }
}
