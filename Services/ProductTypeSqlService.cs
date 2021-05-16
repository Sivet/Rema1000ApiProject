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
        private static List<ProductType> _mockDb = new List<ProductType>();

        public ProductTypeSqlService(Rema1000Context context){
            _context = context;
        }

        public ProductType Create(ProductType productType)
        {
            _mockDb.Add(productType);
            return productType;
        }
        public ProductType Read(Guid id)
        {
            throw new NotImplementedException();
        }
        public List<ProductType> Read(){
            return _mockDb;
        }
        public bool Update(Guid id, ProductType productType)
        {
            for(int i = 0; i <= _mockDb.Count(); i++){
                if(_mockDb[i].ProductTypeID == id){
                    _mockDb[i] = productType;
                    return true;
                }
            }
            return false;
        }
        public bool Delete(Guid id)
        {
            for(int i = 0; i <= _mockDb.Count(); i++){
                if(_mockDb[i].ProductTypeID == id){
                    _mockDb.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}