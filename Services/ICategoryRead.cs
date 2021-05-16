using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rema1000ApiProject.Models;

namespace Rema1000ApiProject.Services{
    public interface ICategoryRead<T>{
        List<T> ReadByCatogry(Guid categoryID);
    }
}