using S2_Eksamen_DataAccess;

using S2_Eksamen_Entities;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace S2_Eksamen_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        private ViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            await Task.Run(() => viewModel = new ViewModel());
            DataContext = viewModel;
            Header.Header = "All Orders:";
        }

        private async void ButtonAddOrder_Click(object sender, RoutedEventArgs e)
        {/*
            List<OrderDetails> orderDetails = new List<OrderDetails>();
            try
            {
                int.TryParse(comboBoxEmployeeID.Text, out int employeeID);
                int.TryParse(comboBoxShipVia.Text, out int shipVia);
                decimal.TryParse(textBoxFreight.Text, out decimal freight);
                Order order = new Order(1, comboBoxCustomerID.Text, employeeID, datePickerOrderDate.SelectedDate.Value.Date,
                    datePickerOrderDate.SelectedDate.Value.Date, datePickerOrderDate.SelectedDate.Value.Date, shipVia, freight,
                    textBoxShipName.Text, textBoxShipAddress.Text, textBoxShipCity.Text, textBoxShipRegion.Text, textBoxShipPostalCode.Text,
                    textBoxShipCountry.Text, orderDetails);

                Repository repository = new Repository();
                await repository.InsertOrderAsync(order);
                viewModel.Orders.Add(order);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private async void OrderSelectionChanged(object sender, SelectionChangedEventArgs e)
        {/*
            await GetComboBoxItems();
            comboBoxOrderID.SelectedItem = null;
            textBoxProductID.Text = null;
            textBoxUnitPrice.Text = null;
            textBoxQuantity.Text = null;
            textBoxDiscount.Text = null;

            viewModel.SelectedOrderDetails = viewModel.SelectedOrder.OrderDetails;
            foreach(OrderDetails orderDetails in viewModel.SelectedOrderDetails)
            {
                comboBoxOrderID.SelectedItem = orderDetails.OrderId;
                textBoxProductID.Text += $"{orderDetails.ProductId}\n";
                textBoxUnitPrice.Text += $"{orderDetails.UnitPrice}\n";
                textBoxQuantity.Text += $"{orderDetails.Quantity}\n";
                textBoxDiscount.Text += $"{orderDetails.Discount}\n";
            }*/
        }

        
        private async void ButtonAddOrderDetails_Click(object sender, RoutedEventArgs e)
        {/*
            List<OrderDetails> orderDetails = new List<OrderDetails>();
            string[] productIDArray = textBoxProductID.Text.Split("\n");
            string[] unitPriceArray = textBoxUnitPrice.Text.Split("\n");
            string[] quantityArray = textBoxQuantity.Text.Split("\n");
            string[] discountArray = textBoxDiscount.Text.Split("\n");

            try
            {
                for(int i = 0; i < productIDArray.Length; i++)
                {
                    int.TryParse(comboBoxOrderID.Text, out int orderID);
                    int.TryParse(productIDArray[i], out int productID);
                    decimal.TryParse(unitPriceArray[i], out decimal unitPrice);
                    int.TryParse(quantityArray[i], out int quantity);
                    float.TryParse(discountArray[i], out float discount);

                    if(productID != 0 && unitPrice != 0 && quantity != 0 && discount != 0)
                    {
                        OrderDetails orderDetail = new OrderDetails(orderID, productID, unitPrice,
                        quantity, discount);
                        orderDetails.Add(orderDetail);
                    }
                }
                Repository repository = new Repository();
                await repository.InsertOrderDetailsAsync(orderDetails);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private async Task GetComboBoxItems()
        {/*
            for(int i = 0; i < viewModel.Orders.Count; i++)
            {
                comboBoxOrderID.Items.Add(await Task.Run(() => viewModel.Orders[i].OrderID));
            }
            for(int i = 0; i < viewModel.Orders.Count; i++)
            {
                comboBoxCustomerID.Items.Add(await Task.Run(() => viewModel.Orders[i].CustomerID));
            }
            for(int i = 0; i < 10; i++)
            {
                comboBoxEmployeeID.Items.Add(i);
            }
            for(int i = 200; i < 212; i++)
            {
                comboBoxEmployeeID.Items.Add(i);
            }
            for(int i = 0; i < 4; i++)
            {
                comboBoxShipVia.Items.Add(i);
            }*/
        }

        private async void ButtonSaveOrderEdit_Click(object sender, RoutedEventArgs e)
        {/*
            try
            {
                Repository repository = new Repository();
                await repository.UpdateOrderAsync(viewModel.SelectedOrder);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private async void ButtonSaveOrderDetailEdit_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(() => throw new NotImplementedException());
        }
    }
}
