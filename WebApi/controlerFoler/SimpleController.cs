﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.controlerFoler
{
    [Route("")]//api/[controller]")]
    [ApiController]
    public class SimpleController : ControllerBase
    {
        [HttpGet]
        public string getMethode()
        {
            return "hello brother";
        }
    }
}