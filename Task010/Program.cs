Console.WriteLine("Enter three-digit number ->");
int number = Convert.ToInt32(Console.ReadLine());

int MiddleDigit(int num)
{
    int theFirstAction = num / 10;
    int secondAction = theFirstAction % 10;
    int result = secondAction;
    return result;
}
int middleDigit = MiddleDigit(number);

if (number > 999 || number < 100) Console.WriteLine("The number is not three-digit");
else Console.WriteLine($"The second digit of the number --> {middleDigit}");