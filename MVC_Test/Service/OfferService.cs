using MVC_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Test.Service
{
    // private ProductList Inventory;
   
   
    public class OfferService: IOffersService
    {
        public OfferService()
        {

        }

        public List<Products> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public async List<Offers> GetTodaysOffers()
        {
            throw new await  NotImplementedException();
        }
        //private List<Products> CreateProducts()
        //{
        //    List<Products> Inventory = new List<Products>();
        //    Products product= new Products();
        //  product.Description=""

        //}
    }
}