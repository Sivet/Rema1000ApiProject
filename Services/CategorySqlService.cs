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
        private static List<Category> _mockDb = new List<Category>();

        public CategorySqlService(Rema1000Context context){
            _context = context;
        }

        public Category Create(Category category)
        {
            _mockDb.Add(category);
            return category;
        }
        public Category Read(Guid id)
        {
            throw new NotImplementedException();
        }
        public List<Category> Read(){
            return _mockDb;
        }
        public bool Update(Guid id, Category category)
        {
            for(int i = 0; i <= _mockDb.Count(); i++){
                if(_mockDb[i].CategoryID == id){
                    _mockDb[i] = category;
                    return true;
                }
            }
            return false;
        }
        public bool Delete(Guid id)
        {
            for(int i = 0; i <= _mockDb.Count(); i++){
                if(_mockDb[i].CategoryID == id){
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