using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbjonTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Welcome " + name + ", you're " + age + " years old.");
                
         }
    }
}
