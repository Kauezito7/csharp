using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using ClassesObjetos.Classes;

//Criar o objeto/variavel animal
Animal cachorro = new Animal();

cachorro.nome = "Kiara";
cachorro.raca = "Golden";
cachorro.idade = 6;
cachorro.cor = "Dourado";

Console.WriteLine($"Nome do cachorrinho: {cachorro.nome}");
Console.WriteLine($"raca do cachorrinho: {cachorro.raca}");
Console.WriteLine($"idade do cachorrinho: {cachorro.idade}");
Console.WriteLine($"cor do cachorrinho: {cachorro.cor}");

Animal peixe = new Animal();

peixe.nome = "Anna";
peixe.raca = "Telescopio";
peixe.idade = 17;
peixe.cor = "Preto";

Console.WriteLine($"Nome do cachorrinho: {peixe.nome}");
Console.WriteLine($"raca do cachorrinho: {peixe.raca}");
Console.WriteLine($"idade do cachorrinho: {peixe.idade}");
Console.WriteLine($"cor do cachorrinho: {peixe.cor}");

 cachorro.FazerBarulho("Au Au");
 Console.WriteLine($"Idade de {cachorro.nome} e {cachorro.idade}");
 cachorro.Envelhecer();
 Console.WriteLine($"Nova idade de {cachorro.nome} e {cachorro.idade}");


 cachorro.FazerBarulho("plu plu");
 Console.WriteLine($"Idade de {peixe.nome} e {peixe.idade}");
 cachorro.Envelhecer();
 Console.WriteLine($"Nova idade de {peixe.nome} e {peixe.idade}");
 