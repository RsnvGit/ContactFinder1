using ContactFinderBusiness.Abstract;
using ContactFinderBusiness.Concrete;
using ContactFinderEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactFinderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public List<Contact> Get()
        {
            return _contactService.GetContacts();
        }

        [HttpGet("GetById/{id}")]
        public Contact Get(int id)
        {
            return _contactService.GetContactById(id);
        }

        [HttpPost("CreateContact")]
        public Contact Post([FromBody]Contact contact)
        {
            return _contactService.CreateContact(contact);
        }

        [HttpPut("UpdateContact")]
        public Contact Put([FromBody] Contact contact)
        {
            return _contactService.UpdateContact(contact);
        }

        [HttpDelete("Delete/{id}")]
        public void  Delete(int id)
        {
            _contactService.DeleteContact(id);
        }

        [HttpPost("Ignore/{id}")]
        public void Ignore(int id)
        {
            _contactService.Ignore(id);
        }
        [HttpPost("UnIgnore/{id}")]
        public void UnIgnore(int id)
        {
            _contactService.UnIgnore(id);
        }

        [HttpGet("/Ignored")]
        public List<Contact> GetIgnoredContacts()
        {
            return _contactService.GetIgnoredContacts();
        }



    }
}
