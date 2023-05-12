using Microsoft.AspNetCore.Mvc;
using Amazon.DynamoDBv2.DataModel;
using TodoApi.Models;
using AutoMapper;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetHealth()
        {
            return Ok();
        }
    }
}
