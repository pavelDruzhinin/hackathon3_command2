using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DominosPizza.Models
{
    public class Contacts
    {
        public int ContactsId { get; set; } 
        public string ContactPhoneNumber { get; set; }
        public string ContactEmail { get; set; }
        public string ContactAddress { get; set; }
    }
}