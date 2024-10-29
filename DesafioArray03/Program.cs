
        float[] temperaturas = new float[12];

       
        for (int i = 0; i < 12; i++)
        {
            Console.Write($"Digite a temperatura média do mês {i + 1}: ");
            temperaturas[i] = float.Parse(Console.ReadLine());
        }

      
        float maiorTemperatura = temperaturas[0];
        float menorTemperatura = temperaturas[0];

      
        foreach (float temp in temperaturas)
        {
            if (temp > maiorTemperatura)
                maiorTemperatura = temp;

            if (temp < menorTemperatura)
                menorTemperatura = temp;
        }

        
        Console.WriteLine($"\nA maior temperatura do ano foi: {maiorTemperatura}°C");
        Console.WriteLine($"A menor temperatura do ano foi: {menorTemperatura}°C");
