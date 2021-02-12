using System;
using System.Collections.Generic;
using System.Text;

namespace BackTest.Models
{
    public class AssetTransaction : DomainObject
    {
        public Account account { get; set; }
        public bool isPurchase { get; set; }
        public Stock stock { get; set; }
        public int sharesAmount { get; set; }
        public DateTime dateProcessed { get; set; }
    }
}
