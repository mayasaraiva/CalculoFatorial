﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoFatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite S para Sair ou um Número para calcular um fatorial:");
                string opcao = Console.ReadLine();
                if (opcao == "s" || opcao == "S")
                {
                    break;
                }
                else
                {
                    int valor = Convert.ToInt32(opcao);
                    if (valor == 0)
                    {
                        Console.WriteLine("0! = 1");
                    }
                    else if (valor < 0)
                    {
                        Console.WriteLine("Impossível calcular o fatorial de um número negativo.");
                    }
                    else
                    {
                        int resultado = 1;
                        Console.Write($"{valor} != ");
                        for (int i = valor; i > 0; i--)
                        {
                            resultado *= i;
                            if (i ==1)
                            {
                                Console.Write($"{i} = {resultado}");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.Write($"{i}x");
                            }
                        }
                        //Console.WriteLine($"O Resultado de {valor} fatorial é: {resultado} ");
                    }
                    Console.WriteLine("Pressione qualquer tecla para Continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.WriteLine("Pressione qualquer tecla para finalizar");
            Console.ReadKey();
        }
    }
}
