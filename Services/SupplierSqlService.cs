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

        public SupplierSqlService(Rema1000Context context){
            _context = context;
        }

        public void Create(Supplier item)
        {
            throw new NotImplementedException();
        }
        public void Update(Guid id, Supplier item)
        {
            throw new NotImplementedException();
        }
        public Supplier Read(Guid id)
        {
            Supplier myObject = new Supplier();
            myObject.SupplierID = id;
            myObject.SupplierName = "Test String";
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