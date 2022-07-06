using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__Media_do_Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
                {
                string nome;
                double n1, n2, media, t1; 
                Console.Write("Digite seu nome: ");
                nome= Console.ReadLine();

                Console.Write("\nDigite a primeira nota: ");
                n1 = double.Parse(Console.ReadLine());

                Console.Write("\nDigite a segunda nota: ");
                n2 = double.Parse(Console.ReadLine());

                Console.Write("\nDigite a nota de trbalho: ");
                t1 = double.Parse(Console.ReadLine());  




                media = (n1 + n2 + t1) / 3;



                Console.Clear();
                if (media >= 8.5)
                {
                    Console.WriteLine("Nome do aluno: "+ nome +  "\nNota:  A");
                }
                else if (media >= 7 && media <= 8.4)
                {
                    Console.WriteLine("Nome do aluno: " + nome + "\nNota:  B");
                }
                else if (media >= 6 && media <= 6.9)
                {
                    Console.WriteLine("Nome do aluno: " + nome + "\nNota:  C");
                }
                else if (media >= 0.1 && media <= 5.9)
                {
                    Console.WriteLine("Nome do aluno: " + nome + "\nNota:  D");
                }
                else  
                {
                    Console.WriteLine("Nome do aluno: " + nome + "\nNota:  E");
                }
                Console.ReadKey();
                Console.Clear();





            }
            Console.ReadKey();
        }
    }
}
