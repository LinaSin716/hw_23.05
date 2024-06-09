using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_23._05
{
    public class ContactsManager
    {
        public List<Contact> contacts = new List<Contact>();
        public void AddContact(string name, string phoneNumber)
        {
            if (phoneNumber == null || name == null || phoneNumber == "" || name == "")
            {
                throw new InvalidContactException($"Неправильные данные ( name: {name} phone: {phoneNumber} )");
            }
            contacts.Add(new Contact { Name = name, PhoneNumber = phoneNumber });
        }
        public List<Contact> FindContactByName(string name)
        {
            return contacts.Where(c => c.Name == name).ToList();
        }
    }
}
