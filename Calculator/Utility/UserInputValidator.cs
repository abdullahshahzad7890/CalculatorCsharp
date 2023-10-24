public class UserInputValidator
{
    public static int GetValidNumber(string prompt)
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
}