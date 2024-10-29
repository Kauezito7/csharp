        int[] numeros = new int[6];
        int contPares = 0, contImpares = 0;

        
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Digite o número para a posição {0}: ", i);
            numeros[i] = int.Parse(Console.ReadLine()!);
        }

        
        foreach (int numero in numeros)
        {
            if (numero % 2 == 0)
            {
                contPares++;
            }
            else
            {
                contImpares++;
            }
        }

    
        
        Console.WriteLine("\nQuantidade de números pares: " + contPares);
        Console.WriteLine("Quantidade de números ímpares: " + contImpares);
