using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = ("Damn right I like the life I live cause I went from negative to positive.");
            string firstName = "Jackson";
            string favMovie = "The Matrix";
            favMovie = (favMovie.ToLower());
            firstName = (firstName.ToLower());
            Console.WriteLine($"Hey {firstName} have you ever watched the movie {favMovie}?");
            favMovie = (favMovie.ToUpper());
            Console.WriteLine(favMovie);
            Console.WriteLine(favMovie.Contains("THE"));
            favMovie = (favMovie.Replace("A", "@"));
            favMovie = favMovie.Replace("E", "3");
            Console.WriteLine(favMovie);


            quote = (quote.ToLower());
            quote = (quote.Replace("a", " ")).Replace("e", " ").Replace("i", " ").Replace("o", " ").Replace("u", " ");
            Console.WriteLine(quote);


            Console.WriteLine(" ");
            Console.Write("===========");
            Console.WriteLine("     __v_ ");
            Console.Write("I         I");
            Console.WriteLine("    (____/{ ");
            Console.WriteLine("I         I");
           
            Console.WriteLine("I         I");
            
            Console.WriteLine("I         I");
            
            Console.WriteLine("I         I");
            
            Console.WriteLine("I         I");
            
            Console.WriteLine("I         I");
            
            Console.WriteLine("I         I");
            
            Console.WriteLine("===========");

            
            Console.WriteLine("|         / ");
            
            Console.WriteLine("|        / ");
            
            Console.WriteLine("|       / ");
            
            Console.WriteLine("|      / ");
            
            Console.WriteLine("|     / ");
            
            Console.WriteLine("|    / ");
            
            Console.WriteLine("|   / ");
            
            Console.WriteLine("|  / ");
            
            Console.WriteLine("| / ");
            
            Console.WriteLine("|/ ");
            
            Console.ReadLine();
        }
    }
}
