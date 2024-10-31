//Importando as classes de dentro da pasta Classes

using System.Net.Http.Headers;
using ClassesObjetos.Classes;

//Criar o objeto/variavel animal
Animal cachorro = new Animal();

cachorro.nome = "Kiara";
cachorro.raca = "Golden";
cachorro.idade = "6";
cachorro.cor = "Dourado";


Console.WriteLine($"Nome do cachorrinho: {cachorro.nome}");
Console.WriteLine($"raca do cachorrinho: {cachorro.raca}");
Console.WriteLine($"idade do cachorrinho: {cachorro.idade}");
Console.WriteLine($"cor do cachorrinho: {cachorro.cor}");

Animal peixe = new Animal();

peixe.nome = "Anna";
peixe.raca = "Telescopio";
peixe.idade = "17";
peixe.cor = "Preto";

Console.WriteLine($"Nome do cachorrinho: {peixe.nome}");
Console.WriteLine($"raca do cachorrinho: {peixe.raca}");
Console.WriteLine($"idade do cachorrinho: {peixe.idade}");
Console.WriteLine($"cor do cachorrinho: {peixe.cor}");