using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_jogoForca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listWords = new List<string> {
                      "desaparecer", "diamante", "apache", "agrilhoado",
                      "caneta", "azul", "manteiga", "remover", "escalar",
                      "armando", "original", "adesivo", "esporte" };

            Random rndNum = new Random();
            int wordLength = listWords.Count;
            // listWord.Count me fornece o valor inteiro do length.

            string rndWord = listWords[rndNum.Next(0, wordLength)];
            // Gerando um numero aleatorio entre 0 e 12. O worldLength é 13, mas o metodo exclui o ultimo, por isso de 0 a 12.

            List<char> word = new List<char>();
            List<string> hiddenWord = new List<string>();

            for (int i = 0; i < rndWord.Length; i++)
            {
                word.Add(rndWord[i]);
                hiddenWord.Add(" _ ");
            }

            while (hiddenWord.Contains(" _ "))
            {
                Console.WriteLine($"Adivinhe qual é a palavra a seguir, digitando letra por letra: \n {string.Join("", hiddenWord)}");
                string resUser = Console.ReadLine().ToLower();
                if (resUser.Length > 1)
                {
                    Console.WriteLine("Por favor, digite uma única letra por vez.");
                }
                else
                {
                    for (int i = 0; i < word.Count; i++)
                    {
                        if (word[i] == resUser[0])
                        {
                            hiddenWord[i] = resUser;
                        }
                    }
                }
                if (!hiddenWord.Contains(" _ "))
                {
                    Console.WriteLine($"Parabéns! Você conseguiu! A palavra sorteada era '{rndWord}'.");
                }
            }
        }
    }
}