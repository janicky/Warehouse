using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;

namespace Warehouse {
    public partial class DataService {

        private DataRepository repository;

        public DataService(DataRepository repository) {
            repository.GetAllOrders().CollectionChanged += HandleOrdersChange;
            repository.GetAllProductCopies().CollectionChanged += HandleProductCopiesChange;
            this.repository = repository;
        }

        public IEnumerable<Order> GetOrdersForEmployee(Employee employee) {
            return repository.GetAllOrders().Where(e => e.GetEmployee() == employee);
        }

        public IEnumerable<Order> GetOrdersBetweenDates(DateTimeOffset from, DateTimeOffset to) {
            return repository.GetAllOrders().Where(e => e.GetOrderDate() >= from && e.GetOrderDate() <= to);
        }

        private void HandleOrdersChange(object sender, NotifyCollectionChangedEventArgs e) {
            Console.WriteLine("Orders list was changed!");
            if (e.NewItems != null) {
                Console.WriteLine(string.Format("|- Orders added: {0}", e.NewItems.Count));
                foreach (Order order in e.NewItems) {
                    Console.WriteLine(string.Format("|-- {0}", order));
                }
            }
            if (e.OldItems != null) {
                Console.WriteLine(string.Format("|- Orders removed: {0}", e.OldItems.Count));
                foreach (Order order in e.OldItems) {
                    Console.WriteLine(string.Format("|-- {0}", order));
                }
            }
        }

        private void HandleProductCopiesChange(object sender, NotifyCollectionChangedEventArgs e) {
            Console.WriteLine("Orders list was changed!");
            if (e.NewItems != null) {
                Console.WriteLine(string.Format("|- Orders added: {0}", e.NewItems.Count));
                foreach (ProductCopy productCopy in e.NewItems) {
                    Console.WriteLine(string.Format("|-- {0}", productCopy));
                }
            }
            if (e.OldItems != null) {
                Console.WriteLine(string.Format("|- Orders removed: {0}", e.OldItems.Count));
                foreach (ProductCopy productCopy in e.OldItems) {
                    Console.WriteLine(string.Format("|-- {0}", productCopy));
                }
            }
        }
    }
}