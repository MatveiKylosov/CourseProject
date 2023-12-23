using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Table_classes
{
    public class Client
    {
        public int ID_client{ get; set; }
        public string surname{ get; set; }
        public string first_name{ get; set; }
        public string patronymic{ get; set; }
        public string phone{ get; set; }
        public string email { get; set; }

        public Client(int ID_client, string surname, string first_name, string patronymic, string phone, string email) { 
        
            this.ID_client = ID_client;
            this.surname = surname;
            this.first_name = first_name;
            this.patronymic = patronymic;
            this.phone = phone;
            this.email = email;
        }
    }
}
