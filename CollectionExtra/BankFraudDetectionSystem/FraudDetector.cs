using System;
using System.Collections.Generic;

namespace BankFraudDetectionSystem
{
    // Contains fraud detection logic
public class FraudDetector
{
    // Detects fraud for a single transaction
    public static bool IsFraudulent(
        long accountNo,
        Transaction tx,
        Dictionary<long, List<Transaction>> history,
        ref double balance,
        Queue<Transaction> recentWithdrawals)
    {
        // Zero or negative balance withdrawal
        if (tx.IsWithdrawal && (balance <= 0 || tx.Amount <= 0))
            return true;

        // Rule: withdrawal > 80% of balance
        if (tx.IsWithdrawal && tx.Amount > 0.8 * balance)
            return true;

        // Track withdrawals in last 10 minutes
        if (tx.IsWithdrawal)
        {
            recentWithdrawals.Enqueue(tx);

            // Remove old transactions (>= 10 min old excluded)
            while (recentWithdrawals.Count > 0 &&
                   (tx.Time - recentWithdrawals.Peek().Time).TotalMinutes > 10)
            {
                recentWithdrawals.Dequeue();
            }

            // Rule: more than 3 withdrawals in 10 minutes
            if (recentWithdrawals.Count > 3)
                return true;

            // Balance update after validation
            balance -= tx.Amount;
        }
        else
        {
            balance += tx.Amount;
        }

        // Store transaction history
        if (!history.ContainsKey(accountNo))
            history[accountNo] = new List<Transaction>();
        history[accountNo].Add(tx);
        return false;
    }

    // Generates fraud report
    public static void GenerateReport(
        Dictionary<long, List<Transaction>> suspiciousAccounts)
    {
        Console.WriteLine("\nSuspicious Transaction Report:");

        foreach (var acc in suspiciousAccounts)
        {
            Console.WriteLine($"Account: {acc.Key}");
            foreach (var tx in acc.Value)
                Console.WriteLine($"  {tx.Time} | ₹{tx.Amount}");
        }
    }
}
}