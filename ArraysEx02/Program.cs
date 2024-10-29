        int[] vetor1 = new int[10];
        int[] vetor2 = new int[10];
        int[] vetorIntercalado = new int[20];

       
        Console.WriteLine("Digite os 10 números para o primeiro vetor:");
        for (int i = 0; i < vetor1.Length; i++)
        {
            Console.Write("Elemento {0}: ", i + 1);
            vetor1[i] = int.Parse(Console.ReadLine());
        }

       
        Console.WriteLine("\nDigite os 10 números para o segundo vetor:");
        for (int i = 0; i < vetor2.Length; i++)
        {
            Console.Write("Elemento {0}: ", i + 1);
            vetor2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0, j = 0; i < 10; i++, j += 2)
        {
            vetorIntercalado[j] = vetor1[i];     
            vetorIntercalado[j + 1] = vetor2[i]; 
        }

       
        Console.WriteLine("\nVetor intercalado:");
        foreach (int num in vetorIntercalado)
        {
            Console.Write(num + " ");
        }
