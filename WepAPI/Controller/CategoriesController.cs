using Business.Abstrack;
using Business.Abstrack.IProductServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryServices _categoryServices;
        public CategoriesController(ICategoryServices categoryServices)
        {
            _categoryServices= categoryServices;
        }

        [HttpGet("getall")]
        public IActionResult GetList()

        {
            var result = _categoryServices.GetList();
            if (result.Success)
            {
                return Ok(result.Data);

            }
            return BadRequest(result.Message);
        }
    }



}

