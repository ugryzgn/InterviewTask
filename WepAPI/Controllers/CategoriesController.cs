using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepAPI.NorthwindWebApi;

namespace WepAPI.Controllers
{
    public class CategoriesController : Controller
    {
        NorthwindApiService _northwindApiService;

        public CategoriesController(NorthwindApiService northwindApiService)
        {
            this._northwindApiService = northwindApiService;
        }

        [HttpGet]
        public Task<IEnumerable<Category>> Get()
        {
            var result = _northwindApiService.GetEntities<Category>();
            return result;
        }
    }
}
