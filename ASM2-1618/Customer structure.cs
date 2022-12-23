using System;

namespace Assignment2_c3
{
    class Customer
    {
        public string Idcard { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public Customer()
        {

        }
        public Customer(string idcard, string name, int age, string gender, string address)
        {
            Idcard = idcard;
            Name = name;
            Age = age;
            Gender = gender;
            Address = address;
        }

        public void Input()
        {
            Console.WriteLine( "IDcard : ");
            Idcard = Console.ReadLine();
            Input(Idcard);
        }

        public void Input(string idcard)
        {
            Idcard = idcard;
            Console.WriteLine( "Name : ");
            Name = Console.ReadLine();
            Console.WriteLine( "Age : ");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine( "Gender : ");
            Gender = Console.ReadLine();
            Console.WriteLine( "Address : ");
            Address = Console.ReadLine();
        }


        public void DisplayCustomer()
        {
            Console.WriteLine( "IDcard : {0} , Fullname : {1} , Age : {2} , Gender : {3} , Address : {4}", Idcard, Name, Age, Gender, Address);
        }
    }
}
