using Microsoft.EntityFrameworkCore;

using S2_Eksamen_Entities;

using System;
using System.Collections.Generic;
using System.Linq;

namespace S2_Eksamen_DataAccess
{
    public class RepositoryBase<T>: IRepositoryBase<T> where T : class
    {
        protected NorthwindContext context;

        public RepositoryBase(NorthwindContext context)
        {
            Context = context;
        }

        public virtual NorthwindContext Context
        {
            get
            {
                return context;
            }

            set
            {
                context = value;
            }
        }

        public void Add(T t)
        {
            context.Set<T>().Add(t);
            context.SaveChanges();
        }

        public void Delete(T t)
        {
            context.Set<T>().Remove(t);
            context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>();
        }

        public virtual T GetBy(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Update(T t)
        {
            context.SaveChanges();
        }

        IEnumerable<T> IRepositoryBase<T>.GetAll()
        {
            throw new NotImplementedException();
        }
    }

    public class OrderRepository: RepositoryBase<Order>
    {
        public OrderRepository(NorthwindContext context) : base(context)
        {

        }
        public override Order GetBy(int id)
        {
            var a = context.Orders.Where(o => o.OrderId == id).Include("OrderDetails").FirstOrDefault();
            var b = context.Orders.AsQueryable().Include("OrderDetails")
                .FirstOrDefault(o => o.OrderId == id);
            return b;
        }
    }
}
