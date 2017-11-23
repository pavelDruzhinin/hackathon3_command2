using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DominosPizza.Models
{
    public class Contacts
    {
<<<<<<< 2a16dddde79a62e068ac43d43e6fcad2b3d1f3d9
        public int ContactsId { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public ICollection<Customer> CustomerId { get; set; } // несколько человек на адресе и городской телефон
=======
        public int ContactsId { get; set; } 
        public string ContactPhoneNumber { get; set; }
        public string ContactEmail { get; set; }
        public string ContactAddress { get; set; }
>>>>>>> В процессе доделывания интерфейса реализовалась минимально работающая версия приложения.
    }
}