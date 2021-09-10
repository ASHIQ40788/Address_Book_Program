using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    class Program
    {
        static void Main(string[] args)
        {
             AddressBook addressBook = new AddressBook();
            void UpdateAddressBook(string userInput)
            {
                string name = "";
                string address = "";
                string city = "";
                string state = "";
                witch ( userInput.ToLower() ) 
                {
                    case "add":
                        Console.Write("Enter a name: ");
                        name = Console.ReadLine();
                        switch(name) 
                        {
                            case "quit":
                                break;
                            default:
                                Console.Write("Enter an address: ");
                                address = Console.ReadLine();
                                switch (address) 
                                {
                                    case "quit":
                                        break;
                                        Console.Write("Enter a city: ");
                          city = Console.ReadLine();
                         switch(city) 
                        {
                            case "quit":
                                break;
                            default:
                                Console.Write("Enter an state: ");
                                state = Console.ReadLine();
                                switch (a) 
                                {
                                    case "quit":
                                        break;
                                    default:
                                        addressBook.AddEntry(name, address, city, state);
                                        break;
                                }
                                break;
                        }
        }
    }
}
