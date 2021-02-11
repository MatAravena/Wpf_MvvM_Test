using System;
using System.Collections.Generic;
using System.Text;

namespace BackTest.Models
{
    public class AssetTransaction
    {
        public int id { get; set; }
        public Account account { get; set; }
        public bool isPurchase { get; set; }
        public Stock stock { get; set; }
        public int sharesAmount { get; set; }
    }
}
