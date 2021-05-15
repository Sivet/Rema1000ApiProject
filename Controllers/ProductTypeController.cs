using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rema1000ApiProject.Models;
using Rema1000ApiProject.Services;

namespace Rema1000ApiProject.Controllers{
    ///<summary>Controller responsible for handling Categories and their subdivision ProductTypes</summary>
    [ApiController]
    [Route("api/[controller]")]
    //[Route("[action]")]
    public class ProductTypesController : ControllerBase{
        IService<ProductType> _service;
        public ProductTypesController(IService<ProductType> service){
            _service = service;
        }
        ///<summary>Gets the information on the Category of a given name</summary>
        ///<returns>Returns a json representation of a Category</returns>
        [HttpGet]
        public IEnumerable<ProductType> GetProductTypes(){
            throw new NotImplementedException();
        }
        /// <summary> This POST method IS NOT YET IMPLEMENTED </summary>
        /// <returns>returns IS NOT YET IMPLEMENTED </returns>
        [HttpPost]
        public ProductType AddNewProductType(ProductType productType)
        {
            /*_service.CreateMakerSpace(createDto);
            //Check if valid
            return Created($"api/MakerSpaces", null);//CreatedAtRoute(nameof(GetMakerSpaceById), new { Id = makerSpaceReadDto.Id }, makerSpaceReadDto);*/
            throw new NotImplementedException();
        }
        ///<summary> This PUT method IS NOT YET IMPLEMENTED </summary>
        /// <returns>returns IS NOT YET IMPLEMENTED </returns>
        [HttpPut("{id}")]
        public ActionResult UpdateProductType(Guid id, ProductType productType)
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
        public ActionResult DeleteProductType(Guid id)
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