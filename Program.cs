// See https://aka.ms/new-console-template for more information

int first, second, x, y, sum;
Console.WriteLine("Enter the first");
first = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second");
second = int.Parse(Console.ReadLine());

for (x = first; x <= second; x++)
{
    y = 1;
    sum = 0;
    while (y < x)
    {
        if (x % y == 0)
            sum = sum + y;
        y++;
    }
    if (sum == x && x != 0)

        Console.WriteLine("{0}", x);
}
        
    
