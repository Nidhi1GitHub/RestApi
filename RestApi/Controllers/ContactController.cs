using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestApi.Services;

namespace RestApi.Controllers
{
    public class ContactController : ApiController
    {
        private ContactRepository contactRepository;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }

        //http://localhost:54970/api/Get
        //public string[] Get()
        //{
        //    return new string[]
        //    {
        //        "Hello",
        //        "World"
        //    };
        //}

        //http://localhost:54970/api/Get
        //[Route("api/Get")]
        //public Contact[] Get()
        //{
        //    return new Contact[]
        //    {
        //        new Contact
        //        {
        //            Id = 1,
        //            Name = "Nidhi"
        //        },
        //        new Contact
        //        {
        //            Id = 2,
        //            Name = "Krish"
        //        }
        //    };
        //}

        //http://localhost:54970/api/contact

        //[Route("api/contact")]
        //public Contact[] Get()
        //{
        //    return contactRepository.GetAllContacts();
        //}

        [Route("api/contact")]
        public HttpResponseMessage Post(Contact contact)
        {
            this.contactRepository.SaveContact(contact);

            var response = Request.CreateResponse<Contact>(System.Net.HttpStatusCode.Created, contact);

            return response;
        }
    }
}
