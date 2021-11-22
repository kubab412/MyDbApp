using Microsoft.AspNetCore.Mvc;
using MyDbApp.Domain;

namespace MyDbApp.Controllers
{
    [ApiController]
    [Route("wear")]
    public class WearController : ControllerBase
    {
        private readonly IWearManager _wearManager;
        public WearController(IWearManager wearManager)
        {
            _wearManager = wearManager;
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(WearDto wearDto)
        {
            _wearManager.Add(wearDto);
            return Ok(wearDto);
        }
        [HttpGet]
        [Route("show")]
        public IActionResult ShowAll()
        {
            var result = _wearManager.GetAll();
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public IActionResult Remove([FromBody] int id)
        {
            _wearManager.Remove(id);
            return Ok(id);
        }
        [HttpPut]
        [Route("edit")]
        public IActionResult edit(WearDto wear)
        {
            var result = _wearManager.Edit(wear);
            return Ok(result);
        }
    }
}
