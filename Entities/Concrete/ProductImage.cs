﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ProductImage : IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string? ImagePath { get; set; }
        public DateTime Date { get; set; }

        public ProductImage()
        {
            Date = DateTime.Now;
        }
    }
}
