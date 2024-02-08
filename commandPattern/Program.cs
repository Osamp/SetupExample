﻿Console.WriteLine("Please give a calculation");

string? cmd = Console.ReadLine();

string[] arr = cmd.Split(" ");

Command operation = new Command();

if (arr[0] == "+")
{
    operation = new Add();
}

if (arr[0] == "-")
{
    operation = new Subtract();
}

if (operation is not null)
    Console.WriteLine($"The answer is: {operation.Execute(decimal.Parse(arr[1]), decimal.Parse(arr[2]))}");


public class Command
{
    public virtual decimal Execute(decimal left, decimal right)
    {
        return 0M;
    }
}

public class Add : Command
{
    public override decimal Execute(decimal left, decimal right)
    {
        return left + right;
    }
}

public class Subtract :Command
{
    public override global::System.Decimal Execute(global::System.Decimal left, global::System.Decimal right)
    {
        return left - right;
    }
}