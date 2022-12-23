using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_c3
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionMenu functionMenu = new FunctionMenu();
            List<Book> books = new List<Book>();
            List<Hotel> Hotel = new List<Hotel>();
            List<Customer> customers = new List<Customer>();
            int Command;
            do
            {
                Menu();
                Command = int.Parse(Console.ReadLine());
                switch (Command)
                {
                    case 1:
                        functionMenu.InputInformationHotel(Hotel);
                        break;
                    case 2:
                        functionMenu.DisplayHotelInfor(Hotel);
                        break;
                    case 3:
                        functionMenu.Booking(books, Hotel, customers);
                        break;
                    case 4:
                        functionMenu.FindCustomer(customers);
                        break;
                    case 5:
                        Console.WriteLine("Exit !!");
                        break;
                    default:
                        Console.WriteLine("error !!");
                        break;
                }
            }
            while (Command != 5);
        }

        static void Menu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Enter hotel information");
            Console.WriteLine("2. Display hotel information");
            Console.WriteLine("3. Reservation");
            Console.WriteLine("4. Search for customer information");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Choose : ");
        }
    }
}