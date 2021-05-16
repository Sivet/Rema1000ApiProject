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
    public class CategoriesController : ControllerBase{
        IService<Category> _service;
        ICategoryRead<Category> _categoryReadService;
        public CategoriesController(IService<Category> service, ICategoryRead<Category> categoryReadService){
            _service = service;
            _categoryReadService = categoryReadService;
        }

        ///<summary>Gets the information on Categories</summary>
        ///<returns>Returns a collection of all Categories</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetCategories(){
            return Ok(_service.Read());
        }
        ///<summary>Gets the children of a Category, if given 0'ed (00000000-0000-0000-0000-000000000000) Guid will find top parents</summary>
        ///<returns>Returns a collection of Categories</returns>
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Category>> GetChildCategories(Guid id){
            return Ok(_categoryReadService.ReadByCatogry(id));
        }
        /// <summary>This POST method creates a new Category </summary>
        /// <returns>returns the created Category on success </returns>
        [HttpPost]
        public ActionResult<Category> AddNewCategory(Category category){
            return Ok(_service.Create(category));
        }
        ///<summary> This PUT method updates the Category with the given id </summary>
        /// <returns>returns true on success </returns>
        [HttpPut("{id}")]
        public ActionResult UpdateCategory(Guid id, Category category){
            if(!_service.Update(id, category)) return NotFound();
            return NoContent();
        }
        /// <summary> This DELETE method deletes the product with the given id </summary>
        /// <returns>returns true on success </returns>
        [HttpDelete("{id}")]
        public ActionResult DeleteCategory(Guid id){
            if(!_service.Delete(id)) return NotFound();
            return NoContent();
        }
    }
}