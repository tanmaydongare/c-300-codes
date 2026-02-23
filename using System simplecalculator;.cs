using System simplecalculator;

class SimpleCalculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator in C#");
        Console.WriteLine("-----------------------");

        // Ask user for the first number
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Ask user for the operator
        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        // Ask user for the second number
        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        // Perform calculation based on operator
        switch (op)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                    result = num1 / num2;
                else
                    Console.WriteLine("Error: Division by zero is not allowed.");
                break;
            default:
                Console.WriteLine("Invalid operator!");
                break;
        }

        // Show result
        Console.WriteLine("Result: " + result);
    }
}