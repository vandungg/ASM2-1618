using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Assignment2_c3
{
    class FunctionMenu
    {
        private object room;
        private object rooms;

        public FunctionMenu()
        {

        }
        public void FindCustomer(List<Customer> customers)
        {
            Console.WriteLine(value: "Enter IDcard of Customer to find : ");
            string find = Console.ReadLine();
            bool isFind = false;
            foreach (Customer customer in customers)
            {
                if (find.Equals(value: customer.Idcard))
                {
                    customer.DisplayCustomer();
                    isFind = true;
                    break;
                }
            }
            if (!isFind)
            {
                Console.WriteLine(value: "Not found Customer !!!");
            }
        }

        public void InputInformationHotel(List<Hotel> hotels)
        {
            Hotel hotel = new Hotel();
            hotel.Input();
            hotels.Add(hotel);
        }

        public void DisplayHotelInfor(List<Hotel> hotels)
        {
            foreach (var item in hotels)
            {
                item.DisplayHotel();
            }
        }

        public void Booking(List<Book> books, List<Hotel> hotels, List<Customer> customers)
        {
            Book book = new Book();
            book.Input(hotels, customers);
            books.Add(item: book);
        }

    }
}