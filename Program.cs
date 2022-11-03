// See https://aka.ms/new-console-template for more information
using System;
    class Test{
        static void Main(string[] args){


                // using classes 
                BankAccount ba = new BankAccount("Janvier", 2000);
                Console.WriteLine($"Account {ba.Number} created for {ba.Owner} has {ba.Balance} USD");
        }

    }

