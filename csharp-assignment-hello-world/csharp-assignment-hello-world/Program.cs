using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("===== MAIN MENU =====");
            Console.WriteLine("1. Operators Exercises");
            Console.WriteLine("2. Control Flow Set 1");
            Console.WriteLine("3. Control Flow Set 2");
            Console.WriteLine("0. Exit");
            Console.Write("Choose option: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: OperatorsMenu(); break;
                case 2: ControlFlowMenu1(); break;
                case 3: ControlFlowMenu2(); break;
                case 0: Console.WriteLine("Exiting..."); break;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        } while (choice != 0);
    }

    // ================= Operators =================
    static void OperatorsMenu()
    {
        Console.WriteLine("\n--- Operators Menu ---");
        Console.WriteLine("1. Basic operations (+,-,*,/)");
        Console.WriteLine("2. Function x = y^2 + 2y + 1 (-5 <= y <= 5)");
        Console.WriteLine("3. Calculate speed (km/h & miles/h)");
        Console.WriteLine("4. Sphere surface & volume");
        Console.WriteLine("5. Character check (vowel, digit, symbol)");
        Console.Write("Choose exercise (1-5): ");
        int op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                Console.Write("Enter first number: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Enter operator (+,-,*,/): ");
                char sign = Console.ReadLine()[0];
                double result = 0;
                bool valid = true;
                switch (sign)
                {
                    case '+': result = a + b; break;
                    case '-': result = a - b; break;
                    case '*': result = a * b; break;
                    case '/': result = b != 0 ? a / b : double.NaN; break;
                    default: valid = false; break;
                }
                if (valid) Console.WriteLine($"Result: {a} {sign} {b} = {result}");
                else Console.WriteLine("Invalid operator!");
                break;

            case 2:
                for (int y = -5; y <= 5; y++)
                {
                    int x = y * y + 2 * y + 1;
                    Console.WriteLine($"y = {y}, x = {x}");
                }
                break;

            case 3:
                Console.Write("Enter distance in kilometers: ");
                double dist = double.Parse(Console.ReadLine());
                Console.Write("Enter hours: ");
                int h = int.Parse(Console.ReadLine());
                Console.Write("Enter minutes: ");
                int m = int.Parse(Console.ReadLine());
                Console.Write("Enter seconds: ");
                int s = int.Parse(Console.ReadLine());
                double timeHr = h + m / 60.0 + s / 3600.0;
                double kmph = dist / timeHr;
                double mph = kmph * 0.621371;
                Console.WriteLine($"Speed: {kmph:F2} km/h = {mph:F2} miles/h");
                break;

            case 4:
                Console.Write("Enter radius: ");
                double r = double.Parse(Console.ReadLine());
                double surface = 4 * Math.PI * r * r;
                double volume = 4.0 / 3.0 * Math.PI * Math.Pow(r, 3);
                Console.WriteLine($"Surface = {surface:F2}, Volume = {volume:F2}");
                break;

            case 5:
                Console.Write("Enter a character: ");
                char c = Console.ReadLine()[0];
                if ("aeiouAEIOU".IndexOf(c) >= 0) Console.WriteLine("It is a vowel.");
                else if (char.IsDigit(c)) Console.WriteLine("It is a digit.");
                else if (char.IsLetter(c)) Console.WriteLine("It is a consonant.");
                else Console.WriteLine("It is a symbol.");
                break;
        }
    }

    // ================= Control Flow Set 1 =================
    static void ControlFlowMenu1()
    {
        Console.WriteLine("\n--- Control Flow Menu (Set 1) ---");
        Console.WriteLine("1. Check even or odd");
        Console.WriteLine("2. Largest of three numbers");
        Console.WriteLine("3. Quadrant of coordinate point");
        Console.Write("Choose exercise (1-3): ");
        int op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");
                break;

            case 2:
                Console.Write("Enter first number: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int n2 = int.Parse(Console.ReadLine());
                Console.Write("Enter third number: ");
                int n3 = int.Parse(Console.ReadLine());
                int largest = Math.Max(n1, Math.Max(n2, n3));
                Console.WriteLine($"The largest number is {largest}");
                break;

            case 3:
                Console.Write("Enter X coordinate: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter Y coordinate: ");
                int y = int.Parse(Console.ReadLine());
                if (x > 0 && y > 0) Console.WriteLine("First quadrant");
                else if (x < 0 && y > 0) Console.WriteLine("Second quadrant");
                else if (x < 0 && y < 0) Console.WriteLine("Third quadrant");
                else if (x > 0 && y < 0) Console.WriteLine("Fourth quadrant");
                else Console.WriteLine("On axis or origin");
                break;
        }
    }

    // ================= Control Flow Set 2 =================
    static void ControlFlowMenu2()
    {
        Console.WriteLine("\n--- Control Flow Menu (Set 2) ---");
        Console.WriteLine("1. Triangle type");
        Console.WriteLine("2. Read 10 numbers (sum & average)");
        Console.WriteLine("3. Multiplication table");
        Console.WriteLine("4. Pattern (triangle numbers)");
        Console.WriteLine("5. Pattern (1234, etc.)");
        Console.WriteLine("6. Harmonic series sum");
        Console.WriteLine("7. Perfect numbers in range");
        Console.WriteLine("8. Prime check");
        Console.Write("Choose exercise (1-8): ");
        int op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                Console.Write("Enter side a: "); int a = int.Parse(Console.ReadLine());
                Console.Write("Enter side b: "); int b = int.Parse(Console.ReadLine());
                Console.Write("Enter side c: "); int c = int.Parse(Console.ReadLine());
                if (a == b && b == c) Console.WriteLine("Equilateral triangle");
                else if (a == b || b == c || a == c) Console.WriteLine("Isosceles triangle");
                else Console.WriteLine("Scalene triangle");
                break;

            case 2:
                int sum = 0;
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write($"Enter number {i}: ");
                    sum += int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Sum = {sum}, Average = {(double)sum / 10}");
                break;

            case 3:
                Console.Write("Enter an integer: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{n} x {i} = {n * i}");
                }
                break;

            case 4:
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write(j);
                    Console.WriteLine();
                }
                break;

            case 5:
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write(j);
                    Console.WriteLine();
                }
                break;

            case 6:
                Console.Write("Enter n: ");
                int nn = int.Parse(Console.ReadLine());
                double seriesSum = 0;
                for (int i = 1; i <= nn; i++)
                {
                    seriesSum += 1.0 / i;
                    Console.Write("1/{0} ", i);
                    if (i < nn) Console.Write("+ ");
                }
                Console.WriteLine($"\nSum = {seriesSum:F4}");
                break;

            case 7:
                Console.Write("Enter range limit: ");
                int limit = int.Parse(Console.ReadLine());
                Console.WriteLine("Perfect numbers:");
                for (int i = 1; i <= limit; i++)
                {
                    int divSum = 0;
                    for (int j = 1; j < i; j++)
                        if (i % j == 0) divSum += j;
                    if (divSum == i) Console.WriteLine(i);
                }
                break;

            case 8:
                Console.Write("Enter a number: ");
                int primeNum = int.Parse(Console.ReadLine());
                bool isPrime = primeNum > 1;
                for (int i = 2; i <= Math.Sqrt(primeNum); i++)
                {
                    if (primeNum % i == 0) { isPrime = false; break; }
                }
                Console.WriteLine(isPrime ? "Prime" : "Not Prime");
                break;
        }
    }
}