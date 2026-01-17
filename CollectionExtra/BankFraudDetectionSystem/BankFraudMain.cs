/* Bank Transaction Fraud Detector
Problem Statement - Implement fraud detection logic in a banking system.
Use:
● Dictionary<long, List<Transaction>>
● Queue<Transaction>
Tasks
1. Flag account if:
    ○ More than 3 withdrawals in 10 minutes
    ○ Withdrawal > 80% of balance
2. Generate suspicious transaction report.
Edge Cases
● Transactions at exact 10-minute boundary
● Balance changing after each transaction
● Same timestamp transactions
● Zero balance withdrawal
● Queue not cleared properly */

using System;
using System.Collections.Generic;

namespace BankFraudDetectionSystem
{
   public class BankFraudMain
{
    public static void Start()
    {
        Dictionary<long, List<Transaction>> history = new Dictionary<long, List<Transaction>>();

        Dictionary<long, List<Transaction>> suspicious = new Dictionary<long, List<Transaction>>();

        Dictionary<long, double> balances = new Dictionary<long, double>();

        Dictionary<long, Queue<Transaction>> withdrawalQueues = new Dictionary<long, Queue<Transaction>>();

        long accNo = 99910001;
        balances[accNo] = 10000;
        withdrawalQueues[accNo] = new Queue<Transaction>();

        List<Transaction> transactions = new List<Transaction>
        {
            new Transaction(DateTime.Now, 1000, true),
            new Transaction(DateTime.Now.AddMinutes(2), 1200, true),
            new Transaction(DateTime.Now.AddMinutes(4), 900, true),
            new Transaction(DateTime.Now.AddMinutes(6), 800, true)
        };
        foreach (var tx in transactions)
{
    double bal = balances[accNo];   // copy balance

    bool fraud = FraudDetector.IsFraudulent(
        accNo,
        tx,
        history,
        ref bal,                     // valid ref
        withdrawalQueues[accNo]);

    balances[accNo] = bal;           // store updated balance

    if (fraud)
    {
        if (!suspicious.ContainsKey(accNo))
            suspicious[accNo] = new List<Transaction>();

        suspicious[accNo].Add(tx);
    }
    }
        FraudDetector.GenerateReport(suspicious);
    }
}
}