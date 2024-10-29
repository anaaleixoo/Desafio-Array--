// DEsenvolva um programa que recebe do usuario, o placar de um jogo de futebol (os gols de cada time) e informe se o resultado foi um empate, se a vitoria foi do primeiro time ou do segundo time.

 // Solicita os gols do primeiro time
            Console.Write("Digite o número de gols do primeiro time: ");
            int golsTime1 = int.Parse(Console.ReadLine());

            // Solicita os gols do segundo time
            Console.Write("Digite o número de gols do segundo time: ");
            int golsTime2 = int.Parse(Console.ReadLine());

            // Verifica o resultado
            if (golsTime1 > golsTime2)
            {
                Console.WriteLine("O primeiro time venceu!");
            }
            else if (golsTime1 < golsTime2)
            {
                Console.WriteLine("O segundo time venceu!");
            }
            else
            {
                Console.WriteLine("O jogo terminou em empate!");
            }

