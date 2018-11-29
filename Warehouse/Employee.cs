using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class Employee
    {
        private static int index = 0;

        private int id;
        private string firstName;
        private string lastName;

        public Employee(string firstName, string lastName) {
            id = index++;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public int GetId() {
            return id;
        }

        public string GetFirstName(){
            return firstName;
        }

        public string GetLastName(){
            return lastname;
        }


    }
}
