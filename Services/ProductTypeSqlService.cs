using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rema1000ApiProject.Models;
using Rema1000ApiProject.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Rema1000ApiProject.Services{
    public class ProductTypeSqlService : IService<ProductType>{
        private readonly Rema1000Context _context;

        public ProductTypeSqlService(Rema1000Context context){
            _context = context;
        }

        public void Create(ProductType item)
        {
            throw new NotImplementedException();
        }
        public void Update(Guid id, ProductType item)
        {
            throw new NotImplementedException();
        }
        public ProductType Read(Guid id)
        {
            ProductType myObject = new ProductType();
            myObject.ProductTypeID = id;
            myObject.ProductTypeName = "Test String";
            myObject.ProductTypeDescription = "Test Description";
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