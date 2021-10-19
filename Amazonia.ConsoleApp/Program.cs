using System;
using Amazonia.DAL;
using Amazonia.DAL.Repositories;
namespace Amazonia.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var repo = new ClienteRepository();
            var lista = repo.ReadAll();
            foreach (var item in lista)
            {
                System.Console.WriteLine(item);
            }
            
            do
            {
               var novocliente = new Cliente();
               System.Console.WriteLine("Nome: ");
               novocliente.Nome = Console.ReadLine();

               repo.Create(novocliente);
            } while (Console.ReadKey().Key != ConsoleKey.Tab);

            var listanova = repo.ReadAll();
            foreach (var item in listanova)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}
