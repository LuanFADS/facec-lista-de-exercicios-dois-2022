using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucaoEx03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu nome: ");
            String nome = Console.ReadLine().ToLower();
            int y = 0;
            int z = 0;

            for (int i = 0; i <= nome.Length - 1; i++)
            {
                if (nome[i].Equals('a') || nome[i].Equals('e') || nome[i].Equals('i')
                    || nome[i].Equals('o') || nome[i].Equals('u'))
                    y++;
                else
                    z++;
            }
            Console.WriteLine($"Existe(m) {y} vogal(is) da palavra ({nome})");
            Console.WriteLine($"Existe(m) {z} consoante(s) da palavra ({nome})");
            Console.ReadLine();
        }
    }
}
