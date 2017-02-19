using Application1.Data;
using Application1.Service.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace Application1.WebApi.Controllers
{
    public class ProductController : ApiController
    {
        private IProductService productService = new ProductService();

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return productService.GetProducts();
        }

        [HttpGet]
        public IHttpActionResult GetProduct(int id)
        {
            var product = productService.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public IHttpActionResult Post(Product product)
        {
            var isSaved = productService.SaveProduct(product);
            if (isSaved == true)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut]
        public IHttpActionResult Put(Product product)
        {
            var isUpdated = productService.UpdateProduct(product.Id, product);

            if (isUpdated == true)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var isDeleted = productService.DeleteProduct(id);
            if (isDeleted == true)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
