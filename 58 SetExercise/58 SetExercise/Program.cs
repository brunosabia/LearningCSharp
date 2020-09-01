using _58_SetExercise.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace _58_SetExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Arquivo lido nesse Exercicio:
             *    
             *    C:\temp\in.txt
             *    
                amanda 2020-08-26T20:45:08
                alex86 2020-08-26T21:49:37
                bobbrown 2020-08-27T03:19:13
                amanda 2020-08-27T08:11:00
                jeniffer3 2020-08-27T09:19:24
                alex86 2020-08-27T22:39:52
                amanda 2020-08-28T07:42:19
             */
            Console.Write("Enter the file full path: ");
            string path = Console.ReadLine();
            int counter = 0;
            HashSet<LogRecord> logRecords = new HashSet<LogRecord>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] logs = null;
                        logs = sr.ReadLine().Split(' ');
                        string name = logs[0];
                        DateTime time = DateTime.Parse(logs[1]);
                        logRecords.Add(new LogRecord(name, time));
                        

                    }

                }

                foreach (LogRecord item in logRecords)
                {
                    Console.WriteLine(item.Name);
                    counter++;
                }

                Console.WriteLine();

                Console.Write("Number of users: " + counter);
                //Em vez desse counter poderia ser usado o "logRecords.Count" que retorna a quantidade de itens no HashSet


            }
            catch(IOException e)
            {
                Console.WriteLine("Unexpected Error. " + e.Message);
            }
        }
    }
}
