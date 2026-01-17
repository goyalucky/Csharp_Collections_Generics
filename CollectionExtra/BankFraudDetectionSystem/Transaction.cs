using System;
namespace BankFraudDetectionSystem
{
    // Represents a bank transaction
public class Transaction
{
    public DateTime Time;
    public double Amount;
    public bool IsWithdrawal;

    public Transaction(DateTime time, double amount, bool isWithdrawal)
    {
        Time = time;
        Amount = amount;
        IsWithdrawal = isWithdrawal;
    }
}
}