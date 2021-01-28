using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonManeger manager = new PersonManeger();
            //Customer customer = new Customer
            //{
            //    Id = 1,
            //    FirstName ="Uğur ",
            //    LastName = "Türk",
            //    Address ="Sakarya"

            //};

            //Student student = new Student
            //{
            //    Id = 1,
            //    FirstName = "Derin",
            //    LastName = "Demir",   
            //    Departmant = "Computer Sciences"

            //};  
            //manager.Add(customer);
            //manager.Add(student);

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
                new MySqlServerCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }


            Console.ReadLine();


        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerCustomerDal());
        }

        interface IPerson // soyut nesne
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }

        }

        class Customer:IPerson // somut nesne
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public  string LastName { get; set; }
            
            public string Address { get; set; }

        }

        class Student:IPerson // somut nesne
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Departmant { get; set; }
        }

        class Worker : IPerson // somut nesne
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Departmant { get; set; }
        }


        class PersonManeger
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
