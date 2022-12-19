int num, i, n1, n2;
Console.WriteLine("enter the first number");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter the last number");
n2 = int.Parse(Console.ReadLine());
Console.Write("The perfect numbers between {0} and {1} are : \n", n1, n2);

for ( num = n1; num <= n2; num++)
{
    decimal sum = 0;
    for ( i = 1; i < num; i++)
    {
        if (num % i == 0)
            sum = sum + i;
    }
    if (sum == num)
        Console.WriteLine("\t" + num);
}