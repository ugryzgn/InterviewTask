using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepAPI.NorthwindWebApi;

namespace WepAPI.Controllers
{
    public class ShippersController : Controller
    {
        NorthwindApiService _northwindApiService;

        public ShippersController(NorthwindApiService northwindApiService)
        {
            this._northwindApiService = northwindApiService;
        }

        [HttpGet]
        public Task<IEnumerable<Shipper>> Get()
        {
            var result = _northwindApiService.GetEntities<Shipper>();
            return result;
        }
    }
}
