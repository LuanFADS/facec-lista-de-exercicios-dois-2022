using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucaoEx01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe a sua data de nascimento: ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.WriteLine($"Você tem {DateTime.Today.Year - data.Year} anos");
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
            finally 
            { Console.ReadLine(); }
        }
    }
}
