using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepAPI.NorthwindWebApi;

namespace WepAPI.Controllers
{
    public class SuppliersController : Controller
    {
        NorthwindApiService _northwindApiService;

        public SuppliersController(NorthwindApiService northwindApiService)
        {
            this._northwindApiService = northwindApiService;
        }

        [HttpGet]
        public Task<IEnumerable<Supplier>> Get()
        {
            var result = _northwindApiService.GetEntities<Supplier>();
            return result;
        }
    }
}
