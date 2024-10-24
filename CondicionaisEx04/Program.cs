        int senhaCorreta = 1234;

        // Solicitar a senha do usuário
        Console.Write("Digite a senha: ");
        int senhaDigitada = int.Parse(Console.ReadLine());

        // Verificar se a senha está correta
        if (senhaDigitada == senhaCorreta)
        {
            Console.WriteLine("ACESSO PERMITIDO");
        }
        else
        {
            Console.WriteLine("ACESSO NEGADO");
        }