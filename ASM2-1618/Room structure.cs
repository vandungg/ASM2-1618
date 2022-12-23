using System;
namespace Assignment2_c3
{
    class Room
    {
        public string Name { get; set; }
        public int FloorNumber { get; set; }
        public int MaxPerson { get; set; }
        public string RoomNumber { get; set; }
        public string Rankroom { get; set; }
        public Room()
        {

        }
        public Room(string name, int floorNumber, int maxPerson, string roomNumber)
        {
            FloorNumber = floorNumber;
            MaxPerson = maxPerson;
            RoomNumber = roomNumber;
            Name = name;

        }

        public void Input()
        {
            Console.WriteLine(value: "Room name : ");
            Name = Console.ReadLine();
            Console.WriteLine(value: "floor : ");
            FloorNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Maximum number of people : ");
            MaxPerson = int.Parse(Console.ReadLine());
            Console.WriteLine("Room number : ");
            RoomNumber = Console.ReadLine();
        }

        public void DisplayRoom()
        {
            Console.WriteLine("Name : {0} , numberFloor : {1} , maxPerson : {2} , roomCode: {3}", Name, FloorNumber, MaxPerson, RoomNumber);
        }
    }
}
