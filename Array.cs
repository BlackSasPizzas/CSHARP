﻿using System;

namespace array 
{
    public class BibliotecaArray 
    {
        public static void leiaVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"[{i}]:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void geraVetor(int[] vetor)
        {
            Random random = new Random(); 
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 100);
            }
        }
        public static void mostraVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"|{vetor[i]}");
            }
        }
         static int somaVetor(int[] vetor)
 {
     int soma = 0;
     for (int i = 0; i < vetor.Length; i++)

         soma += vetor[i];

     return soma;
 }

    }
}
