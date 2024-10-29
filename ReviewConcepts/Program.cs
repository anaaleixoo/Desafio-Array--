//1-Criar um cabeçalho de boas vindas.
//2-Pedir os dados de cadastro.
//nome
//data de nascimento
//email
//telefone
//cpf
//endereço
//idade - calcular baseado na data de nascimento
//Estado civil



Console.WriteLine(@"
+--------------------------------------------+
|                                            |
|                                            |
|                  Seja bem                  |           
|                   Vindo!!!                 |
|                                            |
|                                            |
+--------------------------------------------+

");


Console.WriteLine($"Ola, digite seu nome: ");
string nome = Console.ReadLine()!;
Console.WriteLine($"Agora digite seu sobrenome: ");
string sobrenome = Console.ReadLine()!;


Console.WriteLine($"Digite sua data de Nascimento: ");
string DataNascimento = Console.ReadLine()!;

Console.WriteLine($"Digite seu email: ");
string email = Console.ReadLine();


Console.WriteLine($"Digite seu CPF: ");
string cpf = Console.ReadLine();



//mostrar esses dados cadastrados
// estruturas condicionais
// lacos de repeticao
// arrays

Console.WriteLine($"Qual é o seu telefone?");
UInt128 telefone = UInt128.Parse(Console.ReadLine()!);

Console.WriteLine($"Qual é o seu endereço?");
string endereco = Console.ReadLine()!;

Console.WriteLine($"Qual é o seu estado civil?");
string estadoCivil = Console.ReadLine()!;

Console.WriteLine($"Em que ano voce nasceu");
int anoNascimento = int.Parse(Console.ReadLine());
int anoAtual = DateTime.Now.Year;
int idade = anoAtual - anoNascimento;