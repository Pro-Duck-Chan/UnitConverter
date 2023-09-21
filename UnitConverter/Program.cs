using System;
using System.Collections.Generic;

public class Base
{
    public static void Main(string[] args) 
    {
        if (args.Length > 0)
            ProcessInput(args);
        else
        {
            StartText();
            string line;
            while((line = Console.ReadLine()) != String.Empty)
                ProcessInput(line.Split());
        }
    }

    static void ProcessInput(string[] data)
    {
        //checking so that the input struckter is correct else we let the use input value
        if (IsNumberWhole(data.Length))
        {
            List<UnitStore> inputUnits = Converter.Validate(data);
            Converter.Convert(ref inputUnits);
            ErrorHandler.PrintErrorList();
            Print(ref inputUnits);
        }
        else
        {
            ErrorHandler.RaportError("Incorrect input format");
            ErrorHandler.PrintErrorList();
        }
    }

    static void StartText()
    {
        Console.WriteLine("Unit Converter");
        Console.WriteLine("--------------");
        Console.WriteLine("You can use short or long name of units.");
        Console.WriteLine("When using short name most units uses small character but some in the metric system uses capital for the first character.");
        Console.WriteLine("To choose what name is used for the output, it will match the one used to input.");
        Console.WriteLine("To input units to convert follow the example.");
        Console.WriteLine("example. [value] [unit] [unit to convert to]");
        Console.WriteLine("example. 10 m in");
        Console.WriteLine("example. 10 meter intch");
        Console.WriteLine("example. 10 kilometer in");
        Console.WriteLine("Don't forget the space in-between.");
        Console.WriteLine("You can input as many values you want on the same line as long there is a space in-between.");
        Console.WriteLine("The program will not exit until you input a blank line so you can continue to input values if you wish.");
    }

    static bool IsNumberWhole(float number)
    {
        float size = number / 3;

        if(Math.Floor(size) == size)
            return true;

        return false;
    }

    static void Print(ref List<UnitStore> values)
    {
        for(int i = 0; i < values.Count; i++)
            Console.WriteLine(values[i].Print());
    }
}