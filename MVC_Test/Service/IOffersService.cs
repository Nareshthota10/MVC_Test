using MVC_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Test.Service
{
    interface IOffersService
    {
        List<Offers> GetTodaysOffers();
        List<Products> GetAllProducts();
    }
}
