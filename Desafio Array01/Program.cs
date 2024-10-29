int numeroImpar = 0;
int numeroPar = 0; 



int[] numeros = new int[6];
for ( int i = 0; i < 6; i++)
{
    Console.WriteLine($"Digite um numero inteiro:");
    numeros[i]= int.Parse(Console.ReadLine());

    if (numeros[i] % 2 == 0)
    {
        numeroPar++;
       

    }
    else
    {
        numeroImpar++;
        
    }
}

Console.WriteLine($"  {Par} numeros pares ");
for (int i = 0; i < numeros.Length; i++)
{
     if (numeros[i] % 2 == 0)
    {
       Console.WriteLine($"{numeros[i]}");

    }
    
}

 Console.WriteLine();
 Console.WriteLine();


Console.WriteLine($"  {Impar} numeros impares");
for (int i = 0; i < numeros.Length; i++)
{
     if (numeros[i] % 2 == 1)
    {
        numeroImpar++;
        Console.WriteLine($"{numeros[i]}");
       
    }
}
