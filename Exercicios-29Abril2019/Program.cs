using System;

namespace TP_29Abril2019
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCICIO 02 
            Console.WriteLine("Calcular e exibir a soma dos “N” primeiros valores da sequência abaixo. " +
                "O valor “N” será digitado, deverá ser positivo, mas menor que vinte. Caso o valor não satisfaça a restrição, " +
                "enviar mensagem de erro e solicitar o valor novamente.");

            int num02;
            float cont02, contA02 = 1, formula02 = 0, soma02 = 0;
            Console.WriteLine("Digite um valor:");
            num02 = int.Parse(Console.ReadLine());
            while (num02 <= 0 || num02 >= 20)
            {
                Console.WriteLine("Digite um valor Positivo e abaixo de 20 :"); // mensagem de erro e usuario repita o erro
                num02 = int.Parse(Console.ReadLine());
            }

            for (cont02 = 1; cont02 <= num02; cont02++, contA02++)
            {
                soma02 = contA02 + 1;
                formula02 = formula02 + (contA02 / soma02);
            }
            Console.WriteLine(formula02);
            Console.ReadKey();
            Console.Clear();

            // EXERCICO 3 

            Console.WriteLine("Calcular e exibir a soma dos “N” primeiros valores da sequência abaixo. " +
                "O valor “N” será digitado, deverá ser positivo, mas menor que cinquenta. " +
                "Caso o valor não satisfaça a restrição, enviar mensagem de erro e solicitar o valor novamente.");

            Console.WriteLine("Digite o valor ");
            int valor03 = int.Parse(Console.ReadLine());
            float cima03 = 1, baixo03, formula03 = 0;
            while (valor03 >= 50)
            {
                Console.WriteLine("Erro Digite o valor positivo menor que 50");
                valor03 = int.Parse(Console.ReadLine());
            }

            for (int cont03 = 1; valor03 + 1 != cont03; cont03++)
            {
                cima03 = (float)Math.Pow(cont03, 2) + 1;
                baixo03 = (float)Math.Pow(cont03, 3);
                formula03 = formula03 + (cima03 / baixo03);


            }
            Console.WriteLine(formula03);
            Console.ReadKey();
            Console.Clear();

            //EXERCICIO 04 

            Console.WriteLine("Calcular o fatorial de um valor que será digitado. " +
                "Este valor não poderá ser negativo. " +
                "Enviar mensagem de erro e solicitar o valor novamente, se necessário." +
                " Perguntar se o usuário deseja ou não fazer um novo cálculo, consistir a resposta em “S” ou “N”.");
            char resposta;
            int numero03, formula04 = 0;
            do
            {
                Console.WriteLine("Digite o valor");
                numero03 = int.Parse(Console.ReadLine());
                while (numero03 <= 0)
                {
                    Console.WriteLine("Erro - O valor não poderá ser negativo \nDigite o valor novamente: ");
                    numero03 = int.Parse(Console.ReadLine());
                }

                for (int i = numero03 - 1; i != 0; i--)
                {

                    formula04 = numero03 * i;
                    numero03 = formula04;


                }

                Console.WriteLine(formula04);
                Console.WriteLine("Deseja realizar um novo calculo: ");
                resposta = char.Parse(Console.ReadLine().ToUpper());
            }
            while (resposta == 'S');

            //EXERCICIO 05
            Console.WriteLine("Desenvolva um programa que calcule a soma dos algarismos de um número inteiro N digitado via teclado.");
            int num05, soma05 = 0, somaA05;
            int formula05;
            Console.WriteLine("Digite o valor ");
            num05 = int.Parse(Console.ReadLine());

            do
            {
                formula05 = num05 / 10;
                somaA05 = num05 % 10;
                num05 = formula05;
                soma05 = soma05 + somaA05;
            } while (formula05 != 0);
            Console.WriteLine(soma05);
            Console.ReadKey();

            // EXERCICIO 06

            Console.WriteLine("A prefeitura de uma cidade fez uma pesquisa entre seus 500 habitantes," +
                " coletando dados sobre o salário e o número de filhos:");
            int filho;
            float media_salario = 0, media_filhos = 0, maior_salario = 0, salario;
            float porcentagem = 0;
            int NumeroDePessoas = 500;
            for (int i = 0; i != NumeroDePessoas; i++)
            {

                Console.WriteLine("Digite o seu Salario");
                salario = int.Parse(Console.ReadLine());
                while (salario <= 0)
                {
                    Console.WriteLine("Erro - Valor não pode ser negativo \nDigite o seu Salario");
                    salario = int.Parse(Console.ReadLine());

                }
                Console.WriteLine("Digite o numero de filhos: ");
                filho = int.Parse(Console.ReadLine());
                while (filho <= 0)
                {
                    Console.WriteLine("Erro - Valor não pode ser negativo \nDigite o numero de filhos ");
                    filho = int.Parse(Console.ReadLine());

                }

                media_salario = media_salario + salario;
                media_filhos = media_filhos + filho;
                if (salario > maior_salario || maior_salario == 0)
                {
                    maior_salario = salario;
                }

                if (salario <= 1000)
                {
                    porcentagem = porcentagem + 1;
                }



            }

            media_salario = media_salario / NumeroDePessoas;
            media_filhos = media_filhos / NumeroDePessoas;
            porcentagem = (porcentagem / (float)NumeroDePessoas) * 100;
            Console.WriteLine("A média dos salários da população: " + media_salario);
            Console.WriteLine("A média dos números de filhos: " + media_filhos);
            Console.WriteLine("Maior salário: " + maior_salario);
            Console.WriteLine("Porcentagem de pessoas com salários até R$ 1.000,00: " + porcentagem);
            Console.ReadKey();


            //EXERCICIO 07 

            Console.WriteLine("Um supermercado deseja facilitar o trabalho de seus caixas utilizando um computador para calcular quantas moedas de cada espécie devem ser devolvidas como troco. " +
                "Desenvolva um programa para que o caixa digite o valor da compra," +
                " a quantia dada para pagamento e que após o processamento exiba no monitor o número de moedas a ser devolvida de cada espécie.");
            Console.WriteLine("Insira o valor da compra  : ");
            float resto1 = 0;
            float compra = float.Parse(Console.ReadLine());
            while (compra <= 0)
            {
                Console.WriteLine("Erro - O valor deverá ser positivo\nInsira o valor : ");
                compra = float.Parse(Console.ReadLine());

            }

            do
            {
                Console.WriteLine("Informe o valor do pagamento: ");
                float pagamento = float.Parse(Console.ReadLine());


                while (pagamento <= 0)
                {
                    Console.WriteLine("Erro - O valor deverá ser positivo\nInsira o valor : ");
                    pagamento = float.Parse(Console.ReadLine());

                }



                resto1 = pagamento - compra;
                if (resto1 <= 0)
                {
                    Console.WriteLine("Está faltando R$ " + resto1);
                }

            } while (resto1 <= 0);


            {
                Console.WriteLine("Está faltando R$ " + resto1);
            }


            float resto = resto1 * 100f;
            int moeda, formula07;

            moeda = 100;
            formula07 = (int)resto / moeda;
            Console.WriteLine(formula07 + " moeda(s) de R$ 1.00");
            resto = resto % moeda;

            moeda = 50;
            formula07 = (int)resto / moeda;
            Console.WriteLine(formula07 + " moeda(s) de R$ 0.50");
            resto = resto % moeda;

            moeda = 25;
            formula07 = (int)resto / moeda;
            Console.WriteLine(formula07 + " moeda(s) de R$ 0.25");
            resto = resto % moeda;

            moeda = 10;
            formula07 = (int)resto / moeda;
            Console.WriteLine(formula07 + " moeda(s) de R$ 0.10");
            resto = resto % moeda;

            moeda = 5;
            formula07 = (int)resto / moeda;
            Console.WriteLine(formula07 + " moeda(s) de R$ 0.05");
            resto = resto % moeda;

            moeda = 1;
            formula07 = (int)resto / moeda;
            Console.WriteLine(formula07 + " moeda(s) de R$ 0.01");
            resto = resto % moeda;

            Console.ReadKey();

            //EXERCICIO 8

            Console.WriteLine("Uma pessoa faz uma aplicação no valor de R$ 2.000,00 durante 11 meses, " +
                "a uma taxa de juros compostos de 5% a.m., " +
                "capitalizados mensalmente. Calcular o montante no final do prazo.");

            float valor, JurosAoMes, juros;
            int meses;
            valor = 2000f;
            meses = 11;
            juros = 0.05f;

            for (int i = 0; i != meses; i++)
            {
                JurosAoMes = valor * juros;

                valor += JurosAoMes;

            }
            Console.WriteLine("O Valor é de R$ " + valor.ToString("F2"));
            Console.ReadKey();





        }
    }
}
