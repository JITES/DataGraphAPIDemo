using DataGrapiApi.DataLayer.MongoDB;
using DataGrapiApi.DataLayer.MongoDB.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGrapiApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LiveFeedController : ControllerBase
    {
        private readonly LiveFeedRepository _liveRepo;
        public LiveFeedController(LiveFeedRepository liveFeedRepository)
        {
            _liveRepo = liveFeedRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<LiveFeedsModel>> Get()
        {
            return _liveRepo.Get();
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, LiveFeedsModel objModel)
        {
            var liveFeed = _liveRepo.Get(id);

            if (liveFeed == null)
            {
                return NotFound();
            }

            _liveRepo.Update(id, objModel);

            return NoContent();
        }
    }
}
