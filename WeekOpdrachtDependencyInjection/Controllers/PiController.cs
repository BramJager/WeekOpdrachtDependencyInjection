﻿using Microsoft.AspNetCore.Mvc;
using WeekOpdrachtDependencyInjection.Business;
using WeekOpdrachtDependencyInjection.Business.Interfaces;

namespace WeekOpdrachtDependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PiController : ControllerBase
    {
        private readonly ICalculatePiService calculatePiService;

        public PiController(ICalculatePiService calculatePiService)
        {
            calculatePiService = new CalculatePiService();
        }

        [HttpGet]
        [Route("add/{number}")]
        public IActionResult Add(int number)
        {
            return Ok(new
            {
                result = (calculatePiService.Add(number))
            });
        }

        [HttpGet]
        [Route("minus/{number}")]
        public IActionResult Minus(int number)
        {
            return Ok(new
            {
                result = (calculatePiService.Minus(number))
            });
        }
    }
}
