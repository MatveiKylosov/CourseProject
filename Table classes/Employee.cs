using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Table_classes
{
    public class Employee
    {
        public int ID_employee { get; set; }
        public string surname { get; set; }
        public string first_name { get; set; }
        public string patronymic { get; set; }
        public string post { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public Employee(int id, string surname, string firstName, string patronymic, string post, string phone, string email)
        {
            ID_employee = id;
            this.surname = surname;
            first_name = firstName;
            this.patronymic = patronymic;
            this.post = post;
            this.phone = phone;
            this.email = email;
        }
    }

}
