// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;

Console.WriteLine("enter n1");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter n2");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine("");

for (var i = n1; i <= n2; i++ )


{
    bool isprimenumber = true;

    for (var j = 2; j < i; j++)
    {
        if(i % j ==0)
        {
            isprimenumber = false;
            break;
        }
    }
    if(isprimenumber)
    {
        Console.WriteLine(i + " - ");
    }
}








