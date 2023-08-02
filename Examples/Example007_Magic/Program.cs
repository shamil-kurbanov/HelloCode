using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        WriteLine("Welcome to the Magic Program!");
        WriteLine("Press any key to continue...");
        ReadKey(true);
        Clear();
        //BackgroundColor = ConsoleColor.White;
        //ForegroundColor = ConsoleColor.Black;

        int xa = 40, ya = 1,
            xb = 1, yb = 30,
            xc = 80, yc = 30;

        SetCursorPosition(xa, ya);  // Set cursor position to xa, ya
        WriteLine("+");                 // Write a plus sign

        SetCursorPosition(xb, yb);  // Set cursor position to xb, yb
        WriteLine("+");                 // Write a plus sign

        SetCursorPosition(xc, yc);  // Set cursor position to xc, yc
        WriteLine("+");                 // Write a plus sign

        int x = xa, y = xb;

        int count = 0;

        while (count < 10000)
        {
            int r = new Random().Next(0, 3);

            switch (r)
            {
                case 0:
                    x = (x + xa) / 2;
                    y = (y + ya) / 2;
                    break;
                case 1:
                    x = (x + xb) / 2;
                    y = (y + yb) / 2;
                    break;
                case 2:
                    x = (x + xc) / 2;
                    y = (y + yc) / 2;
                    break;
            }

            SetCursorPosition(x, y);
            WriteLine("+");

            count++;
        }
    }
}