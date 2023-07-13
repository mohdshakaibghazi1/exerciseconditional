using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks in pre: ");
            int preMarks = int.Parse(Console.ReadLine());

            string result = preMarks > 60
                ? GetFinalResult()
                : "Fail in Pre";

            Console.WriteLine(result);
            Console.ReadLine();
        }

        static string GetFinalResult()
        {
            Console.WriteLine("Enter marks in final: ");
            int finalMarks = int.Parse(Console.ReadLine());

            string result = finalMarks > 55
                ? "Selected"
                : "Fail in Final";

            return result;
        }

    }

}
