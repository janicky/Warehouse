using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Model;

namespace Warehouse {
    public partial class DataRepository {
        // CRUD methods for Orders in this partial class
        public void AddOrder(Order order) {
            dataContext.orders.Add(order);
        }

        public Order GetOrderByIndex(int index) {
            try {
                return dataContext.orders.ElementAt(index);
            } catch (Exception) {
                return null;
            }
        }

        public Order GetOrderById(int id) {
            try {
                return dataContext.orders.First(e => e.GetId() == id);
            }
            catch (Exception) {
                return null;
            }
        }

        public ObservableCollection<Order> GetAllOrders() {
            return dataContext.orders;
        }

        public void UpdateOrder(Order order) {
            Order updatingOrder = GetOrderById(order.GetId());
            if (updatingOrder != null) {
                updatingOrder.SetPrice(order.GetPrice());
                updatingOrder.SetCount(order.GetCount());
            }
        }

        public bool DeleteOrder(Order order) {
            try {
                return dataContext.orders.Remove(order);
            } catch(Exception) {
                return false;
            }
        }
    }
}
