//importanto as classes de dentro da pasta Classes 
using ClassesObjetos.Classes;


//cria/objeto/variável animal 
Animal cachorro = new Animal();

cachorro.nome = "Spaik";
cachorro.raca = "Shihtzu";
cachorro.cor = "Preto e Branco";
cachorro.idade = "5"; 

Console.WriteLine($"Nome do cachorrinho: {cachorro.nome}");
Console.WriteLine($"Idade do cachorrinho: {cachorro.idade}");
Console.WriteLine($"Cor do cachorrinho: {cachorro.cor}");
Console.WriteLine($"Raca do cachorrinho: {cachorro.raca}");

Animal gato = new Animal();

gato.nome = "nino";
gato.raca = "siames";
gato.cor = "cinza";
gato.idade = "1"; 

Console.WriteLine($"Nome do gatinho: {gato.nome}"); 
Console.WriteLine($"Idade do gatinho: {gato.idade}"); 
Console.WriteLine($"Cor do gatinho: {gato.cor}"); 
Console.WriteLine($"Raca do gatinho: {gato.raca}"); 

