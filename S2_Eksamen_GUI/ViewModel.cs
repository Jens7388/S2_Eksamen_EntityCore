using S2_Eksamen_DataAccess;

using S2_Eksamen_Entities;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace S2_Eksamen_GUI
{
    public class ViewModel
    {
        public ViewModel()
        {
            NorthwindContext context = new NorthwindContext();
            OrderRepository repository = new OrderRepository(context);
            IEnumerable<Order> orders = repository.GetAll();
            Orders = new ObservableCollection<Order>(orders);

        }
        public ObservableCollection<Order> Orders { get; set; }
        public Order SelectedOrder { get; set; }
        public ICollection<OrderDetails> SelectedOrderDetails { get; set; }
    }
}
