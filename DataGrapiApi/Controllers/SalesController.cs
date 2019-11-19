using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DataGrapiApi.Controllers
{
    [Route("api/[controller]")]
    public class SalesController : Controller
    {

        [HttpGet]
        public async Task<IActionResult> Get(string year)
        {
            //var values = await _context.Values.FirstOrDefaultAsync(x => x.Year == year);
            return Ok();
        }
    }
}
