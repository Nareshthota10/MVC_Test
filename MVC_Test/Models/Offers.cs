using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Test.Models
{
    public class Offers
    {
        public string OffersName { get; set; }
        public List<Products> Products { get; set; }
    }
}