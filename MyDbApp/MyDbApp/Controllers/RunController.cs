using Microsoft.AspNetCore.Mvc;
using MyDbApp.Domain;

namespace MyDbApp.Controllers
{
    [ApiController]
    [Route("run")]
    public class RunController : ControllerBase
    {
        private readonly IRunManager _runManager;
        public RunController(IRunManager runManager)
        {
            _runManager = runManager;
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody] RunDto runDto)
        {
            _runManager.Add(runDto);
            return Ok(runDto);
        }
        [HttpGet]
        [Route("show")]
        public IActionResult ShowAll()
        {
            var result = _runManager.GetAll();
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            _runManager.Remove(id);
            return Ok(id);
        }
        [HttpPut]
        [Route("edit")]
        public IActionResult Edit(RunDto run)
        {
            var result = _runManager.Edit(run);
            return Ok(result);
        }
    }
}
