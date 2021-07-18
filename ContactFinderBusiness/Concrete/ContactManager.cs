using ContactFinderBusiness.Abstract;
using ContactFinderDataAccess.Abstract;
using ContactFinderDataAccess.Concrete;
using ContactFinderEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactFinderBusiness.Concrete
{
    public class ContactManager : IContactService
    {
        private IContactRepository _contactRepository;

        public ContactManager(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public Contact CreateContact(Contact contact)
        {
            return _contactRepository.CreateContact(contact);
        }

        public void DeleteContact(int id)
        {
            _contactRepository.DeleteContact(id);
        }

        public Contact GetContactById(int id)
        {
            return _contactRepository.GetContactById(id);
        }

        public List<Contact> GetContacts()
        {
            return _contactRepository.GetContacts();
        }

        public Contact UpdateContact(Contact contact)
        {
            return _contactRepository.UpdateContact(contact);
        }
        
        public void Ignore(int id)
        {
            _contactRepository.Ignore(id);
        }
        public void UnIgnore(int id)
        {
            _contactRepository.UnIgnore(id);
        }

        public List<Contact> GetIgnoredContacts()
        {
            return _contactRepository.GetIgnoredContacts();
        }

    }
}
