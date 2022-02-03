namespace SimpleCalculator
{
    class Program
    {
        public static void Main()
        {
            Calculator calc = new Calculator();

            double a = 15, b = 5, c = -10;

            if (calc.Add(a, b) == 20)
            {
                Console.WriteLine("Add returner korrekt");
            }
            else
            {
                Console.WriteLine("Add returnerer forkert");
            }

            if (calc.Add(a, c) == 5) //Negativ c
            {
                Console.WriteLine("Add med negativ returner korrekt");
            }
            else
            {
                Console.WriteLine("Add med negativ returnerer forkert");
            }

            if (calc.Subtract(a, b) == 10)
            {
                Console.WriteLine("Subtract returnerer korrekt");
            }
            else
            {
                Console.WriteLine("Subtract returnerer forkert");
            }

            if (calc.Subtract(a, c) == 25) //Negativ c
            {
                Console.WriteLine("Subtract med negativ returnerer korrekt");
            }
            else
            {
                Console.WriteLine("Subtract med negativ returnerer forkert");
            }


            if (calc.Multiply(a, b) == 75)
            {
                Console.WriteLine("Multiply returnerer korrekt");
            }
            else
            {
                Console.WriteLine("Multiply returnerer forkert");
            }

            if (calc.Multiply(a, c) == -150)
            {
                Console.WriteLine("Multiply med negativ returnerer korrekt");
            }
            else
            {
                Console.WriteLine("Multiply med negativ returnerer forkert");
            }

            double x = 2, exp1 = 6, exp2 = -4;


            if (calc.Power(x, exp1) == 64)
            {
                Console.WriteLine("Power returnerer korrekt");
            }
            else
            {
                Console.WriteLine("Power returnerer forkert");
            }

            if (calc.Power(x, exp2) == 0.0625)
            {
                Console.WriteLine("Power med negativ returnerer korrekt");
            }
            else
            {
                Console.WriteLine("Power med negativ returnerer forkert");
            }

            calc.Printfunny();

        }
    }
}