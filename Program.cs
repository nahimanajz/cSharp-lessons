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

            // Searching strings 
            string songLyrics = "You said goodbye and I said Hello";
            var hasString = songLyrics.Contains("goodbye");
            var endsWithString = songLyrics.EndsWith("goodbye");
            var startsWithString = songLyrics.StartsWith("You");

            Console.WriteLine($"{hasString} starts with: {startsWithString} ends with: {endsWithString}");
            Console.WriteLine($"starts with goodbye: {startsWithString}");
            Console.WriteLine($"ends with You: {endsWithString}");

            // Numbers, Integers and Math
            int a = 3, b=4, c= 5;
            int multiplyFirst = a+b*c;
            int sumFirst = (a+b) * c;
            int div = (a+b) / c;
            int rem = (a+b) % c;

            Console.WriteLine($"{multiplyFirst}");
            Console.WriteLine($"{sumFirst}");
            Console.WriteLine($"Quotient: {div} and remainder {rem}");

            // max and min allowed in c-sharp
            int max = int.MaxValue;
            int min = int.MinValue;
            int addToMax = max +3; // Since we alread reached on int max size, addition overflows it.
            Console.WriteLine($"Min: {min} and Max: {max} ");
            Console.WriteLine($"{addToMax}");

            double maxDouble = double.MaxValue;
            double minDouble = double.MinValue;
            double quotient = 1.0 / 3.0;
            Console.WriteLine($"Max: {maxDouble} and min: {minDouble} "); // 1.7976931348623157E+308 and min: -1.7976931348623157E+308  e means exponent
            Console.WriteLine($"Double quotient: {quotient}");

            decimal maxDecimal = decimal.MaxValue;
            decimal minDecimal = decimal.MinValue;
            Console.WriteLine($"decimals range from: {minDecimal} to : {maxDecimal} "); 

            long maxLong = long.MaxValue;
            long minLong = long.MinValue;
            Console.WriteLine($"Long range from: {maxLong} to : {minLong} ");

            short maxShort = short.MaxValue;
            short minShort = short.MinValue;
            Console.WriteLine($"Long range from: {minShort} to : {maxShort} ");

            // Calculating area of circle Math functions
            double rad = 2.5;
            double pi = Math.PI;
            double area = rad*rad*pi;
            Console.WriteLine($"Circle area is {area}");
            // skipped IFs
            int number = 9;
            if(number < 10){
                Console.WriteLine("Our number is less than 10");
            } else{
                Console.WriteLine("Our number is greater than 10");

            }
            // Loops
            int counter = 0;

            // #1 while (check and do after)
            while(counter < 10){
                Console.WriteLine($"while loop counter is: {counter}");
                counter++;
            }

            // #2 do while 
             do { // do the job and check after
                Console.WriteLine($"do while loop is: {counter}");
                counter++;
             }  while(counter < 10); 

            //#3 for loop
            for(int i = 0; i < 10; i++){
                Console.WriteLine($"for loop is: {i}");
            }
            // combine branches and loops
            // Calculate Sum of the numbers that are divisible by three from 1 to 20
            
            int sum = 0;
            for ( int i = 1; i < 20; i++){
                if(i % 3 == 0) sum +=i;
            }
            Console.WriteLine($"As expected sum is 63 the actual sum is {sum} ");

            //ARRAY, List and Collections;
            var buddies = new List<string>{"Mistico","Jz", "Bboy","Jopox"};    // use var in ccase you don't know exact datatypes
            buddies.Add("BIKORI..");
            buddies.Add("Harera..");
            buddies.Remove("Jz");

            foreach (var buddy in buddies) Console.WriteLine(buddy);
            
            buddies.Sort();
            for (var i =0; i < buddies.Count; i++) Console.WriteLine(buddies[i]);
            Console.WriteLine(buddies.IndexOf("BIKORI")); // -1 if item isn't exist)

            //Integers
            List<int> fibonacciNumbers = new List<int>{1, 1};
            while (fibonacciNumbers.Count <= 20){

                var prev = fibonacciNumbers[fibonacciNumbers.Count -1];
                var prevTwoSteps = fibonacciNumbers[fibonacciNumbers.Count -2];
                fibonacciNumbers.Add(prev + prevTwoSteps);
            }
            foreach (var element in fibonacciNumbers) Console.WriteLine(element);

  
        }

    }

