using AtividadeClasses;


Console.WriteLine($"Bem-Vindo ao programa veiculos");

Veiculo veiculo = new Veiculo();

Console.Write("Digite a marca do veículo: ");
veiculo.marca = Console.ReadLine();

Console.Write("Digite o modelo do veículo: ");
veiculo.modelo = Console.ReadLine();

Console.Write("Digite a cor do veículo: ");
veiculo.cor = Console.ReadLine();

Console.Write("Digite a potência do veículo (em CV): ");
veiculo.potencia = int.Parse(Console.ReadLine());

Console.Write("Digite a quantidade de portas do veículo: ");
veiculo.quantidadePortas = int.Parse(Console.ReadLine());

Console.WriteLine("Propriedades do Veículo:");
Console.WriteLine($"Marca: {veiculo.marca}");
Console.WriteLine($"Modelo: {veiculo.modelo}");
Console.WriteLine($"Cor: {veiculo.cor}");
Console.WriteLine($"Potência: {veiculo.potencia} ");
Console.WriteLine($"Quantidade de Portas: {veiculo.qntdPortas} ");
