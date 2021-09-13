using System;

namespace Address_Book
{
    class Program
    {
        static void Main(string[] args)
        {

            AddressBook addressBook = new AddressBook();

            PromptUser();

            void Menu()
            {
                Console.WriteLine("TYPE:");
                Console.WriteLine("'Add' -------->> add a contact: ");
                Console.WriteLine("'View'-------->> view the list of contacts: ");
                Console.WriteLine("'Remove' ------->> select and remove a contact: ");
                Console.WriteLine("'Update' -------->> select and update a contact: ");
                Console.WriteLine("'Quit' ------>> anytime to exit: ");
            }

            void UpdateAddressBook(string userInput)
            {
                string name = "";
                string address = "";
                string city = "";
                string state = "";
                
                //converting all strings into lower case.
                switch (userInput.ToLower())
                {
                    case "add":
                        Console.Write("Enter a name of the person: ");
                        name = Console.ReadLine();
                        switch (name)
                        {
                            case "quit":
                                break;
                            default:
                                Console.Write("Enter an address of the person: ");
                                address = Console.ReadLine();
                                switch (address)
                                {
                                    case "quit":
                                        break;

                                    default:
                                        addressBook.AddEntry(name, address, city, state);
                                        break;
                                }
                                break;
                        }
                        break;
                    case "remove":
                        Console.Write("Enter a name to remove: ");
                        name = Console.ReadLine();
                        switch (name)
                        {
                            case "quit":
                                break;
                            default:
                                addressBook.RemoveEntry(name);
                                break;
                        }
                        break;
                    case "view":
                        Console.WriteLine(addressBook.ViewContactsList());
                        break;
                    case "update":
                        Console.WriteLine("Please enter the name of the Contact which you like to update");
                        name = Console.ReadLine();
                        addressBook.UpdateContact(name);
                        break;
                }
            }


            //local method
            void PromptUser()
            {
                Menu();
                string userInput = "";
                while (userInput != "quit")
                {
                    Console.WriteLine("What would you like to do?");
                    userInput = Console.ReadLine();
                    UpdateAddressBook(userInput);
                }
            }
        }
    }
}