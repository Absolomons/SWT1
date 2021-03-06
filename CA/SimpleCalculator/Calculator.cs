using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator;
public class Calculator
{
    public double Accumulator { get; private set; }

    public double Add(double a, double b)
    {
        Accumulator = a + b;
        return Accumulator;
    }

    public double Subtract(double a, double b)
    {
        Accumulator = a - b;
        return Accumulator;
    }

    public double Multiply(double a, double b)
    {
        Accumulator = a * b;
        return Accumulator;
    }

    public double Power(double x, double exp)
    {
        Accumulator = Math.Pow(x, exp);
        return Accumulator;
    }

    public void Clear()
    {
        Accumulator = 0;
    }

    public double Divide(double dividend, double divisor)
    {
        if (divisor == 0)
        {
            throw new DivideByZeroException();
        }
        else
        {
            return dividend / divisor;
        }
    }
}
