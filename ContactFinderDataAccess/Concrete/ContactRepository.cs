using ContactFinderDataAccess.Abstract;
using ContactFinderEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactFinderDataAccess.Concrete
{
    public class ContactRepository : IContactRepository
    {
        public Contact CreateContact(Contact contact)
        {
            using (var contactDbContext = new ContactDbContext())
            {
                contactDbContext.Contacts.Add(contact);
                contactDbContext.SaveChanges();
                return contact;
            }
        }

        public void DeleteContact(int id)
        {
            using (var contactDbContext = new ContactDbContext())
            {
                var deleteContact = GetContactById(id);
                contactDbContext.Contacts.Remove(deleteContact);
                contactDbContext.SaveChanges();
            }
        }

        public Contact GetContactById(int id)
        {
            using (var contactDbContext = new ContactDbContext())
            {
                return contactDbContext.Contacts.Find(id);
            }
        }

        public List<Contact> GetContacts()
        {
            using(var contactDbContext=new ContactDbContext())
            {
                return contactDbContext.Contacts.Where(c=>c.IgnoredContacts==true).ToList();
            }
        }

        public Contact UpdateContact(Contact contact)
        {
            using (var contactDbContext = new ContactDbContext())
            {
                contactDbContext.Contacts.Update(contact);
                contactDbContext.SaveChanges();
                return contact;
            }
        }

        public void Ignore(int id)
        {
            using (var contactDbContext = new ContactDbContext())
            {
                var ignore = GetContactById(id);
                ignore.IgnoredContacts = false;
               
                contactDbContext.Contacts.Update(ignore);
                contactDbContext.SaveChanges();         
            }
        }
        public void UnIgnore(int id)
        {
            using (var contactDbContext = new ContactDbContext())
            {
                var ignore = GetContactById(id);
                ignore.IgnoredContacts = true;

                contactDbContext.Contacts.Update(ignore);
                contactDbContext.SaveChanges();
            }
        }


        public List<Contact> GetIgnoredContacts()
        {
            using (var contactDbContext = new ContactDbContext())
            {
                return contactDbContext.Contacts.Where(c => c.IgnoredContacts == false).ToList();
            }
        }


    }
}
