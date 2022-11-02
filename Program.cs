// See https://aka.ms/new-console-template for more information
using System;
    class Test{
        static void Main(string[] args){
            // Section one
            string name = "Janvier";

            Console.WriteLine(name);
            Console.WriteLine("Hello " +name); // string concantanation
            Console.WriteLine($"Hello {name}"); // string interpolation
             
             // Section Two 
             string greet = "  Hello world.  ";
            //size
            Console.WriteLine($"my variable size is: {greet.Length}");
            // replace
            greet = greet.Replace("Hello", "Muraho neza");
            Console.WriteLine($"{greet}");

            // trimming [start, end, all]
            Console.WriteLine($"[###{greet}###]");
            string trimmed = greet.TrimStart();
            Console.WriteLine($"[##{trimmed}##]");

            // trim end
            string trimmedEnd = greet.TrimEnd();
            Console.WriteLine($"[##{trimmedEnd}##]");

            // trim both sides
            string trimBothEnds = greet.Trim();
            Console.WriteLine($"[##{trimBothEnds}##]");

            // capitalizing
            Console.WriteLine($"To upper{greet.ToUpper()}");
            Console.WriteLine($"To Lower{greet.ToLower()}");

        }
    }

