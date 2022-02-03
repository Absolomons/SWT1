using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator;
public class Calculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Power(double x, double exp)
    {
        return Math.Pow(x, exp);
    }

    public double Divide(double dividend, double divisor)
    {
        if (divisor == 0)
        {
            throw new Exception();
        }
        else
        {
            return dividend / divisor;
        }
    }

    public void Printfunny()
    {
        Console.WriteLine("What did chicken cross?\n THe ROADS HAHAH");
    }
}
