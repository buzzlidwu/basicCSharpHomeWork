using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using riderTestWebApi.Service;
using riderTestWebApi.Uilts;

namespace riderTestWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GeoIpController : ControllerBase
    {
        private readonly IGeoIpService _geoIpService;

        public GeoIpController(IGeoIpService geoIpService)
        {
            _geoIpService = geoIpService;
        }

        [HttpGet,ServiceFilter(typeof(LogFilter))]
        public async Task<IActionResult> Get()
        {
            var currentIp = await _geoIpService.GetCurrentIpAsync();
            return Ok(new { ip = currentIp});
        }
        
    }
}