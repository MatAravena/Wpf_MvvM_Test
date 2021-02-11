using System;
using System.Collections.Generic;
using System.Text;

namespace BackTest.Models
{
    public class Account
    {
        public int id { get; set; }

        public User AcountHolder { get; set; }
        public double balance { get; set; }
        public IEnumerable<AssetTransaction> AssetTransactions { get; set; }

    }
}
