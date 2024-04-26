using System.Collections.Generic;
using System;
using System.ComponentModel.Design;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст (одно слово):");
        string input = Console.ReadLine().ToLower(); 

        int raznie = raznie1(input);

        Console.WriteLine($"Количество различных букв в слове: {raznie}");
    }

    static int raznie1(string input)
    {
        int count = 0;
        bool[] found = new bool[26]; 

        foreach (char c in input)
        {
            if (c >= 'a' && c <= 'z')
            {
                int index = c - 'a';
                if (!found[index])
                {
                    found[index] = true;
                    count++;
                }
            }
        }

        return count;
    }
}


class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        string sdvig = sdvig01(input);

        Console.WriteLine($"Текст после сдвига на 10 символов влево по алфавиту: {sdvig}");
    }

    static string sdvig01(string input)
    {
        string resultat = string.Empty;
        string alfavit = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                int index = alfavit.IndexOf(char.ToLower(c));
                int sdvigIndex = (index - 10 + alfavit.Length) % alfavit.Length;
                char sdvigChar = char.IsUpper(c) ? char.ToUpper(alfavit[sdvigIndex]) : alfavit[sdvigIndex];
                resultat += sdvigChar;
            }
            else
            {
                resultat += c;
            }
        }

        return resultat;
    }

    static void Main()
    {
        
        string path = @"C:\Users\m2305837"; 
        string NamePapka = "Answer";
        path = Path.Combine(path, NamePapka);
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        string NameFile1 = "cw2_1.json";
        string NameFale2 = "cw2_2.json";


        NameFile1 = Path.Combine(path, NameFile1);
        NameFale2 = Path.Combine(path, NameFale2);
        if (!File.Exists(NameFile1))
        {
            File.Create(NameFile1);
        }
        if (!File.Exists(NameFale2))
        {
            File.Create(NameFale2);
        }

    }
}

