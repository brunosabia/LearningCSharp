using System;
using System.Collections.Generic;
using System.IO;


namespace _61_DictionaryExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            //string path = @"C:\temp\in1.txt";


            Dictionary<string, int> vote = new Dictionary<string, int>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] values = sr.ReadLine().Split(',');
                    string candidate = values[0];
                    int number = int.Parse(values[1]);


                    if (vote.ContainsKey(candidate))
                    {

                        vote[candidate] += number;
                    }
                    else
                    {
                        vote.Add(candidate, number);
                    }
                }

                foreach (var item in vote)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }

            }
        }
    }
}

/*
CONTEUDO DO ARQUIVO LIDO    

Alex Blue,15
Maria Green,22
Bob Brown,21
Alex Blue,30
Bob Brown,15
Maria Green,27
Maria Green,22
Bob Brown,25
Alex Blue,31


 
 */