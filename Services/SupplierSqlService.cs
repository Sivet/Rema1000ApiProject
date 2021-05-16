using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rema1000ApiProject.Models;
using Rema1000ApiProject.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Rema1000ApiProject.Services{
    public class SupplierSqlService : IService<Supplier>{
        private readonly Rema1000Context _context;
        private static List<Supplier> _mockDb = new List<Supplier>();

        public SupplierSqlService(Rema1000Context context){
            _context = context;
        }

        public Supplier Create(Supplier item)
        {
            _mockDb.Add(item);
            return item;
        }
        public Supplier Read(Guid id)
        {
            foreach(Supplier item in _mockDb){
                if(item.SupplierID == id){
                    return item;
                }
            }
            return new Supplier();
        }
        public List<Supplier> Read(){
            return _mockDb;
        }
        public bool Update(Guid id, Supplier supplier)
        {
            for(int i = 0; i <= _mockDb.Count(); i++){
                if(_mockDb[i].SupplierID == id){
                    _mockDb[i] = supplier;
                    return true;
                }
            }
            return false;
        }
        public bool Delete(Guid id)
        {
            for(int i = 0; i <= _mockDb.Count(); i++){
                if(_mockDb[i].SupplierID == id){
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