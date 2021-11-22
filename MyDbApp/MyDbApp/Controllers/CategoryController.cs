using Microsoft.AspNetCore.Mvc;
using MyDbApp.Domain;
using System.Collections.Generic;

namespace MyDbApp.Controllers
{
    [ApiController]
    [Route("category")]
    public class CategoryController : ControllerBase
    {
        public List<CategoryDto> categories => new List<CategoryDto>
        {
            new CategoryDto
            {
                Id = 1,
                Name = "gym"
            },
            new CategoryDto
            {
                Id=2,
                Name = "run"
            },
            new CategoryDto
            {
                Id=3,
                Name = "swim"
            },
            new CategoryDto
            {
                Id=4,
                Name = "wear"
            }
        };
        [HttpGet]
        [Route("show")]
        public IActionResult GetAll()
        {
            var result = categories;
            return Ok(categories);
        }
    }
}
