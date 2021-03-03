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
            // Cast: transformar o tipo de uma váriavel colocando o outro tipo entre () na frente da variavel, podendo ter perca de dados. Ex: double a = 20.16574; b = (int)a; 'b' vai se tornar 20

            // + = adição
            // - = subtração
            // * = multiplicação
            // / = divisão
            // % = resto da divisão (mod)
            // Math.Pow(x, 2.0); = x^2 (potenciação)
            // Math.Sqrt(25); = raiz quadrada

            Console.WriteLine("digite 2 numeros para fazer a multiplicaçao");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int mult = x * y;
            Console.WriteLine("deu = " + mult); ;

            Console.WriteLine("digite 2 numeros para fazer o mod da divisão");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double resto = x2 % y2;
            Console.WriteLine("deu = " + resto); ;

            Console.WriteLine("digite 2 numeros para fazer a potenciação");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double pot = Math.Pow(x3, y3);
            Console.WriteLine("deu = " + pot);


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
