int qntHomem = 0;
int qntMulher = 0;
int Esportes = 0;
int qntnGostaDeEsportes = 0;

Console.WriteLine($"Quantas pessoas tem na sua mesa?");
int qntDeEntrevistados = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= qntDeEntrevistados; i++)
{
    Console.WriteLine($"Qual e o seu sexo? m/f");
    string sexo = Console.ReadLine();

    if (sexo == "f")
    {
        qntMulher++;
    }
    else
    {
        qntHomem++;
    }

    Console.WriteLine($"Voce gosta de Esportes? sim");
    string Resposta = Console.ReadLine();
    if (Resposta == "sim")
    {
        Esportes++;
    }
    else 
    {
        qntnGostaDeEsportes++;
    }
    }
    float percentual = (100 / qntDeEntrevistados) * Esportes;





Console.WriteLine($"Quantidades de pessoas com o sexo feminino {qntMulher}");
Console.WriteLine($"Quantidades de pessoas com o sexo masculino {qntHomem}");
Console.WriteLine($"Quantidades de pessoas que gostam de esportes {Esportes}");
Console.WriteLine($"Quantidades de pessoas que nao gosta de esportes {qntnGostaDeEsportes}");
Console.WriteLine($"Percentual de pessoas que nao gosta de esportes {percentual} %");




