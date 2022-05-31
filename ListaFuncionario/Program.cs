using System;
using System.Globalization;
using System.Collections.Generic;
namespace ListaFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be regitred? ");
            int n = int.Parse(Console.ReadLine());
            List<Employees> list = new List<Employees>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary : ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employees(id, name, salary));
                Console.WriteLine();
            }
            Console.Write("Enter with an employee ID, that will have salary encresement: ");
            int SearchId = int.Parse(Console.ReadLine());
            Employees emp = list.Find(x => x.Id == SearchId);
            if (emp != null)
            {
                Console.WriteLine("Enter with the ammount in %: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IcreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("Invalid ID.");

            }
            Console.WriteLine();
            Console.WriteLine("Update list: ");
            foreach (Employees names in list)
            {
                Console.WriteLine(names);
            }
        }
    }
}
