using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Sakarya";
            customer.Id = 1;
            customer.FirstName = "Ayaz";
            customer.LastName = "Deniz";

            Customer customer2 = new Customer() {Id = 2, FirstName =" Kiraz", LastName = "Yalın", City = "İstanbul" };

            Console.WriteLine(customer2.FirstName);


            Console.ReadLine();
        }

    }


}   


  
