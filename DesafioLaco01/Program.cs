int totalSim = 0;
        int totalNao = 0;
        int totalMulheresSim = 0;

        
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"\nEntrevistado {i + 1}:");

            
            Console.Write("Digite o sexo (M para masculino, F para feminino): ");
            char sexo = char.ToUpper(Console.ReadLine()[0]);

           
            Console.Write("Gostou do produto? (S para sim, N para não): ");
            char resposta = char.ToUpper(Console.ReadLine()[0]);

          
            if (resposta == 'S')
            {
                totalSim++;
                if (sexo == 'F')
                {
                    totalMulheresSim++;
                }
            }
            else if (resposta == 'N')
            {
                totalNao++;
            }
            else
            {
                Console.WriteLine("Resposta inválida! Por favor, insira S ou N.");
            }
        }

        
        Console.WriteLine($"\nNúmero de pessoas que responderam SIM: {totalSim}");
        Console.WriteLine($"Número de pessoas que responderam NÃO: {totalNao}");
        Console.WriteLine($"Número de mulheres que responderam SIM: {totalMulheresSim}")