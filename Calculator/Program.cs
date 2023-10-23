public class Calculator
{
    public static int Add(int num1, int num2)
    {
        int total;
        total = num1 + num2;
        return total;
    }

    public static int Subtract(int num1, int num2)
    {
        int total;
        total = num1 - num2;
        return total;
    }

    public static int Multiply(int num1, int num2)
    {
        int total = 0;
        bool num1IsNegative = num1 < 0;
        bool num2IsNegative = num2 < 0;

        num1 = num1IsNegative ? -num1 : num1;
        num2 = num2IsNegative ? -num2 : num2;

        for (int i = 0; i < num1; i++)
        {
            total += num2;
        }

        return (num1IsNegative ^ num2IsNegative) ? -total : total;
    }


    public static int Divide(int num1, int num2)
    {

        if (num2 == 0)
        {
            while (true)
            {
                Console.WriteLine("Division by zero is not allowed. Please enter a non-zero divisor: ");
                string divisorInput = Console.ReadLine();
                if (int.TryParse(divisorInput, out num2) && num2 != 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a non-zero divisor.");
                }
            }
        }

        int total = 0;
        int sign = 1;

        if (num1 < 0)
        {
            num1 = -num1;
            sign = -sign;
        }

        if (num2 < 0)
        {
            num2 = -num2;
            sign = -sign;
        }

        while (num1 >= num2)
        {
            num1 -= num2;
            total++;
        }

        if (sign < 0)
        {
            total = -total;
        }

        return total;
    }

    static int GetValidNumber(string prompt)
    {
        int number;
        bool validInput = false;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine();


            if (int.TryParse(input, out number))
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } while (!validInput);

        return number;
    }

    public static void Main()
    {
        while (true)
        {
            Console.Write("Please select an operation \n 1.Add \n 2.Subtract \n 3.Multiply \n 4.Divide \n 5.Exit \n \n Enter a number (1 to 5): ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int operation) && operation >= 1 && operation <= 5)
            {
                if (operation == 5)
                {
                    Console.WriteLine("Exiting the program.");
                    break;
                }
                else
                {
                    int n1 = GetValidNumber("Enter a number: ");
                    int n2 = GetValidNumber("Enter another number: ");

                    switch (operation)
                    {
                        case 1:
                            Console.WriteLine("\nThe Sum of two numbers is : {0} \n", Add(n1, n2));
                            break;
                        case 2:
                            Console.WriteLine("\nThe Difference of two numbers is : {0} \n", Subtract(n1, n2));
                            break;
                        case 3:
                            Console.WriteLine("\nThe Product of two numbers is : {0} \n", Multiply(n1, n2));
                            break;
                        case 4:
                            Console.WriteLine("\nThe Division of two numbers is : {0} \n", Divide(n1, n2));
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
            }
        }
    }
}