using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rema1000ApiProject.Models;
using Rema1000ApiProject.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Rema1000ApiProject.Services{
    public class CategorySqlService : IService<Category>{
        private readonly Rema1000Context _context;

        public CategorySqlService(Rema1000Context context){
            _context = context;
        }

        public void Create(Category item)
        {
            throw new NotImplementedException();
        }
        public void Update(Guid id, Category item)
        {
            throw new NotImplementedException();
        }
        public Category Read(Guid id)
        {
            Category myObject = new Category();
            myObject.CategoryID = id;
            myObject.CategoryName = "Test String";
            myObject.CategoryDescription = "Test Description";
            return myObject;
        }
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}