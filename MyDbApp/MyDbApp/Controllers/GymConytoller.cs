using Microsoft.AspNetCore.Mvc;
using MyDbApp.Domain;

namespace MyDbApp.Controllers
{
    [ApiController]
    [Route("gym")]
    public class GymConytoller : ControllerBase
    {
        private readonly IGymManager _gymManager;
        public GymConytoller(IGymManager gymManager)
        {
            _gymManager = gymManager;
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody]GymDto gymDto)
        {
            _gymManager.Add(gymDto);
            return Ok(gymDto);
        }
        [HttpGet]
        [Route("show")]
        public IActionResult ShowAll()
        {
          var result = _gymManager.GetAll();
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public IActionResult Remove([FromBody]int id)
        {
            _gymManager.Remove(id);
            return Ok(id);
        }
        [HttpPut]
        [Route("edit")]
        public IActionResult edit(GymDto gym)
        {
           var result = _gymManager.Edit(gym);
            return Ok(result);
        }
    }
}
