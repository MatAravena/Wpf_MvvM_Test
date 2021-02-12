using System;
using System.Collections.Generic;
using System.Text;

namespace BackTest.Models
{
    public class User : DomainObject
    {
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
