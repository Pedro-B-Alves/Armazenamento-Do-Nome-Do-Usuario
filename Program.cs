using System;
using Armazenamento_Do_Nome_Do_Usuario.classes;

namespace Armazenamento_Do_Nome_Do_Usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o seu Sobrenome:");
            string sobreNome = Console.ReadLine();
            
            Pessoa pessoa = new Pessoa(nome,sobreNome);
        }
    }
}
