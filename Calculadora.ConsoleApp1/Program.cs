namespace Calculadora.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vetores
            //array mini memoria
            string[] historicoOperacoes = new string[100];
            int contadorHistorico = 0;



            while (true)
            {

                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Calculadora Tabajara 2025!");
                Console.WriteLine("---------------------------------------------");


                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Tabuada");
                Console.WriteLine("6 - Historico de operações");
                Console.WriteLine("S - Sair");
                string opcao = Console.ReadLine();

                if (opcao == "S" || opcao == "s")
                    break;
                //pausa    
                //sem chaves o if so executa essa uma linha


                else if (opcao == "5")
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Tabuada");
                    Console.WriteLine("---------------------------------------------");

                    Console.Write("Digite o numero desjado: ");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());
                    // 1 - contador variavel de controle
                    // 2 - condição
                    // 3 - mecanismo de incrementação
                    // 1 x 1 = 1
                    // 1 x 2 = 2
                    // syntatic sugar
                    for (int contador = 1; contador <= 10; contador++)
                    {

                        int resultadoMultiplicao = numeroTabuada * contador;

                        string linhaDaTabuada = $"{numeroTabuada} * {contador} = {resultadoMultiplicao}"; // interpolamento
                        Console.WriteLine(linhaDaTabuada);

                    }

                    Console.ReadLine();

                    continue;
                }

                else if (opcao == "6")
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Historico de operações");
                    Console.WriteLine("---------------------------------------------");
                

                    for (int contador = 0; contador <= contadorHistorico; contador++)
                        Console.WriteLine(historicoOperacoes[contador]);

                    Console.ReadLine();
                    continue;
                }


                    Console.WriteLine("---------------------------------------------");
                    Console.Write("Digite o primeiro numero: ");
                    decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());



                    Console.Write("Digite o segundo numero: ");
                    decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

                    decimal resultado = 0.0m;

                    // estrutura de decisao // se
                    if (opcao == "1")
                    {
                        resultado = primeiroNumero + segundoNumero;
                        historicoOperacoes[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
                        //soma
                    }
                    else if (opcao == "2")
                    {
                        resultado = primeiroNumero - segundoNumero;
                        historicoOperacoes[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";
                        //subtracao
                    }
                    else if (opcao == "3")
                    {
                        resultado = primeiroNumero * segundoNumero;
                        historicoOperacoes[contadorHistorico] = $"{primeiroNumero} * {segundoNumero} = {resultado}";
                        //subtracao
                    }
                    else if (opcao == "4")
                    {
                        while (segundoNumero == 0)
                        {
                            Console.WriteLine("Digite o segundo numero novamente: ");

                            segundoNumero = Convert.ToDecimal(Console.ReadLine());
                        }


                        resultado = primeiroNumero / segundoNumero;
                        historicoOperacoes[contadorHistorico] = $"{primeiroNumero} / {segundoNumero} = {resultado}";
                    }
                    //div

                    else
                        continue;

                    contadorHistorico++;



                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Resultado: " + resultado.ToString("F2"));
                    // floating points 2 pontos flutuantes depois da virgula
                    Console.WriteLine("---------------------------------------------");
                    Console.ReadLine();


                

            }
        }
    }
}
