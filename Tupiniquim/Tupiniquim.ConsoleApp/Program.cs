using System;

namespace Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool resp;
            do {
                Console.Write("Digite a coordenada x do canto superior da área: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a coordenada y do canto superior da área: ");
                double y = Convert.ToDouble(Console.ReadLine());

                String instrucoes;
                double px = 0;
                double py = 0;
                char pontoCardeal;

                Console.Write("Digite a posição inical da coordenada x do robô: ");
                px = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a posição inical da coordenada y do robô: ");
                py = Convert.ToDouble(Console.ReadLine());

                do {
                    Console.Write("Digite a direção inicial do robô (N - Norte/S- Sul/L - Leste/O - Oeste): ");
                    pontoCardeal = Convert.ToChar(Console.ReadLine());
                }while (pontoCardeal != 'N' && pontoCardeal != 'S' && pontoCardeal != 'O'); 
                do { 
                    Console.Write("Digite as isntruções do robô (M - Mover/E - Girar para a esquerda/D - Girar para a direita): ");
                    instrucoes = Convert.ToString(Console.ReadLine());
                } while (instrucoes != "M" && instrucoes != "E" && instrucoes != "D");
                char[] esqDi = instrucoes.ToCharArray();

                for (int i = 0; i < esqDi.Length; i++)
                {
                    while (esqDi[i] == 'E')
                    {
                        switch (pontoCardeal)
                        {
                            case 'N':
                                pontoCardeal = 'O';
                                break;
                            case 'S':
                                pontoCardeal = 'L';
                                break;
                            case 'L':
                                pontoCardeal = 'N';
                                break;
                            case 'O':
                                pontoCardeal = 'S';
                                break;
                        }
                        break;
                    }
                    while (esqDi[i] == 'D')
                    {
                        switch (pontoCardeal)
                        {
                            case 'N':
                                pontoCardeal = 'L';
                                break;
                            case 'S':
                                pontoCardeal = 'O';
                                break;
                            case 'L':
                                pontoCardeal = 'S';
                                break;
                            case 'O':
                                pontoCardeal = 'N';
                                break;
                        }
                        break;
                    }

                    while (esqDi[i] == 'M')
                    {
                        if (pontoCardeal == 'N')
                        {
                            py = py + 1;
                            break;

                        }
                        else
                        {
                            if (pontoCardeal == 'L')
                            {
                                px = px + 1;
                                break;
                            }
                            else
                            {
                                if (pontoCardeal == 'S')
                                {
                                    py = py - 1;
                                    break;
                                }
                                else
                                {
                                    if (pontoCardeal == 'O')
                                    {
                                        px = px - 1;
                                        break;
                                    }
                                }
                            }
                        }
                    } 
                }
                Console.WriteLine(px + " " + py + " " + pontoCardeal);

                Console.Write("Deseja instruir mais um robo? Digite S para sim e N para não: ");
                char continuar = Convert.ToChar(Console.ReadLine());
                
                 resp = continuar == 'S';
  
            } while (resp == true);           
        }
    }
}
