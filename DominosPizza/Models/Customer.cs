﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DominosPizza.Models
{
    public class Customer
    {
        private int customerId;
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

        public int CustomerId
        {
            get
            {
                return customerId;
            }
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
    }
}