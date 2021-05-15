using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rema1000ApiProject.Models;
using Rema1000ApiProject.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Rema1000ApiProject.Services{
    public class ProductSqlService : IService{
        private readonly Rema1000Context _context;

        public ProductSqlService(Rema1000Context context){
            _context = context;
        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}