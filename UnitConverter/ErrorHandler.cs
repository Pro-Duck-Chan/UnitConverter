using System;
using System.Collections.Generic;

static class ErrorHandler
{
    static List<string> errors = new List<string>();

    static public void RaportError(string message)
    {
        errors.Add(message);
    }

    static public void RaportError(string message, int position)
    {
        errors.Add(message + " at second input " + position);
    }

    static public void PrintErrorList()
    {
        for(int i = 0; i < errors.Count; i++)
        {
            Console.WriteLine(errors[i]);
        }

        errors.Clear();
    }
}

