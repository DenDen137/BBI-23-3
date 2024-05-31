using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;


abstract class task
{
    static void main()
    {
        string input = console.readline();
        string centralword = findcentralword(input);
        console.writeline("центральное слово в тексте: " + centralword);
    }

    static string findcentralword(string input)
    {
        string[] words = input.split(new char[] { ' ', '.', ',', '!', '?' }, stringsplitoptions.removeemptyentries);
        int centerindex = words.length / 2;

        return words[centerindex];
    }
}

class jsonio
{
    static void main()
    {
        string input = "на вход подается строка.";

        string pattern = @"\b[a-zа-я][a-zа-я]+\b"; 

        matchcollection matches = regex.matches(input, pattern);

        list<string> imenasob = new list<string>();

        foreach (match match in matches)
        {
            imenasob.add(match.value);
        }

        string[] result = imenasob.toarray();

        foreach (string name in result)
        {
            console.writeline(name);
        }
    }
}


class Task1 : Task
{
    static void Main()
    {
        string MyFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);


        string fourthTaskFolder = Path.Combine(MyFolder, "Fourth Task");

        if (!Directory.Exists(fourthTaskFolder))
        {
            Directory.CreateDirectory(fourthTaskFolder);
            File.WriteAllText(Path.Combine(fourthTaskFolder, "string_1.json"), "{\"data\": \"file1\"}");
            File.WriteAllText(Path.Combine(fourthTaskFolder, "string_2.json"), "{\"data\": \"file2\"}");
            Console.WriteLine("Папка и файлы успешно созданы.");
        }
        else
        {
            Console.WriteLine("Папка уже существует.");
        }
    }


    public class Task1Data
    {
        public string Input { get; set; }
        public string Output { get; set; }
    }

    public class Task2Data
    {
        public int Input { get; set; }
        public int Output { get; set; }
    }

    class Program
    {
        static void Main()
        {
            string task1Filename = "task1.json";
            string task2Filename = "task2.json";


            Task1Data task1Data = ReadTaskData<Task1Data>(task1Filename);
            Task2Data task2Data = ReadTaskData<Task2Data>(task2Filename);


            Console.WriteLine("Task 1:");
            Console.WriteLine($"Input: {task1Data.Input}");
            Console.WriteLine($"Output: {task1Data.Output}");

            Console.WriteLine("Task 2:");
            Console.WriteLine($"Input: {task2Data.Input}");
            Console.WriteLine($"Output: {task2Data.Output}");
        }

        static T ReadTaskData<T>(string filename)
        {
            T data;
            if (File.Exists(filename))
            {
                string json = File.ReadAllText(filename);
                data = JsonConvert.DeserializeObject<T>(json);
            }
            else
            {
                data = default(T);
            }
            return data;
        }
    }
}
