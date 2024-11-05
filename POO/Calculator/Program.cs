namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.WriteLine("Digite o primeiro número:");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            float numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação (1 - Somar, 2 - Subtrair, 3 - Divisao, 4 - Multiplicacao):");
            int operacao = int.Parse(Console.ReadLine());
        }
    }
}