using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DominosPizza.Models
{
    public class Customers
    {
<<<<<<< 2a16dddde79a62e068ac43d43e6fcad2b3d1f3d9:DominosPizza/Models/Customer.cs
        private int CustomerId { get; set; }
        private string CustomerFirstName { get; set; }
        private string CustomerLastName { get; set; }
        private string CustomerPatronymic { get; set; }
        private DateTime CustomerBirthDate { get; set; }
        private Boolean CustomerSex { get; set; }
        private ICollection<Contacts> ContactsId { get; set; }

        //public void NewCustomer(string Name, string PatronymicName, string SurName, DateTime BirthDate)
        //{
        //    customerName = Name;
        //    customerPatronymicName = PatronymicName;
        //    customerSurName = SurName;
        //    customerBirthDate = BirthDate;
        //    customerCreateDate = DateTime.Now;
        //}
=======
        public int CustomersId { get; set; } 
        private string customerName;
        private string customerPatronymicName;
        private string customerSurName;
        private DateTime customerBirthDate;
        private DateTime customerCreateDate;

        public void NewCustomer(string Name, string PatronymicName, string SurName, DateTime BirthDate)
        {
            customerName = Name;
            customerPatronymicName = PatronymicName;
            customerSurName = SurName;
            customerBirthDate = BirthDate;
            customerCreateDate = DateTime.Now;
        }


        public DateTime CustomerCreateDate
        {
            get
            {
                return customerCreateDate;
            }
        }
        public DateTime CustomerBirthDate
        {
            get
            {
                return customerBirthDate;
            }
        }
        public string CustomerFullName()
        {
            return $"{customerName} {customerPatronymicName} {customerSurName}";
        }
>>>>>>> В процессе доделывания интерфейса реализовалась минимально работающая версия приложения.:DominosPizza/Models/Customers.cs
    }
}