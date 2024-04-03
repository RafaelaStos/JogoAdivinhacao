using System;

namespace JogoAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Decimal pontuacao = 1000;
            int aleatorio = ObterNumeroAleatorio();



            MostrarMenu();
            int opcao = ObterNIvelDificuldade();

            int tentativas = ObterTEntativas(opcao);


            for (int cont = 1; cont <= tentativas; cont++)
            {
                Console.Clear();
                Console.WriteLine($"\nTentativas {cont} de {tentativas}");
                Console.WriteLine("---------------------------");
                int chute = ObterChute();

                if (chute == aleatorio)
                {
                    break;
                }
                else if (chute > aleatorio)

                    Console.WriteLine($"\nSeu chute foi maior que o número secreto.");

                else if (chute < aleatorio)
                    Console.WriteLine($"\nSeu chute foi menor que o número secreto.");


                pontuacao = CalcularPontuacao(pontuacao, aleatorio, chute);

                Console.WriteLine();


            }
        }

        private static int ObterChute()
        {
            Console.Write("\nDigite seu chute de 1 à 20:");
            int chute = Convert.ToInt32(Console.ReadLine());
            return chute;
        }

        private static decimal CalcularPontuacao(decimal pontuacao, int aleatorio, int chute)
        {
            decimal totalErros = Math.Abs((chute - aleatorio) / 2);
            pontuacao -= totalErros;

            Console.WriteLine($"Você fez {totalErros} pontos!");
            return pontuacao;
        }

        private static int ObterTEntativas(int opcao)
        {
            int qtdChute = 0;
            switch (opcao)

            {
                case 1:
                    qtdChute = 15;
                    break;

                case 2:
                    qtdChute = 10;
                    break;

                case 3:
                    qtdChute = 5;
                    break;
            }
            return qtdChute;
        }


        private static int ObterNumeroAleatorio()
        {
            //Random numAleatorio = new Random();

            return 9;
        }

        static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("************************************");
            Console.WriteLine("* Bem-Vindo ao Jogo de Adivinhação *");
            Console.WriteLine("************************************");


        }

        private static int ObterNIvelDificuldade()
        {
            Console.WriteLine("\nEscolha o nivem de dificuldade");
            Console.WriteLine("(1)Fácil \t(2)Médio \t(3) dificil");

            int opcao = Convert.ToInt32(Console.ReadLine());

            return opcao;
        }


    }
}
