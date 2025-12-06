using System.Diagnostics;

namespace ZombieSurvivalGame.Utils
{
    public static class AnimationHelper
    {
        public static void Spinner(string message, int durationMs = 1200, int stepMs = 100)
        {
            Console.Write(message + " ");
            char[] seq = new[] { '|', '/', '-', '\\' };
            var sw = Stopwatch.StartNew();
            int i = 0;
            while (sw.ElapsedMilliseconds < durationMs)
            {
                Console.Write(seq[i++ % seq.Length]);
                Thread.Sleep(stepMs);
                Console.Write('\b');
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    // user pressed space -> speed up / stop spinner early
                    break;
                }
            }
            Console.WriteLine();
        }

        public static void SimulatedLoading(string message, string successMessage, int totalSteps = 10, int stepDelayMs = 200)
        {
            Console.WriteLine(message);
            for (int i = 0; i <= totalSteps; i++)
            {
                int percent = (i * 100) / totalSteps;
                Console.Write($"\rLoading: [{new string('#', i)}{new string(' ', totalSteps - i)}] {percent}%");
                Thread.Sleep(stepDelayMs);
            }

            ConsoleHelper.SuccessMessage("\n" + successMessage);
        }
    }
}
