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
            return Ok(_service.Read(id));
        }
        ///<summary>Gets the all Suppliers</summary>
        ///<returns>Returns a collection of all Suppliers</returns>
        [HttpGet()]
        public ActionResult<IEnumerable<Supplier>> GetSuppliers(){
            return Ok(_service.Read());
        }
        /// <summary>This POST method creates a new Supplier </summary>
        /// <returns>returns the created Supplier on success </returns>
        [HttpPost]
        public ActionResult<Supplier> AddNewSupplier(Supplier supplier){
            return Ok(_service.Create(supplier));
        }
        ///<summary>This PUT method updates the Supplier with the given id </summary>
        /// <returns>returns true on success </returns>
        [HttpPut("{id}")]
        public ActionResult UpdateSupplier(Guid id, Supplier supplier){
            if(!_service.Update(id, supplier)) return NotFound();
            return NoContent();
        }

        /// <summary>This DELETE method deletes the Supplier with the given id </summary>
        /// <returns>returns true on success </returns>
        [HttpDelete("{id}")]
        public ActionResult DeleteSupplier(Guid id){
            if(!_service.Delete(id)) return NotFound();
            return NoContent();
        }
    }
}