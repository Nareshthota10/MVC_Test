using MVC_Test.Models;
using MVC_Test.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC_Test.Controllers
{
    public class OffersController : ApiController
    {
        private IOffersService _offerService;
        public OffersController(OfferService offerSerice)
        {
            _offerService = offerSerice;
        }
        public async IHttpActionResult GetTodaysOffer()
        {
            List<Offers> offers=new List<Offers>()
               offers = await _offerService.GetTodaysOffers();
            return  _offerService.GetTodaysOffers();
        }
    }
}
