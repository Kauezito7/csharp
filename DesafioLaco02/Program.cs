        int totalHomens = 0;
        int totalMulheres = 0;
        int somaIdadeHomens = 0;
        int somaIdadeMulheres = 0;

        as
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"\nPessoa {i + 1}:");

            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o peso: ");
            float peso = float.Parse(Console.ReadLine());

            Console.Write("Digite o sexo (M para masculino, F para feminino): ");
            char sexo = char.ToUpper(Console.ReadLine()[0]);

            if (sexo == 'M')
            {
                totalHomens++;
                somaIdadeHomens += idade;
            }
            else if (sexo == 'F')
            {
                totalMulheres++;
                somaIdadeMulheres += idade;
            }
            else
            {
                Console.WriteLine("Sexo inválido! Por favor, insira M ou F.");
            }
        }

    
        double mediaIdadeHomens = totalHomens > 0 ? (double)somaIdadeHomens / totalHomens : 0;
        double mediaIdadeMulheres = totalMulheres > 0 ? (double)somaIdadeMulheres / totalMulheres : 0;

    
        Console.WriteLine($"Total de Homens: {totalHomens}");
        Console.WriteLine($"Total de Mulheres: {totalMulheres}");
        Console.WriteLine($"Média de idade dos Homens: {mediaIdadeHomens}");
        Console.WriteLine($"Média de idade das Mulheres: {mediaIdadeMulheres}");
    