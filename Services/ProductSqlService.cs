using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rema1000ApiProject.Models;
using Rema1000ApiProject.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Rema1000ApiProject.Services{
    public class ProductSqlService : IService<Product>, IProduct{
        private readonly Rema1000Context _context;
        private static List<Product> _mockDb = new List<Product>();

        public ProductSqlService(Rema1000Context context){
            _context = context;
        }
        public Product Create(Product item)
        {
            _mockDb.Add(item);
            return item;
        }
        public Product Read(Guid id)
        {
            foreach(Product item in _mockDb){
                if(item.ProductID == id){
                    return item;
                }
            }
            return new Product();
        }
        public List<Product> Read(string categoryName){
            List<Product> temp = new List<Product>();
            foreach(Product item in _mockDb){
                if(item.ProductCategory.CategoryName == categoryName){
                    temp.Add(item);
                }
            }
            return temp;
        }
        public List<Product> Read(){
            return _mockDb;
        }
        public bool Update(Guid id, Product product)
        {
            for(int i = 0; i <= _mockDb.Count(); i++){
                if(_mockDb[i].ProductID == id){
                    _mockDb[i] = product;
                    return true;
                }
            }
            return false;
        }
        public bool Delete(Guid id)
        {
            for(int i = 0; i <= _mockDb.Count(); i++){
                if(_mockDb[i].ProductID == id){
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