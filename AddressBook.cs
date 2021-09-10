using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Address_Book
{
    class AddressBook
    {

        public readonly Contact[] contacts;

        public AddressBook()
        {
            contacts = new Contact[2]; ;
        }

        public bool AddEntry(string name, string address, string city, string state)
        {
            if (!ContainsEntry(name))
            {
                Contact AddContact = new Contact(name, address, city, state);
                for (int i = 0; i < contacts.Length; i++)
                {
                    if (contacts[i] == null)
                    {
                        contacts[i] = AddContact;
                        Console.WriteLine("Address Book updated. {0} has been added!", name);
                        return true;
                    }
                }
                Console.WriteLine($"Cannot add ({name}) to Address Book since it is full!");
                return false;
            }
            else
            {
                Console.WriteLine($"({name}) already exists in Address Book!");
                UpdateContact(name);
            }
            return false;
        }
    }
}