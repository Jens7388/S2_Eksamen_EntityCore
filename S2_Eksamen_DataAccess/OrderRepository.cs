using Microsoft.EntityFrameworkCore;
using S2_Eksamen_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace S2_Eksamen_DataAccess
{
    public class OrderRepository: RepositoryBase<Order>
    {
        public OrderRepository(NorthwindContext context) : base(context)
        {

        }
        public OrderRepository() : base() { }
        public override IEnumerable<Order> GetAll()
        {
            IEnumerable<Order> orders = context.Orders.Include("OrderDetails");
            return orders;
        }
        public override void Update(Order order)
        {
            context.SaveChanges();
        }
    }
}
