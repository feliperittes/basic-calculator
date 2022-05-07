namespace Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Olá tudo bem?\n\nVamos calcular?");

            Console.Write("Insira: \n[1] para SOMA \n[2] para SUBTRAÇÃO \n[3] para MULTIPLICAÇÃO \n[4] para DIVISÃO \n[5] para SAIR\n>");
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Soma(); break;
                case 2:
                    Subtrair(); break;
                case 3:
                    Multiplicacao(); break;
                case 4:
                    Divisao(); break;
                case 5:
                    System.Environment.Exit(0); break;
                default:
                    Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Você selecionou a opção: [1] para SOMA");

            float primeiroValor, segundoValor;

            Console.Write("Insira o primeiro valor: \n>");
            primeiroValor = float.Parse(Console.ReadLine());

            Console.Write("Insira o primeiro valor: \n>");
            segundoValor = float.Parse(Console.ReadLine());

            float respostaSoma = primeiroValor + segundoValor;
            Console.Write($"O resultado da Soma foi: {respostaSoma}");

            Console.ReadKey();
            Menu();
        }

        static void Subtrair()
        {
            Console.Clear();

            Console.WriteLine("Você selecionou a opção: [2] para SUBTRAÇÃO");

            float primeroValor, segundoValor;

            Console.Write("Insira o primeiro valor: \n>");
            primeroValor = float.Parse(Console.ReadLine());

            Console.Write("Insira o segundo valor: \n>");
            segundoValor = float.Parse(Console.ReadLine());

            float respostaSubtracao = primeroValor - segundoValor;
            Console.Write($"O resultado da Subtração foi:  {respostaSubtracao}");

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Você selecionou a opção: [3] para MULTIPLICAÇÃO");
            float primeiroValor, segundoValor;

            Console.Write("Insira o primeiro valor: \n>");
            primeiroValor = float.Parse(Console.ReadLine());

            Console.Write("Insira o segundo valor: \n>");
            segundoValor = float.Parse(Console.ReadLine());

            float respostaMultiplicacao = primeiroValor * segundoValor;
            Console.Write($"O resultado da Multiplicação foi: {respostaMultiplicacao}");

            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Você selecionou a opção: [2] para DIVISÃO");

            float primeiroValor, segundoValor;

            Console.Write("Insira o primeiro valor: \n>");
            primeiroValor = float.Parse(Console.ReadLine());

            Console.Write("Insira o segundo valor: \n>");
            segundoValor = float.Parse(Console.ReadLine());

            float respostaDivisao = primeiroValor / segundoValor;

            Console.WriteLine($"A resposta da Divisão foi: {respostaDivisao}");

            Console.ReadKey();
            Menu();
        }
    }
}
