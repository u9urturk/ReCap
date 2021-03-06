﻿using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }
    interface IWorker
    {
        void Work();


    }
    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();

    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager için Yemek alanı");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager için Ücret alanı");
        }

        public void Work()
        {
            Console.WriteLine("Manager için Çalışma alanı");
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
       
        public void Eat()
        {
            Console.WriteLine("Worker için Yemek alanı");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker için Ücret alanı");
        }

        public void Work()
        {
            Console.WriteLine("Worker için Çalışma alanı");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine(" Robot için Çalışma alanı");
        }
    }



}
