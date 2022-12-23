using System;
using System.Collections.Generic;
using System.Data;

namespace Assignment2_c3
{
    class Hotel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Rankroom { get; set; }
        public string HotelNumber { get; set; }

        public List<Room> Rooms { get; set; }
        public Hotel()
        {
            Rooms = new List<Room>();
        }

        public void Input()
        {
            Console.WriteLine("Code of hotel : ");
            HotelNumber = Console.ReadLine();
            Input(HotelNumber);
        }
        public void Input(string hotelID)
        {
            Console.WriteLine("Name of hotel : ");
            Name = Console.ReadLine();
            Console.WriteLine("Address of hotel : ");
            Address = Console.ReadLine();

            InputRoom(Rooms);
            this.HotelNumber = hotelID;
        }

        public void Input(FunctionMenu functionMenu)
        {

            Console.WriteLine("Name: " + Name);
            Name = Console.ReadLine();
            Console.WriteLine("Address: " + Address);
            Address = Console.ReadLine();
            DateTime aDateTimeClose = new DateTime(year: 2022, month: 12, day: 16, hour: 7, minute: 0, second: 0);
            TimeSpan timeofOpen = aDateTimeClose.TimeOfDay;
            Console.WriteLine("Open:{0}", timeofOpen);
            DateTime aDateTimeOpen = new DateTime(year: 2022, month: 12, day: 16, hour: 9, minute: 0, second: 0);
            TimeSpan timeOfClose = aDateTimeClose.TimeOfDay;
            Console.WriteLine("Close: {0} ", timeOfClose);
            InputRoom(Rooms);
        }

        public void DisplayHotel()
        {
            Console.WriteLine("HotelName: {0} , Address : {1} , Hotel Number: {2}", Name, Address, HotelNumber);
            DateTime aDateTimeOpen = new DateTime(year: 2022, month: 12, day: 16, hour: 7, minute: 0, second: 0);
            TimeSpan timeOfOpen = aDateTimeOpen.TimeOfDay;
            Console.WriteLine("Open: {0} ", timeOfOpen);
            DateTime aDateTimeClose = new DateTime(year: 2022, month: 12, day: 16, hour: 23, minute: 0, second: 0);
            TimeSpan timeOfClose = aDateTimeClose.TimeOfDay;
            Console.WriteLine("Close: {0} ", timeOfClose);
            Console.WriteLine("List of Room : ");
            foreach (var item in Rooms)
            {
                item.DisplayRoom();
            }
        }
        private void InputRoom(List<Room> rooms)
        {
            Console.WriteLine(value: "Setting Room's Information : ");
            for (; ; )
            {
                Room room = new Room();
                room.Input();
                rooms.Add(item: room);
                Console.WriteLine(value: "Add Room : (y/n)");
                string option = Console.ReadLine();
                if (option.Equals(value: "n"))
                {
                    break;
                }
            }
        }
    }
}
