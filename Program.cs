using System;
using System.IO;

namespace FilessAccess

{
    class Example
    {
     static void Main()
        {
            string path = @"C:\Users\User\Desktop\Директория";

            if (Directory.Exists(path))
            {
                Console.ForegroundColor=ConsoleColor.Blue;
                Console.WriteLine("Подкаталоги");
            }
            string[] directories = Directory.GetDirectories(path);
            foreach (string directory in directories)
            Console.WriteLine(directory);

            Console.WriteLine();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Файлы");
            

            string[] files = Directory.GetFiles(path);
                  foreach (string file in files)
                Console.WriteLine(file); 


        }
    }
    
}

