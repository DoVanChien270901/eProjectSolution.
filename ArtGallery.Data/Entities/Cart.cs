﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.Data.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string AccountId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public Account Account { get; set; }
        public List<ProductInCart> ProductInCarts { get; set; }
    }
}
