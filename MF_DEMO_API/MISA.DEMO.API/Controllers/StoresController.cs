using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Common.Models;
using MISA.Service;
using MISA.Service.Interfaces;

namespace MISA.DEMO.API.Controllers
{
    public class StoresController : BaseEntityController<Store>
    {
        IStoreService _baseService;
        public StoresController(IStoreService baseService) : base(baseService)
        {
            _baseService = baseService;
        }
        [HttpGet("filter/{a}&{b}")]
        public IActionResult Get(String a, String b)
        {
            var filter = new
            {
                StoreCode = a,
                StoreName = b,
                Address = "",
                PhoneNumber = "",
                Status = ""

            };
            var stores = _baseService.GetFilter(filter);
            return Ok(stores);
        }
    }
}
