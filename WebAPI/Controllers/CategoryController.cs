using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            if (result.Success) // sonuç başarılıysa
            {
                return Ok(result); /* site çalışma statüsü 200 OK olarak dönücek ve datayı göstericek -- parantez içine her türlü şey koyulabilir veya yazılabilir 
                                           eger boş bırakılırsa işlem başarılı - işlem tamalandı - başarılı gibi mesajlar gösterir */
            }
            return BadRequest(result); // site çalışma statüsü 400 bad request olarak dönücek
        }
    }
}
