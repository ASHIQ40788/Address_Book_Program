using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Address_Book
{
    class AddressBook
    {
        //Readonly can be declared only at the class level, not inside the method.
        //readonly keyword to declare a readonly variable (in a constructor of the same class)
        public readonly Contact[] contacts;

        public AddressBook()
        {
            contacts = new Contact[4]; ;
        }

        public bool AddEntry(string name, string address, string city, string state)
        {
            //checking whether the name is there or not.
            if (!ContainsEntry(name))
            {
                
                Contact AddContact = new Contact(name, address, city, state);

                //contact.Length--->>represents the number of characters in the string
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

        public bool UpdateContact(string originalName)
        {
            Console.Write("Are you like to update the Contact? -- Type 'Y' or 'N': ");
            string userResponse = Console.ReadLine().ToLower();
            if (userResponse == "y")
            {
                Console.Write($"Would you like to update {originalName}'s name or address? TYPE - 'Name' for name and 'Address' for address: ");
                string entryToUpdate = Console.ReadLine().ToLower();

                ////, (entryToUpdate == "address") ? "address" : "name"
                Console.Write($"Please enter changes to the {entryToUpdate} here: ");
                string userUpdatedEntry = Console.ReadLine();

                int index = GetEntryIndex(originalName);
                if (entryToUpdate == "name")
                {
                    contacts[index].name = userUpdatedEntry;
                    Console.WriteLine($"Contact {originalName} updated to {userUpdatedEntry}");
                    return true;
                }
                if (entryToUpdate == "address")
                {
                    contacts[index].address = userUpdatedEntry;
                    Console.WriteLine($"Contact {originalName}'s {entryToUpdate} updated to {userUpdatedEntry}");
                    return true;
                }
            }
            return false;
        }

        private int GetEntryIndex(string name)
        {
            for (int i = 0; i < contacts.Length; i++)
            {
                if (contacts[i] != null && contacts[i].name == name)
                    return i;
            }
            return -1;
        }

        private bool ContainsEntry(string name)
        {
            return GetEntryIndex(name) != -1;
        }

        public void RemoveEntry(string name)
        {
            var index = GetEntryIndex(name);
            if (index != -1)
            {
                contacts[index] = null;
                Console.WriteLine("{0} removed from contacts", name);
            }
        }

        public string ViewContactsList()
        {
            string contactList = "";
            foreach (Contact contact in contacts)
            {
                if (contact == null)
                {
                    continue;
                }
                contactList += String.Format("Name: {0} -- Address: {1}" + Environment.NewLine, contact.name, contact.address);
            }
            return (contactList != String.Empty) ? contactList : "Your Address Book is empty.";
        }
    }
}
