using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepAPI.NorthwindWebApi;

namespace WepAPI.Controllers
{
    public class OrdersController : Controller
    {
        NorthwindApiService _northwindApiService;

        public OrdersController(NorthwindApiService northwindApiService)
        {
            this._northwindApiService = northwindApiService;
        }

        [HttpGet]
        public Task<IEnumerable<Order>> Get()
        {
            var result = _northwindApiService.GetEntities<Order>();
            return result;
        }
    }
}
