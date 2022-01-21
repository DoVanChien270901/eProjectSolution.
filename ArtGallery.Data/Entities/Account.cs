﻿using ArtGallery.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.Data.Entities
{
    public class Account
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public Roleposition Roles { get; set; }
        public ProfileUser ProfileUser { get; set; }
        public List<FeedBack> FeedBacks { get; set; }
        public List<AmountInAuction> AmountInAcctions { get; set; }
        public List<Product> Products { get; set; }
        public List<Auction> Auctions { get; set; }
    }
}
