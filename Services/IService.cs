using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rema1000ApiProject.Models;

namespace Rema1000ApiProject.Services{
    public interface IService<T>{
        bool SaveChanges();
        T Create(T item);
        T Read(Guid id);
        List<T> Read();
        bool Update(Guid id, T item);
        bool Delete(Guid id);
    }
}