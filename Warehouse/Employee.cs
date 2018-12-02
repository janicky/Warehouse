using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    [Serializable()]
    public class Employee
    {
        private static int index = 0;

        private int id;
        private string firstName;
        private string lastName;

        [System.Xml.Serialization.XmlElement("FirstName")]
        public string FirstName {
            get {
                return firstName;
            }
            set {
                SetFirstName(value);
            }
        }

        [System.Xml.Serialization.XmlElement("LastName")]
        public string LastName {
            get {
                return lastName;
            }
            set {
                SetLastName(value);
            }
        }

        public Employee(string firstName, string lastName, int id = -1) {
            this.id = (id != -1 ? id : index++);
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // Reset index method for unit tests
        public static void ResetIndex() {
            index = 0;
        }

        public int GetId() {
            return id;
        }

        public string GetFirstName(){
            return firstName;
        }

        public string GetLastName(){
            return lastName;
        }

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public override bool Equals(object obj) {
            var item = obj as Employee;
            if (item == null) {
                return false;
            }
            return id == item.GetId() &&
                   firstName.Equals(item.GetFirstName()) &&
                   lastName.Equals(item.GetLastName());
        }

        public override int GetHashCode() {
            return id.GetHashCode();
        }

        public override string ToString() {
            return string.Format("Employee: #{0} {1} {2}\n", id, firstName, lastName);
        }
    }
}
