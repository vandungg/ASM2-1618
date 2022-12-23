using System;
using System.Collections.Generic;

namespace Assignment2_c3
{
    class Book
    {
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public string Idcard { get; set; }
        public string HotelID { get; set; }
        public string RoomNumber { get; set; }
        public string Rankroom { get; set; }

        public Book()
        {

        }
        public void DISPLAY_IN_BOOK()
        {
            Console.WriteLine("CheckIn : {0} , CheckOut : {1} , Idcard : {2} , HotelID : {3} , roomID: {4}, Rankroom: {5}", Checkin, Checkout, Idcard, HotelID, RoomNumber, Rankroom);
        }

        public void Input(List<Hotel> hotels, List<Customer> customers)
        {
            Console.WriteLine("Booking date (dd/mm/YYYY): ");
            string Datetime = Console.ReadLine();
            Checkin = DateTime.ParseExact(Datetime, "dd/MM/yyyy", null);
            Console.WriteLine("Check out date (dd/mm/YYYY): ");
            Datetime = Console.ReadLine();
            Checkout = DateTime.ParseExact(Datetime, "dd/MM/yyyy", null);

            InputIDCARD(customers);
            RankRoom();
        }
        private void InputIDCARD(List<Customer> customers)
        {
            bool condition = false;
            Console.WriteLine("Enter Idcard : ");
            string find = Console.ReadLine();
            foreach (var item in customers)
            {
                if (find.Equals(item.Idcard))
                {
                    Idcard = find;
                    condition = true;
                    break;
                }
            }
            if (!condition)
            {
                Console.WriteLine("Enter information Customer");
                Customer customer = new Customer();
                customer.Input(idcard: find);
                customers.Add(item: customer);
                Idcard = customer.Idcard;
            }
        }

        private void RankRoom()
        {
            bool condition = true;
            while (condition)
            {
                int bill = 100;
                int Count = 0;
                Console.WriteLine(value: "Type of room: ");
                Console.WriteLine(value: "1.VIP ");
                Console.WriteLine(value: "2.Normal ");
                Console.WriteLine(value: "Choose : ");
                int choose = int.Parse(Console.ReadLine());
                Console.WriteLine(value: "Date: ");
                int Date = int.Parse(s: Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Rankroom = "VIP";
                        for (int i = 1; i <= Date; i++)
                        {
                            Count += (bill * 2);
                        }
                        Console.WriteLine(format: "Bill of your room: {0} ", arg0: Count);
                        condition = false;
                        break;
                    case 2:
                        Rankroom = "Normal";
                        for (int i = 1; i <= Date; i++)
                        {
                            Count += bill;
                        }
                        Console.WriteLine(format: "Bill of your room: {0} ", arg0: Count);
                        condition = false;
                        break;
                    default:
                        Console.WriteLine(value: "Error !! ");

                        break;
                }
            }
        }
    }
}
