using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestApi.Models;

namespace RestApi.Services
{
    public class ContactRepository
    {
        public Contact[] GetAllContacts()
        {
            return new Contact[]
            {
                new Contact
                {
                    Id = 1,
                    Name = "Naineta"
                },
                new Contact
                {
                    Id = 2,
                    Name = "Krish"
                }
            };
        }
    }
}