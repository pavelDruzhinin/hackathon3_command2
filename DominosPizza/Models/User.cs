using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DominosPizza.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public string UserRole { get; set; }
    }
}