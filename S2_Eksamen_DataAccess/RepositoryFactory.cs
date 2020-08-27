using S2_Eksamen_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace S2_Eksamen_DataAccess
{
    public class RepositoryFactory<TRepository, TEntity>
    where TEntity : class
    where TRepository : IRepositoryBase<TEntity>, new()
    {
        private static RepositoryFactory<TRepository, TEntity> instance;
        protected NorthwindContext northwindContext;

        private RepositoryFactory() { }

        public static RepositoryFactory<TRepository, TEntity> GetInstance()
            => instance is null ? new RepositoryFactory<TRepository, TEntity>() : instance;

        public virtual TRepository Create()
        {
            if(northwindContext is null)
            {
                northwindContext = new NorthwindContext();
            }

            TRepository repo = new TRepository();
            repo.NorthwindContext = northwindContext;
            return repo;
        }
        public virtual void KillContext() => northwindContext.Dispose();
    }

    class Test
    {
        void M()
        {
            RepositoryFactory<OrderRepository, Order> factory = RepositoryFactory<OrderRepository, Order>.GetInstance();
            OrderRepository repo = factory.Create();
            factory.KillContext();
        }
    }
}