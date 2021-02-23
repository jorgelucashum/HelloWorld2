using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            // && - and
            // || - or
            // == - igualar
            // != - diferente
            // >= - <=
            // int.Parse(); converte o tipo da variavel. Ex: int.Parse(Console.ReadLine());

            Console.WriteLine("digite 2 numeros para fazer a multiplicaçao");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int c = x * y;
            Console.WriteLine("deu = " + c); ;


            Console.WriteLine("Digite sua idade ");
            int idade = int.Parse(Console.ReadLine());
            if(idade < 18 && idade > 0)
            {
                Console.WriteLine("vc é de menor");
            }
            else if (idade >= 18 && idade < 65)
            {
                Console.WriteLine("vc é adulto");
            }
            else  
            {
                Console.WriteLine("vc é idoso");
            }
            

            Console.ReadLine();
        }
    }
}
