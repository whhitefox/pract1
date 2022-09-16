Console.WriteLine("введите первое число");
int Ch1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int Ch2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите операцию");
int Op = Convert.ToInt32(Console.ReadLine());
while (Op != 9)
{
    if (Op == 1)
    {
        Console.WriteLine(Ch1 + Ch2);
    }
    if (Op == 2)
    {
        Console.WriteLine(Ch2 - Ch1);
    }
    if (Op == 3)
    {
        Console.WriteLine(Ch1 * Ch2);
    }
    if (Op == 4)
    {
        Console.WriteLine(Ch1 / Ch2);
    }
    if (Op == 5)
    {
        Console.WriteLine(Math.Pow(Ch1, Ch2));
    }
    if (Op == 6)
    {
        Console.WriteLine(Math.Sqrt(Ch1));
        Console.WriteLine(Math.Sqrt(Ch2));
    }
    if (Op == 7)
    {
        Console.WriteLine(Ch1 * 0.01);
        Console.WriteLine(Ch2 * 0.01);
    }
    if (Op == 8)
    {
        int F = 1;
        for (int i = 1; i <= Ch1; i++)
        {
            F = F * i;
        }
        Console.WriteLine(F);
        F = 1;

        for (int i = 1; i <= Ch2; i++)
        {
            F = F * i;
        }
        Console.WriteLine(F);

    }
    Console.WriteLine("введите операцию");
    Op = Convert.ToInt32(Console.ReadLine());
}