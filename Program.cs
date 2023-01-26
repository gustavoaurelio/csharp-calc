using System;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int res;
                Console.Write("Insira o primeiro número:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Insira o segundo Número:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Entre a operação(/, +, -, *)");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Adição" + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Subtração:" + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Multiplicação:" + res);
                        break;
                    case "/":
                        res = num1 / num2 ;
                        Console.WriteLine("Divisão:" + res);
                        break;
                    default:
                        Console.WriteLine("Operação errada!");
                        break;
                }
                Console.ReadLine();
                Console.WriteLine("Gostaria de continuar ? (s/n):");
                value = Console.ReadLine();
            }
            while (value=="s" || value=="S");
        }
    }
}
