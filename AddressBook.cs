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

        public bool UpdateContact(string originalName)
        {
            Console.Write("Are you sure you would you like to update the Contact? -- Type 'Y' or 'N': ");
            string userResponse = Console.ReadLine().ToLower();
            if (userResponse == "y")
            {
                Console.Write($"Would you like to update {originalName}'s name or address? TYPE - 'Name' for name and 'Address' for address: ");
                string entryToUpdate = Console.ReadLine().ToLower();

                //, (entryToUpdate == "address") ? "address" : "name"
                Console.Write($"Please enter changes to the {entryToUpdate} here: ");
                string userUpdatedEntry = Console.ReadLine();

                int index = GetEntryIndex(originalName);
                if (entryToUpdate == "name")
                {
                    contacts[index].Name = userUpdatedEntry;
                    Console.WriteLine($"Contact {originalName} updated to {userUpdatedEntry}");
                    return true;
                }
                if (entryToUpdate == "address")
                {
                    contacts[index].Address = userUpdatedEntry;
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
                if (contacts[i] != null && contacts[i].Name == name)
                    return i;
            }
            return -1;
        }

        private bool ContainsEntry(string name)
        {
            return GetEntryIndex(name) != -1;
        }
    }
}