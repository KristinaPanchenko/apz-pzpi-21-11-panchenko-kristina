﻿using System;

namespace Solar.Models
{
    public class House
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
