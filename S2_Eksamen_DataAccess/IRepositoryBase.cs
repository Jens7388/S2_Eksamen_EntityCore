using S2_Eksamen_Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace S2_Eksamen_DataAccess
{
    public interface IRepositoryBase<T>
    {
        IEnumerable<T> GetAll();
        T GetBy(int id);
        //IEnumerable<T> Get(Predicate<T> predicate);
        void Update(T t);
        void Add(T t);
        void Delete(T t);
        NorthwindContext NorthwindContext { get; set; }
    }
}
