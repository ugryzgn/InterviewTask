using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepAPI.NorthwindWebApi;

namespace WepAPI.Controllers
{
    public class EmployeesController : Controller
    {
        NorthwindApiService _northwindApiService;

        public EmployeesController(NorthwindApiService northwindApiService)
        {
            this._northwindApiService = northwindApiService;
        }

        [HttpGet]
        public Task<IEnumerable<Employee>> Get()
        {
            var result = _northwindApiService.GetEntities<Employee>();
            return result;
        }
    }
}
