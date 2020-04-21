using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Velha
{
    class Program
    {
        static void Main(string[] args)

        {
            string[,] matriz = new string[3, 3];

            matriz[0, 0] = "1";
            matriz[0, 1] = "2";
            matriz[0, 2] = "3";
            matriz[1, 0] = "4";
            matriz[1, 1] = "5";
            matriz[1, 2] = "6";
            matriz[2, 0] = "7";
            matriz[2, 1] = "8";
            matriz[2, 2] = "9";

            bool verificador = false;
            int contEmpt = 0;
            string ganhador, resp, jogador, deep = "";
            ganhador = "...";
            jogador = "X";
            do
            {
               /* Console.WriteLine("| " + matriz[0, 0] + " | " + matriz[0, 1] + " | " + matriz[0, 2] + " |");
                Console.WriteLine("| " + matriz[1, 0] + " | " + matriz[1, 1] + " | " + matriz[1, 2] + " |");
                Console.WriteLine("| " + matriz[2, 0] + " | " + matriz[2, 1] + " | " + matriz[2, 2] + " |");
                */
                for (int cont1 = 0; cont1 < 3; cont1++)
                {
                    for ( int cont2 = 0; cont2 < 3; cont2++)
                    {
                        if ((cont2 == 0))
                        {
                            Console.WriteLine("-----------------");
                        }
                        Console.Write("| " + matriz[cont1, cont2] + " | ");
                    }
                    Console.WriteLine();
                    if (cont1 == 2)
                    {
                        Console.WriteLine("-----------------");
                    }
                }
                Console.Write("Deseja marcar " + jogador + " em qual posição?");
                resp = Console.ReadLine();
                if (resp != "1" && resp != "2" && resp != "3" && resp != "4" && resp != "5" && resp != "6" && resp != "7" && resp != "8" && resp != "9")
                {
                    Console.Clear();
                    Console.WriteLine("Apenas valores do TABULEIRO!");
                }
                else
                {
                    switch (resp)
                    {
                        case "1":
                            matriz[0, 0] = jogador;
                            contEmpt = ++contEmpt;
                            Console.Clear();
                            break;
                        case "2":
                            matriz[0, 1] = jogador;
                            contEmpt = ++contEmpt;
                            Console.Clear();
                            break;
                        case "3":
                            matriz[0, 2] = jogador;
                            contEmpt = ++contEmpt;
                            Console.Clear();
                            break;
                        case "4":
                            matriz[1, 0] = jogador;
                            contEmpt = ++contEmpt;
                            Console.Clear();
                            break;
                        case "5":
                            matriz[1, 1] = jogador;
                            contEmpt = ++contEmpt;
                            Console.Clear();
                            break;
                        case "6":
                            matriz[1, 2] = jogador;
                            contEmpt = ++contEmpt;
                            Console.Clear();
                            break;
                        case "7":
                            matriz[2, 0] = jogador;
                            contEmpt = ++contEmpt;
                            Console.Clear();
                            break;
                        case "8":
                            matriz[2, 1] = jogador;
                            contEmpt = ++contEmpt;
                            Console.Clear();
                            break;
                        case "9":
                            matriz[2, 2] = jogador;
                            contEmpt = ++contEmpt;
                            Console.Clear();
                            break;
                    }

                    // Condição de Vitoria por Diagonais para X

                    if ((matriz[0, 0] == "X") & (matriz[1, 1] == "X") & (matriz[2, 2] == "X"))
                    {
                        ganhador = "X";
                        deep = " pelas diagonais";
                        verificador = true;
                    }
                    else if ((matriz[2,0] == "X") & (matriz[1,1] == "X") & (matriz[0,2] == "X"))
                    {
                        ganhador = "X";
                        deep = " pelas diagonais";
                        verificador = true;
                    }

                    // Condição de Vitoria por Linhas para X

                    if ((matriz[0, 0] == "X") & (matriz[0, 1] == "X") & (matriz[0, 2] == "X"))
                    {
                        ganhador = "X";
                        deep = " pelas linhas";
                        verificador = true;
                    }
                    else if ((matriz[1, 0] == "X") & (matriz[1, 1] == "X") & (matriz[1, 2] == "X"))
                    {
                        ganhador = "X";
                        deep = " pelas linhas";
                        verificador = true;
                    }
                    else if ((matriz[2, 0] == "X") & (matriz[2, 1] == "X") & (matriz[2, 2] == "X"))
                    {
                        ganhador = "X";
                        deep = " pelas linhas";
                        verificador = true;
                    }

                    // Condição de Vitoria por Colunas para X

                    if ((matriz[0, 0] == "X") & (matriz[1, 0] == "X") & (matriz[2, 0] == "X"))
                    {
                        ganhador = "X";
                        deep = " pelas colunas";
                        verificador = true;
                    }
                    else if ((matriz[0, 1] == "X") & (matriz[1, 1] == "X") & (matriz[2, 1] == "X"))
                    {
                        ganhador = "X";
                        deep = " pelas colunas";
                        verificador = true;
                    }
                    else if ((matriz[0, 2] == "X") & (matriz[1, 2] == "X") & (matriz[2, 2] == "X"))
                    {
                        ganhador = "X";
                        deep = " pelas colunas";
                        verificador = true;
                    }

                    // Condição de Vitoria por Diagonais para O

                    if ((matriz[0, 0] == "O") & (matriz[1, 1] == "O") & (matriz[2, 2] == "O"))
                    {
                        ganhador = "O";
                        deep = " pelas diagonais";
                        verificador = true;
                    }
                    else if ((matriz[2, 0] == "O") & (matriz[1, 1] == "O") & (matriz[0, 2] == "O"))
                    {
                        ganhador = "O";
                        deep = " pelas diagonais";
                        verificador = true;
                    }

                    // Condição de Vitoria por Linhas para O

                    if ((matriz[0, 0] == "O") & (matriz[0, 1] == "O") & (matriz[0, 2] == "O"))
                    {
                        ganhador = "O";
                        deep = " pelas linhas";
                        verificador = true;
                    }
                    else if ((matriz[1, 0] == "O") & (matriz[1, 1] == "O") & (matriz[1, 2] == "O"))
                    {
                        ganhador = "O";
                        deep = " pelas linhas";
                        verificador = true;
                    }
                    else if ((matriz[2, 0] == "O") & (matriz[2, 1] == "O") & (matriz[2, 2] == "O"))
                    {
                        ganhador = "O";
                        deep = " pelas linhas";
                        verificador = true;
                    }

                    // Condição de Vitoria por Colunas para X

                    if ((matriz[0, 0] == "O") & (matriz[1, 0] == "O") & (matriz[2, 0] == "O"))
                    {
                        ganhador = "O";
                        deep = " pelas colunas";
                        verificador = true;
                    }
                    else if ((matriz[0, 1] == "O") & (matriz[1, 1] == "O") & (matriz[2, 1] == "O"))
                    {
                        ganhador = "O";
                        deep = " pelas colunas";
                        verificador = true;
                    }
                    else if ((matriz[0, 2] == "O") & (matriz[1, 2] == "") & (matriz[2, 2] == "O"))
                    {
                        ganhador = "O";
                        deep = " pelas colunas";
                        verificador = true;
                    }

                    // Mudar de jogador

                    if (jogador == "X")
                    {
                        jogador = "O";
                    }
                    else if (jogador == "O")
                    {
                        jogador = "X";
                    }
                }
            }
            while ((verificador == false) & (contEmpt <= 8));
            
            if (verificador == true)
            {
                Console.WriteLine("O Ganhador do jogo foi " + ganhador + deep + ".");
                for (int cont1 = 0; cont1 < 3; cont1++)
                {
                    for (int cont2 = 0; cont2 < 3; cont2++)
                    {
                        if ((cont2 == 0))
                        {
                            Console.WriteLine("-----------------");
                        }
                        Console.Write("| " + matriz[cont1, cont2] + " | ");
                    }
                    Console.WriteLine();
                    if (cont1 == 2)
                    {
                        Console.WriteLine("-----------------");
                    }
                }
                Console.WriteLine("Número de jogadas:" + contEmpt);
                Console.ReadKey();
            }
            else if (contEmpt == 9)
            {
                Console.WriteLine("Ouve um empate!");
                for (int cont1 = 0; cont1 < 3; cont1++)
                {
                    for (int cont2 = 0; cont2 < 3; cont2++)
                    {
                        if ((cont2 == 0))
                        {
                            Console.WriteLine("-----------------");
                        }
                        Console.Write("| " + matriz[cont1, cont2] + " | ");
                    }
                    Console.WriteLine();
                    if (cont1 == 2)
                    {
                        Console.WriteLine("-----------------");
                    }
                }
                Console.WriteLine("Número de jogadas: " + contEmpt);
                Console.ReadKey();
            }
            
        }
    }
}
