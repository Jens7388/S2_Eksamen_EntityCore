using S2_Eksamen_DataAccess;

using S2_Eksamen_Entities;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace S2_Eksamen_GUI
{
    public class ViewModel
    {
        public ViewModel()
        {
            
        }
        public ObservableCollection<Order> Orders { get; set; }
        public Order SelectedOrder { get; set; }
        public ICollection<OrderDetails> SelectedOrderDetails { get; set; }

        public virtual async Task InitializeAsync()
        {
            await Task.Run(() =>
            {
                RepositoryFactory<OrderRepository, Order> factory = RepositoryFactory<OrderRepository, Order>.GetInstance();
                OrderRepository repo = factory.Create();

                IEnumerable<Order> orders = repo.GetAll();
                Orders = new ObservableCollection<Order>(orders);
            });
        }
    }
}