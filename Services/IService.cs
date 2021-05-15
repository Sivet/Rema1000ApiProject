using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rema1000ApiProject.Models;

namespace Rema1000ApiProject.Services{
    public interface IService<T>{
        bool SaveChanges();
        void Create(T item);
        T Read(Guid id);
        void Update(Guid id, T item);
        void Delete(Guid id);
    }
}