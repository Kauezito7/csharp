
        int[] vetor1 = new int[10];
        int[] vetor2 = new int[10];
        int[] vetorIntercalado = new int[20]; 

       
        Console.WriteLine("Digite 10 números para o vetor 1:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            vetor1[i] = int.Parse(Console.ReadLine());
        }

       
        Console.WriteLine("Digite 10 números para o vetor 2:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            vetor2[i] = int.Parse(Console.ReadLine());
        }

       
        for (int i = 0; i < 10; i++)
        {
            vetorIntercalado[i * 2] = vetor1[i];
            vetorIntercalado[i * 2 + 1] = vetor2[i];
        }

      
        Console.WriteLine("Vetor intercalado:");
        foreach (int num in vetorIntercalado)
        {
            Console.Write(num + " ");
        }
    
