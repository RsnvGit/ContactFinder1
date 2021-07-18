using ContactFinderEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactFinderBusiness.Abstract
{
    public interface IContactService
    {
        List<Contact> GetContacts();

        Contact GetContactById(int id);

        Contact CreateContact(Contact contact);

        Contact UpdateContact(Contact contact);

        void DeleteContact(int id);

        void Ignore(int id);

        void UnIgnore(int id);

        List<Contact> GetIgnoredContacts();
    }
}
