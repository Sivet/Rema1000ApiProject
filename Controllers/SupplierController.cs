using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rema1000ApiProject.Models;
using Rema1000ApiProject.Services;

namespace Rema1000ApiProject.Controllers{
    ///<summary>Controller responsible for handling Suppliers </summary>
    [ApiController]
    [Route("api/[controller]")]
    //[Route("[action]")]
    public class SupplierController : ControllerBase{
        IService<Supplier> _service;
        public SupplierController(IService<Supplier> service){
            _service = service;
        }

        ///<summary>Gets the information on the Supplier of a given name</summary>
        ///<returns>Returns a json representation of a Supplier</returns>
        [HttpGet]
        public Supplier GetSupplier(Guid id){
            throw new NotImplementedException();
        }
        /// <summary> This POST method IS NOT YET IMPLEMENTED </summary>
        /// <returns>returns IS NOT YET IMPLEMENTED </returns>
        [HttpPost]
        public Supplier AddNewSupplier(Supplier supplier)
        {
            /*_service.CreateMakerSpace(createDto);
            //Check if valid
            return Created($"api/MakerSpaces", null);//CreatedAtRoute(nameof(GetMakerSpaceById), new { Id = makerSpaceReadDto.Id }, makerSpaceReadDto);*/
            throw new NotImplementedException();
        }
        ///<summary> This PUT method IS NOT YET IMPLEMENTED </summary>
        /// <returns>returns IS NOT YET IMPLEMENTED </returns>
        [HttpPut("{id}")]
        public ActionResult UpdateSupplier(Guid id, Supplier supplier)
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
        public ActionResult DeleteSupplier(Guid id)
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