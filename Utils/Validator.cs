namespace ZombieSurvivalGame.Utils
{
    public static class Validator
    {
        public static string GetValidUsername(string prompt, Action redraw = null)
        {
            string input = "";
            while (true)
            {
                Console.Write(prompt);
                input = Console.ReadLine() ?? "";
                if (!string.IsNullOrEmpty(input.Trim()) && input.Length >= 3)
                {
                    return input;
                }
                else
                {
                    Console.Clear();
                    redraw?.Invoke();
                    ConsoleHelper.ErrorMessage("Username must be at least 3 characters long. Please try again.");
                }
            }
        }

        public static string GetValidInput(string prompt, Action redraw = null)
        {
            string input = "";
            while (true)
            {
                Console.Write(prompt);
                input = Console.ReadLine() ?? "";
                if (!string.IsNullOrEmpty(input.Trim()))
                {
                    return input;
                }
                else
                {
                    Console.Clear();
                    redraw?.Invoke();
                    ConsoleHelper.ErrorMessage("Input cannot be empty. Please try again.");
                }
            }
        }

        public static int GetValidNumber(string prompt, int min, int max, Action redraw = null)
        {
            int choice = -1;

            while (true)
            {
                string input = GetValidInput(prompt, redraw);

                if (int.TryParse(input, out choice))
                {
                    if (choice >= min && choice <= max)
                    {
                        return choice;
                    }
                    else
                    {
                        Console.Clear();
                        redraw?.Invoke();
                        ConsoleHelper.ErrorMessage($"Choice must be in range of {min} and {max}. Please try again.");
                    }
                }
                else
                {
                    Console.Clear();
                    redraw?.Invoke();
                    ConsoleHelper.ErrorMessage("Invalid input. Please enter a numeric value.");
                }
            }
        }

        public static bool GetValidBoolean(string prompt, Action redraw = null)
        {
            while (true)
            {
                string input = (GetValidInput(prompt, redraw).Trim().ToLower());

                if (input == "y" || input == "yes" || input == "true")
                {
                    return true;
                }
                else if (input == "n" || input == "no" || input == "false")
                {
                    return false;
                }
                else
                {
                    Console.Clear();
                    redraw?.Invoke();
                    ConsoleHelper.ErrorMessage("Invalid input. Please enter 'yes' or 'no' (y/n).");
                }
            }
        }
    }
}
