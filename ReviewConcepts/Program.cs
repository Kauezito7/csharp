// variaveis e tipos de dados
//Criar um cabecalho de boas vindas
//pedir os dados de cadastro
//nome
//data de nascimento
//email
//telefone
//cpf
//endereco
//idade-calcular baseado na data de nascimenro
//estado civil

using System.Security.AccessControl;

Console.WriteLine(@"
+------------------------------------------+
|                                          |
|                                          |
|                  Seja                    |
|                Bem-Vindo                 |
|                                          |
|                                          |
|                                          |
+-----------------------------------------+|");

Console.WriteLine("Olá, digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Agora, por gentileza, digite seu sobrenome");
string sobrenome = Console.ReadLine();

// clw

Console.WriteLine($"Olá, {nome} {sobrenome}!");

Console.WriteLine("Por favor, me diga seu número de telefone: ");
string numeroTelefone = Console.ReadLine();
Console.WriteLine("Digite seu cpf: ");
string CPF = Console.ReadLine();
Console.WriteLine();
Console.Write("Agora, seu estado civíl: ");
string estadoCivil = Console.ReadLine();
Console.Write("Digite seu endereço: ");
string endereco = Console.ReadLine();
// Console.Write("Digite, agora, seu email: ");
string email = Console.ReadLine();
Console.Write("Digite sua data de nascimento, por favor: ");
int DataNascimento = int.Parse(Console.ReadLine());
int anoAtual = DateTime.Now.Year;
int idade = anoAtual - DataNascimento;






