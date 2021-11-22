using Microsoft.AspNetCore.Mvc;
using MyDbApp.Domain;

namespace MyDbApp.Controllers
{
    [ApiController]
    [Route("swim")]
    public class SwimController : ControllerBase
    {
        private readonly ISwimManager _swimManager;
        public SwimController(ISwimManager swimManager)
        {
            _swimManager = swimManager;
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody] SwimDto swimDto)
        {
            _swimManager.Add(swimDto);
            return Ok(swimDto);
        }
        [HttpGet]
        [Route("show")]
        public IActionResult ShowAll()
        {
            var result = _swimManager.GetAll();
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            _swimManager.Remove(id);
            return Ok(id);
        }
        [HttpPut]
        [Route("edit")]
        public IActionResult edit(SwimDto swim)
        {
            var result = _swimManager.Edit(swim);
            return Ok(result);
        }
    }
}
