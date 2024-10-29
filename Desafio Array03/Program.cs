Desafio array03
floatDesafio array02

int [] arrayNumeros1 = {50,15,41,38,94,36,8,4,11,63}
int [] arrayNumeros2 = {52,39,99,71,82,512,2,7,18,36}
 
for (int i = 0; i< 10; i++)
{
   if (i % 2 == 0)
   {
    Console.WriteLine(vetor1[i]);
   }
   else
   {
    Console.WriteLine(vetor2[i]);

   }
    
}[] temperaturas = new float[12];

        
        for (int i = 0; i < 12; i++)
        {
            Console.Write($"Digite a temperatura média do mês {i + 1}: ");
            temperaturas[i] = Convert.ToSingle(Console.ReadLine());
        }

       
        float maiorTemperatura = temperaturas[0];
        float menorTemperatura = temperaturas[0];

        for (int i = 1; i < 12; i++)
        {
            if (temperaturas[i] > maiorTemperatura)
                maiorTemperatura = temperaturas[i];
            if (temperaturas[i] < menorTemperatura)
                menorTemperatura = temperaturas[i];
        }

        
        Console.WriteLine($"A maior temperatura do ano foi: {maiorTemperatura}°C");
        Console.WriteLine($"A menor temperatura do ano foi: {menorTemperatura}°C");



