        Console.Write("Digite o número de maçãs compradas: ");
        int quantidadeMacas = int.Parse(Console.ReadLine());

        // Definir o preço baseado na quantidade comprada
        double precoPorMaca;

        if (quantidadeMacas < 12)
        {
            precoPorMaca = 0.30;
        }
        else
        {
            precoPorMaca = 0.25;
        }

        // Calcular o valor total
        double valorTotal = quantidadeMacas * precoPorMaca;

        // Exibir o valor total da compra
        Console.WriteLine("O valor total da compra é: R$ " + valorTotal.ToString("F2"));
     