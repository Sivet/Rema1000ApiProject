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
    public class SuppliersController : ControllerBase{
        IService<Supplier> _service;
        public SuppliersController(IService<Supplier> service){
            _service = service;
        }

        ///<summary>Gets the information on the Supplier of a given name</summary>
        ///<returns>Returns a json representation of a Supplier</returns>
        [HttpGet("{id}")]
        public ActionResult<Supplier> GetSupplier(Guid id){
            //throw new NotImplementedException();
            return Ok(_service.Read(id));
        }
        ///<summary>Gets the all Suppliers</summary>
        ///<returns>Returns a collection of all Suppliers</returns>
        [HttpGet()]
        public ActionResult<IEnumerable<Supplier>> GetSuppliers(){
            //throw new NotImplementedException();
            return Ok(_service.Read());
        }
        /// <summary> This POST method IS NOT YET IMPLEMENTED </summary>
        /// <returns>returns IS NOT YET IMPLEMENTED </returns>
        [HttpPost]
        public ActionResult<Supplier> AddNewSupplier(Supplier supplier)
        {
            //throw new NotImplementedException();
            return Ok(_service.Create(supplier));
        }
        ///<summary> This PUT method IS NOT YET IMPLEMENTED </summary>
        /// <returns>returns IS NOT YET IMPLEMENTED </returns>
        [HttpPut("{id}")]
        public ActionResult UpdateSupplier(Guid id, Supplier supplier)
        {
            //throw new NotImplementedException();
            if(!_service.Update(id, supplier)) return NotFound();
            return NoContent();
        }

        /// <summary> This DELETE method IS NOT YET IMPLEMENTED </summary>
        /// <returns>returns IS NOT YET IMPLEMENTED </returns>
        [HttpDelete("{id}")]
        public ActionResult DeleteSupplier(Guid id)
        {
            //throw new NotImplementedException();
            if(!_service.Delete(id)) return NotFound();
            return NoContent();
        }
    }
}