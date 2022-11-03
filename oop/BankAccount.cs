using System;
using System.Text;
public class BankAccount
{
    public string Number { get; }
    private List<Transaction> allTransactions = new List<Transaction>();
    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
            }
            return balance;
        }
    }
     public BankAccount(string name, decimal intialBalance){ 
        Owner = name;  // you can also use this.property = parameters
        MakeDeposit(intialBalance, DateTime.Now, "Initial Balance");
        this.Number = accountNumberSeed.ToString();
        accountNumberSeed++;

    }
    public string Owner { get; set; }
    private static int accountNumberSeed = 1347723423;
    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount), "amount of deposit must be positive");
    
        var deposit = new Transaction(amount, date, note);
        allTransactions.Add(deposit);
    }
    public void MakeWithDrawal(decimal amount, DateTime date, string note)
    {
        if(amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount), "amount of withdrawal must be positive");
        if (Balance - amount < 0) throw new InvalidOperationException("No sufficient funds for this withdrawal");

        var withdraw = new Transaction(-amount, date, note);
        allTransactions.Add(withdraw);

    }

     public string GetAccountHistory(){
        var report = new StringBuilder();
        report.AppendLine("Date \t\t Amount\t Note"); // header
        foreach (var item in allTransactions)report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}"); //rows
        return report.ToString();
     }
}