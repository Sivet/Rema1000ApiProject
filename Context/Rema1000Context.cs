using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rema1000ApiProject.Models;


namespace Rema1000ApiProject.Context{
    public class Rema1000Context : DbContext{
        public Rema1000Context(DbContextOptions<Rema1000Context> options) : base(options){
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<MeasurementUnit> MeasurementUnits { get; set; }
        public DbSet<ContactPerson> ContactPeople { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}