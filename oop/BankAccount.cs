using System;
public class BankAccount{
    public string Number { get; }
    public decimal Balance { get; }
    public string Owner { get; set; }   
    public void MakeDeposit(decimal amount, DateTime date, string note){ 
        
    }
    public void MakeWithDrawal(decimal amount, DateTime date, string note){ 
        
    }
    public BankAccount(string name, decimal intialBalance){ 
        Owner = name;  // you can also use this.property = parameters
        Balance = intialBalance;
    }
}