internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        int xa = 28, ya = 4,
            xb = 4, yb = 20,
            xc = 50, yc = 20;

        Console.SetCursorPosition(xa, ya);
        Console.WriteLine('*');

        Console.SetCursorPosition(xb, yb);
        Console.WriteLine('*');

        Console.SetCursorPosition(xc, yc);
        Console.WriteLine('*');

        int x = xa, y = xb;
        int Count = 0;

        while (Count < 1000)
        {
            int N = new Random().Next(0, 3);
            if (N == 0)
            {
                x = (x + xa) / 2;
                y = (y + ya) / 2;
            }

            if (N == 1)
            {
                x = (x + xb) / 2;
                y = (y + yb) / 2;
            }
            if (N == 2)
            {
                x = (x + xc) / 2;
                y = (y + yc) / 2;
            }
            Console.SetCursorPosition(x, y);
            Console.WriteLine('*');
            Count++;

        }
    }
}