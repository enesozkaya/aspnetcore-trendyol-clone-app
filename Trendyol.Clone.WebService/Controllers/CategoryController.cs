using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trendyol.Clone.Bussiness.Abstract;
using Trendyol.Clone.Entities.Concrete;

namespace Trendyol.Clone.WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        
        [HttpGet(template: "GetAll")]
        public ActionResult GetAll()
        {
            var category = _categoryService.GetList();
            return Ok(category);
        }
       
        [HttpGet]
        [Route("add")]
        public ActionResult Add([FromBody] Category category)
        {
            _categoryService.Add(category);
            return Ok(category);
        }
    }
}
