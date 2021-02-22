﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Common.Models;
using MISA.Service;

namespace MISA.DEMO.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvincesController : BaseEntityController<Province>
    {
        public ProvincesController(IBaseService<Province> baseService) : base(baseService)
        {

        }
    }
}