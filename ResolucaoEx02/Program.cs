using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucaoEx02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a operação matemática: ");
            char op = ' ';
           
            do
            {   
                try
                {
                    op = char.Parse(Console.ReadLine());
                    if (op != '+' || op != '-' || op != '*' || op != '/')
                    {
                        throw new Exception("Informe uma operação matemática de verdade entre [" +
                            " + | - | * | / ]");
                    }
                } 
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                } 
                //finally 
                //{ 
                //    Console.ReadLine(); 
                //}    
            } while (op != '+' || op != '-' || op != '*' || op != '/');

            Console.WriteLine("Informe o primeiro valor da conta: ");
            double value01 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor da conta: ");
            double value02 = double.Parse(Console.ReadLine());
                    
            switch (op)
            { 
                case '+': 
                    Console.WriteLine("Resultado: " + $"{value01 + value02}");
                    break;
                case '-': 
                    Console.WriteLine("Resultado: " + $"{value01 - value02}");
                    break;
                case '*': 
                    Console.WriteLine("Resultado: " + $"{value01 * value02}");
                    break;
                case '/': 
                    Console.WriteLine("Resultado: " + $"{value01 / value02}");
                    break;
                default:
                    throw new Exception("Não tem nem como chegar aqui!");
                    break;      
            }
            Console.ReadKey();   

        }
    }
}
