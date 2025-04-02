using System;
using System.Collections.Generic;
using System.IO;

public abstract class BudgetItem
{
    private string _name;
    private decimal _amount;

    public string Name { get => _name; protected set => _name = value; }
    public decimal Amount { get => _amount; protected set => _amount = value; }

    public BudgetItem(string name, decimal amount)
    {
        Name = name;
        Amount = amount;
    }

    public abstract string GetDescription();
    public abstract string ToFileString();
}