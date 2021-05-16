using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rema1000ApiProject.Models;
using Rema1000ApiProject.Services;

namespace Rema1000ApiProject.Controllers{
    ///<summary>Controller responsible for handling products </summary>
    [ApiController]
    [Route("api/[controller]")]
    //[Route("[action]")]
    public class ProductsController : ControllerBase{
        IService<Product> _service;
        IProduct _productService;
        public ProductsController(IService<Product> service, IProduct productService){
            _service = service;
            _productService = productService;
        }

        ///<summary>Gets the information on the product of a given name</summary>
        ///<returns>Returns a json representation of a Product</returns>
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(Guid id){
            //throw new NotImplementedException();
            return Ok(_service.Read(id));
        }
        ///<summary>Gets the all products of the given ProductType</summary>
        ///<returns>Returns a collection of Products</returns>
        [HttpGet("category/{type}")]
        public ActionResult<IEnumerable<Product>> GetProductsByCategory(string categoryName){
            //throw new NotImplementedException();
            return Ok(_productService.Read(categoryName));
        }
        /// <summary> This POST method creates a new Product </summary>
        /// <returns>returns the created product on success </returns>
        [HttpPost]
        public ActionResult<Product> AddNewProduct(Product product)
        {
            //throw new NotImplementedException();
            return Ok(_service.Create(product));
        }
        ///<summary> This PUT method updates the product with the given id </summary>
        /// <returns>returns true on success </returns>
        [HttpPut("{id}")]
        public ActionResult UpdateProduct(Guid id, Product product)
        {
            //throw new NotImplementedException();
            if(!_service.Update(id, product)) return NotFound();
            return NoContent();
        }
        /// <summary> This DELETE method deletes the product with the given id </summary>
        /// <returns>returns true on success </returns>
        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(Guid id)
        {
            //throw new NotImplementedException();
            if(!_service.Delete(id)) return NotFound();
            return NoContent();
        }
    }
}