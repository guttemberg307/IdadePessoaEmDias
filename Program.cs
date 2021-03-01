using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadePessoa
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("============= IDADE DE UMA PESSOA EM DIAS =========================");

            Console.Write("Insira o dia do seu nascimento: ");
            int dia = int.Parse(Console.ReadLine());


            Console.Write("Insira o mês do seu nascimento:");
            int mes = int.Parse(Console.ReadLine());



            Console.Write("Insira o ano do seu nascimento:");
            int ano = int.Parse(Console.ReadLine());


            int Mesdias = mes * 30;
            int Anosdias = ano * 365;

            int resultado = Mesdias + Anosdias + dia;

            Console.WriteLine("O total de dias vividos de uma pessoa é de:{0}",resultado);

          



        }
    }
}
