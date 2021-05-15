using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rema1000ApiProject.Models;
using Rema1000ApiProject.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Rema1000ApiProject.Services{
    public class ProductSqlService : IService<Product>{
        private readonly Rema1000Context _context;

        public ProductSqlService(Rema1000Context context){
            _context = context;
        }

        public void Create(Product item)
        {
            throw new NotImplementedException();
        }
        public void Update(Guid id, Product item)
        {
            throw new NotImplementedException();
        }
        public Product Read(Guid id)
        {
            Product myObject = new Product();
            myObject.ProductID = id;
            myObject.ProductName = "Test String";
            myObject.ProductDescription = "Test Description";
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