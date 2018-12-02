using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class ConstantDataSource : IDataSource {
        private List<Employee> employees = new List<Employee>();
        private Dictionary<int, Product> products = new Dictionary<int, Product>();
        private ObservableCollection<ProductCopy> productCopies = new ObservableCollection<ProductCopy>();
        private ObservableCollection<Order> orders = new ObservableCollection<Order>();

        public ConstantDataSource() {
            FillEmployees();
            FillProducts();
            FillProductCopies();
            FillOrders();
        }

        // Data fill
        private void FillEmployees() {
            // Generated using Faker
            // Github: [https://github.com/stympy/faker]
            employees.Add(new Employee("General", "Hux"));
            employees.Add(new Employee("Wedge", "Antilles"));
            employees.Add(new Employee("Shmi", "Skywalker"));
            employees.Add(new Employee("Count", "Dooku"));
            employees.Add(new Employee("Lando", "Calrissian"));
            employees.Add(new Employee("Kylo", "Ren"));
            employees.Add(new Employee("Boba", "Fett"));
            employees.Add(new Employee("Jyn", "Erso"));
            employees.Add(new Employee("Borvo", "the"));
            employees.Add(new Employee("Lando", "Calrissian"));
            employees.Add(new Employee("Ben", "Solo"));
            employees.Add(new Employee("Asajj", "Ventress"));
            employees.Add(new Employee("Sheev", "Palpatine"));
            employees.Add(new Employee("Ezra", "Bridger"));
            employees.Add(new Employee("Han", "Solo"));
            employees.Add(new Employee("Padme", "Amidala"));
            employees.Add(new Employee("Rose", "Tico"));
            employees.Add(new Employee("Ki-Adi-Mundi", "Amidala"));
            employees.Add(new Employee("Darth", "Vader"));
        }

        private void FillProducts() {
            // Generated using Faker
            // Github: [https://github.com/stympy/faker]
            products.Add(0, new Product("The Wives of Bath", 26.03));
            products.Add(1, new Product("A Swiftly Tilting Planet", 78.07));
            products.Add(2, new Product("Butter In a Lordly Dish", 62.04));
            products.Add(3, new Product("Moab Is My Washpot", 86.03));
            products.Add(4, new Product("The Wings of the Dove", 92.02));
            products.Add(5, new Product("Things Fall Apart", 89.09));
            products.Add(6, new Product("Tirra Lirra by the River", 92.08));
            products.Add(7, new Product("An Acceptable Time", 37.03));
            products.Add(8, new Product("Time of our Darkness", 87.01));
            products.Add(9, new Product("Ring of Bright Water", 19.09));
            products.Add(10, new Product("Death Be Not Proud", 87.02));
            products.Add(11, new Product("Infinite Jest", 98.08));
            products.Add(12, new Product("All the King's Men", 28.05));
            products.Add(13, new Product("After Many a Summer Dies the Swan", 40.02));
            products.Add(14, new Product("His Dark Materials", 66.05));
            products.Add(15, new Product("As I Lay Dying", 54.07));
            products.Add(16, new Product("The Green Bay Tree", 91.02));
            products.Add(17, new Product("Cabbages and Kings", 57.05));
            products.Add(18, new Product("The Far-Distant Oxus", 18.08));
            products.Add(19, new Product("A Monstrous Regiment of Women", 59.09));
            products.Add(20, new Product("Taming a Sea Horse", 48.05));
            products.Add(21, new Product("Have His Carcase", 60.09));
            products.Add(22, new Product("The Wealth of Nations", 95.06));
            products.Add(23, new Product("Down to a Sunless Sea", 15.01));
            products.Add(24, new Product("Vile Bodies", 10.01));
            products.Add(25, new Product("No Country for Old Men", 24.02));
            products.Add(26, new Product("Edna O'Brien", 58.07));
            products.Add(27, new Product("The Painted Veil", 25.08));
            products.Add(28, new Product("The Way of All Flesh", 98.08));
            products.Add(29, new Product("All the King's Men", 82.05));
        }

        private void FillProductCopies() {
            // Generated using Faker
            // Github: [https://github.com/stympy/faker]
            productCopies.Add(new ProductCopy(products[0], "I'm not normally a praying man, but if you're up there, please save me, Superman!", 49.05, 8));
            productCopies.Add(new ProductCopy(products[1], "Son, if you really want something in this life, you have to work for it. Now quiet! They're about to announce the lottery numbers.", 90.06, 7));
            productCopies.Add(new ProductCopy(products[2], "You tried your best and you failed miserably. The lesson is: Never try.", 47.02, 2));
            productCopies.Add(new ProductCopy(products[3], "Kill my boss? Do I dare live out the American dream?", 97.01, 9));
            productCopies.Add(new ProductCopy(products[4], "That's it! You people have stood in my way long enough. I'm going to clown college!", 36.05, 8));
            productCopies.Add(new ProductCopy(products[5], "I'm not normally a praying man, but if you're up there, please save me, Superman!", 44.08, 2));
            productCopies.Add(new ProductCopy(products[6], "What’s the point of going out? We’re just gonna wind up back home anyway.", 83.06, 2));
            productCopies.Add(new ProductCopy(products[7], "Go out on a Tuesday? Who am I, Charlie Sheen?", 20.08, 0));
            productCopies.Add(new ProductCopy(products[8], "Go out on a Tuesday? Who am I, Charlie Sheen?", 75.08, 6));
            productCopies.Add(new ProductCopy(products[9], "Cheating is the gift man gives himself.", 68.05, 2));
            productCopies.Add(new ProductCopy(products[10], "You tried your best and you failed miserably. The lesson is: Never try.", 77.09, 4));
            productCopies.Add(new ProductCopy(products[11], "If you pray to the wrong god, you might just make the right one madder and madder.", 49.07, 1));
            productCopies.Add(new ProductCopy(products[12], "Son, if you really want something in this life, you have to work for it. Now quiet! They're about to announce the lottery numbers.", 81.05, 0));
            productCopies.Add(new ProductCopy(products[13], "You tried your best and you failed miserably. The lesson is: Never try.", 58.05, 6));
            productCopies.Add(new ProductCopy(products[14], "Kill my boss? Do I dare live out the American dream?", 89.06, 8));
            productCopies.Add(new ProductCopy(products[15], "Marriage is like a coffin and each kid is another nail.", 20.05, 8));
            productCopies.Add(new ProductCopy(products[16], "I'm not normally a praying man, but if you're up there, please save me, Superman!", 12.09, 5));
            productCopies.Add(new ProductCopy(products[17], "Sorry, Mom, the mob has spoken.", 58.08, 4));
            productCopies.Add(new ProductCopy(products[18], "Son, if you really want something in this life, you have to work for it. Now quiet! They're about to announce the lottery numbers.", 83.07, 5));
            productCopies.Add(new ProductCopy(products[19], "You tried your best and you failed miserably. The lesson is: Never try.", 15.04, 3));
            productCopies.Add(new ProductCopy(products[20], "D'oh!", 38.04, 9));
            productCopies.Add(new ProductCopy(products[21], "Trust me, Bart, it's better to walk in on both your parents than on just one of them.", 21.02, 5));
            productCopies.Add(new ProductCopy(products[22], "It takes two to lie: one to lie and one to listen.", 91.05, 1));
            productCopies.Add(new ProductCopy(products[23], "That's it! You people have stood in my way long enough. I'm going to clown college!", 76.08, 0));
            productCopies.Add(new ProductCopy(products[24], "When will I learn? The answers to life’s problems aren’t at the bottom of a bottle, they’re on TV!", 40.04, 8));
            productCopies.Add(new ProductCopy(products[25], "I'm not normally a praying man, but if you're up there, please save me, Superman!", 98.05, 6));
            productCopies.Add(new ProductCopy(products[26], "What’s the point of going out? We’re just gonna wind up back home anyway.", 95.05, 6));
            productCopies.Add(new ProductCopy(products[27], "You tried your best and you failed miserably. The lesson is: Never try.", 31.08, 2));
            productCopies.Add(new ProductCopy(products[28], "When will I learn? The answers to life’s problems aren’t at the bottom of a bottle, they’re on TV!", 40.09, 7));
            productCopies.Add(new ProductCopy(products[29], "If you pray to the wrong god, you might just make the right one madder and madder.", 15.02, 9));
        }

        private void FillOrders() {
            // Generated using Faker
            // Github: [https://github.com/stympy/faker]
            orders.Add(new Order(employees[2], productCopies[22], 21.07, 5));
            orders.Add(new Order(employees[11], productCopies[27], 48.09, 3));
            orders.Add(new Order(employees[3], productCopies[14], 16.07, 8));
            orders.Add(new Order(employees[2], productCopies[28], 56.01, 7));
            orders.Add(new Order(employees[3], productCopies[6], 44.04, 3));
            orders.Add(new Order(employees[14], productCopies[28], 36.05, 3));
            orders.Add(new Order(employees[15], productCopies[9], 60.03, 8));
            orders.Add(new Order(employees[6], productCopies[19], 82.02, 3));
            orders.Add(new Order(employees[17], productCopies[2], 48.01, 7));
            orders.Add(new Order(employees[4], productCopies[17], 72.03, 6));
            orders.Add(new Order(employees[18], productCopies[10], 61.06, 6));
            orders.Add(new Order(employees[17], productCopies[27], 19.05, 0));
            orders.Add(new Order(employees[12], productCopies[12], 60.01, 0));
            orders.Add(new Order(employees[7], productCopies[24], 83.04, 9));
            orders.Add(new Order(employees[8], productCopies[18], 57.01, 1));
        }

        // Getters
        public List<Employee> GetEmployees() {
            return employees;
        }

        public Dictionary<int, Product> GetProducts() {
            return products;
        }

        public ObservableCollection<ProductCopy> GetProductCopies() {
            return productCopies;
        }

        public ObservableCollection<Order> GetOrders() {
            return orders;
        }

    }
}
