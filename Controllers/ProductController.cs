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
    public class ProductController : ControllerBase{
        IService<Product> _service;
        public ProductController(IService<Product> service){
            _service = service;
        }

        ///<summary>Gets the information on the product of a given name</summary>
        ///<returns>Returns a json representation of a Product</returns>
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(Guid id){
            //throw new NotImplementedException();
            return Ok(_service.Read(id));
        }
        ///<summary>Gets the all products of a given type</summary>
        ///<returns>Returns a collection of all Products of the given type</returns>
        [HttpGet("type/{type}")]
        public IEnumerable<Product> GetProductsByType(ProductType type){
            throw new NotImplementedException();
        }
        /// <summary> This POST method IS NOT YET IMPLEMENTED </summary>
        /// <returns>returns IS NOT YET IMPLEMENTED </returns>
        [HttpPost]
        public Product AddNewProduct(Product product)
        {
            /*_service.CreateMakerSpace(createDto);
            //Check if valid
            return Created($"api/MakerSpaces", null);//CreatedAtRoute(nameof(GetMakerSpaceById), new { Id = makerSpaceReadDto.Id }, makerSpaceReadDto);*/
            throw new NotImplementedException();
        }
        ///<summary> This PUT method IS NOT YET IMPLEMENTED </summary>
        /// <returns>returns IS NOT YET IMPLEMENTED </returns>
        [HttpPut("{id}")]
        public ActionResult UpdateProduct(Guid id, Product product)
        {
            /*if (_service.UpdateMakerSpace(id, MakerSpaceCreateDto) == false)
            {
                return NotFound();
            }
            return NoContent();*/
            throw new NotImplementedException();
        }

        /// <summary> This DELETE method IS NOT YET IMPLEMENTED </summary>
        /// <returns>returns IS NOT YET IMPLEMENTED </returns>
        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(Guid id)
        {
            /*if (_service.DeleteMakerSpace(id) == false)
            {
                return NotFound();
            }
            return NoContent();*/
            throw new NotImplementedException();
        }
    }
}