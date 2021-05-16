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
    public class CategoriesController : ControllerBase{
        IService<Category> _service;
        public CategoriesController(IService<Category> service){
            _service = service;
        }

        ///<summary>Gets the information on the Category of a given name</summary>
        ///<returns>Returns a json representation of a Category</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetCategories(){
            //throw new NotImplementedException();
            return Ok(_service.Read());
        }
        /// <summary> This POST method IS NOT YET IMPLEMENTED </summary>
        /// <returns>returns IS NOT YET IMPLEMENTED </returns>
        [HttpPost]
        public ActionResult<Category> AddNewCategory(Category category)
        {
            //throw new NotImplementedException();
            return Ok(_service.Create(category));
        }
        ///<summary> This PUT method IS NOT YET IMPLEMENTED </summary>
        /// <returns>returns IS NOT YET IMPLEMENTED </returns>
        [HttpPut("{id}")]
        public ActionResult UpdateCategory(Guid id, Category category)
        {
            //throw new NotImplementedException();
            if(!_service.Update(id, category)) return NotFound();
            return NoContent();
        }

        /// <summary> This DELETE method IS NOT YET IMPLEMENTED </summary>
        /// <returns>returns IS NOT YET IMPLEMENTED </returns>
        [HttpDelete("{id}")]
        public ActionResult DeleteCategory(Guid id)
        {
            //throw new NotImplementedException();
            if(!_service.Delete(id)) return NotFound();
            return NoContent();
        }
    }
}