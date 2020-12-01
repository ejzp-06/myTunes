using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myTunes.Infrastructure;
using myTunes.Core.Entities;


namespace myTunes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CategoryDto>> Get()
        {
            var serviceResult = _categoryService.GetCategories();
            if (serviceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(serviceResult.Error);

            return Ok(serviceResult.Result.Select(x => new CategoryDto
            {
                Description = x.Description,
                Id = x.Id
            }));
        }

        [HttpGet]
        [Route("{categoryId}/products")]
        public ActionResult<IEnumerable<ProductDto>> Get(int categoryId)
        {
            var serviceResult = _categoryService.GetProductsByCategory(categoryId);
            if (serviceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(serviceResult.Error);

            var products = serviceResult.Result;
            return Ok(products.Select(p => new ProductDto
            {
                Id = p.Id,
                BrandName = p.Brand.Name,
                Name = p.Name,
                Stock = p.Stock,
                CategoryName = p.Category.Description,
                Price = p.Price
            }));
        }
    }
}
