using System;
using Figgle;
namespace Calculadora_Ryan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Olá usuário, meu nome é Ryan a inteligência artificial! Hoje serei sua calculadora, vamos começar!!!\n");

            Console.WriteLine("Primeiro de tudo preciso saber seu nome");
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Prazer em conhece-lo {nome}!");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{nome} eu tenho uma lista de quatro operações matemáticas que são elas:\n\nSoma, Subtração, Multiplicação\nDivisão, Raiz Quadrada e Potencia\n");
            Console.WriteLine("Escolha uma das quatro e então poderemos começar a calcular!\n");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Pressione qualquer tecla para continuar");
            Console.ReadKey();

            Console.Clear();

            string sair;

            double valor1, valor2;
            string numeroDigitado1, numeroDigitado2;
            bool numeroValido;

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write($"{nome} digite uma das operações matemáticas da lista..: ");
                string operação = Console.ReadLine().ToLower();
                Console.WriteLine("Agora digite dois números que queira calcular\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("1° número: ");

                numeroDigitado1 = Console.ReadLine();
                numeroValido = double.TryParse(numeroDigitado1, out valor1);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("2° número: ");
                
                numeroDigitado2 = Console.ReadLine();
                numeroValido = double.TryParse(numeroDigitado2, out valor2);

                if(!numeroValido)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Não é possivel operar com esses valores\n");
                }
                else
                {

                if(operação=="soma")
                Console.WriteLine($"{valor1} + {valor2} = {valor1 + valor2}");
                else if(operação=="subtração")
                Console.WriteLine($"{valor1} - {valor2} = {valor1 - valor2}");
                else if(operação=="multiplicação")
                Console.WriteLine($"{valor1} X {valor2} = {valor1 * valor2}");
                else if(operação=="divisão")
                Console.WriteLine($"{valor1} / {valor2} = {valor1 / valor2}");
                else if(operação=="raiz quadrada")
                Console.WriteLine(Math.Sqrt(valor1));
                else if(operação=="potencia")
                Console.WriteLine(Math.Pow(valor1, valor2));
                else
                Console.WriteLine($"{nome} você não digitou nenhuma das operações da lista ou deve ter digitado errado");
                }
                
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("Deseja parar de calcular, SIM ou NÃO: ");
                sair = Console.ReadLine().ToUpper();
                Console.Clear();


            
            } while (sair != "SIM" && sair != "S");

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Obrigrado {nome} por usar a calculadora!\nAté a próxima!\n");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Inteligencia Artificial");

            Console.WriteLine(FiggleFonts.Slant.Render("Ryan!!!"));

            Console.Write("## Pressione uma tecla para encerrar..:");
            Console.ReadKey();
        }
    }
}
