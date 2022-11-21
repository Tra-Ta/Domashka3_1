Console.WriteLine("Enter number -->");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}
if (number < 0) number= -number;
if (number >99 )
{
    int result = ThirdDigit(number);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("No Third Digit");
}