       // Solicitar a média do aluno
        Console.Write("Digite a média do aluno: ");
        double media = double.Parse(Console.ReadLine());

        // Solicitar a frequência do aluno
        Console.Write("Digite a frequência do aluno (em %): ");
        double frequencia = double.Parse(Console.ReadLine());

        // Verificar a frequência do aluno
        if (frequencia < 75)
        {
            Console.WriteLine("Aluno reprovado por frequência insuficiente.");
        
            // Verificar a média do aluno
            if (media >= 7)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media > 3 && media < 7)
            {
                Console.WriteLine("Aluno em recuperação.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado por nota.");
            }
            }