using System;

namespace _Exercicios_C_
{
    class Program
    {
        static void Main(string[] args)
        {

            // // FIBONACCI

            Console.WriteLine("Esta é a sequência de Fibonacci");
            Console.WriteLine("Deseja Iniciar ? (sim) (nao)");
            string continuar = Console.ReadLine();
               
                int num1 = 0;
                int num2 = 1;
                int num3 = 1;
            
            while (continuar == "sim" || continuar == "s" || continuar == "si" || continuar == "yes") {
                
                Console.Write ($"{num1}, {num2}, {num3}, ");

                num1 = num2 + num3;
                num2 = num1 + num3;
                num3 = num1 + num2;

                Console.WriteLine("Deseja Continuar? (sim) (nao)");
                continuar = Console.ReadLine();

            }

            // // VALIDAÇÃO

            // string nome = "";
            // int idade = 0;
            // double salario = 0;
            // string ec = "";

            // do
            // {
            //     Console.Write("Digite o seu nome: ");
            //     nome = Console.ReadLine();

            //     if (nome == "") {

            //         Console.WriteLine("Por favor, Preencha o campo (nome)");

            //     }

            // } while (nome == "");
            
            // do
            // {
            //     Console.Write("Digite o sua idade: ");
            //     idade = int.Parse( Console.ReadLine() );

            //     if ( idade < 0 || idade > 150 ) {

            //         Console.WriteLine("Por favor, Preencha o campo (idade) com um valor válido");
            //         Console.WriteLine($"Nome: {nome}");
                    
            //     }

            // } while ( idade < 0 || idade > 150 );

            // do
            // {
            //     Console.Write("Digite o seu salário: R$ ");
            //     salario = double.Parse( Console.ReadLine() );

            //     if ( salario < 0 ) {

            //         Console.WriteLine("Por favor, Preencha o campo (idade) com um valor válido");
            //         Console.WriteLine($"Nome: {nome}");
            //         Console.WriteLine($"Idade: {idade}");

            //     }

            // } while ( salario < 0 );

            // do
            // {
            //     Console.Write("Digite o seu Estado civil ('s' solteiro(a), 'd' divorciado(a), 'v' viúvo(a), 'c' casado(a) ): ");
            //     ec = Console.ReadLine();

            //     if ( ec == "" ) {

            //         Console.WriteLine("Por favor, Preencha o campo (Estado Civil)");
            //         Console.WriteLine($"Nome: {nome}");
            //         Console.WriteLine($"Idade: {idade}");
            //         Console.WriteLine($"salario: R$ {salario}");
                    
            //     }

            // } while ( ec == "" );

            // Console.WriteLine($"Nome: {nome}");
            // Console.WriteLine($"Idade: {idade}");
            // Console.WriteLine($"salario: R$ {salario}");
            // Console.WriteLine($"Estado Cívil: {ec}");
            
            // // USUARIO E SENHA

            // string user = "" ;
            // string pass = "" ;

            // while ( user == pass ) {

            //     Console.Write("Insira um nome de usuario: ");
            //     user = Console.ReadLine();
                
            //     Console.Write("Insira uma senha: ");
            //     pass = Console.ReadLine();

            //     if ( user == pass ) {

            //         Console.WriteLine("Usuário ou senha inválidos");
            //         Console.WriteLine("Tente novamente");

            //     }

            // }

            // Console.WriteLine("Cadastro Concluido");
            // Console.WriteLine("-----------------------------------");
            // Console.WriteLine("Login");
            // Console.Write("Usuário: ");
            // Console.ReadLine();
            // Console.Write("Senha: ");
            // Console.ReadLine();
            // Console.WriteLine("Entrando ...");
            // Console.WriteLine("-------------------------");
            // Console.WriteLine("--------Bem-Vindo--------");
            // Console.WriteLine("-------------------------");


            // DE 0 A 10

            // double num;

            // do {
                
            // Console.Write("Digite um número: ");
            // num = double.Parse( Console.ReadLine() );

            // if (num < 0 || num > 10) {
                
            //     Console.WriteLine("Número inválido");
            //     Console.WriteLine("Tente novamente");

            // }
                
            // } while (num < 0 || num > 10);

            //     Console.Write($"O numero {num} é um número válido");
        }
    }
}
