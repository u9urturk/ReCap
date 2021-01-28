using System;

namespace InterfaceReload
{
    class Program
    {
        // 'interface' ler 'new' lenemezler.. 
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
            

           // IPersonManager employeeManager = new EmployeeManager();
            

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new InternManager());

        }
    }

    
    interface IPersonManager
    {
        //unimplemented operation
        void Add();

        void Update();
       
    }

    //inherits = class ---------------- implements = interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //Müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel eklendi.");

        }

        public void Update()
        {
            Console.WriteLine("Personal güncellendi.");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajer eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Stajer eklendi.");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
