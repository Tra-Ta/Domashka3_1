Console.WriteLine("Enter number -->");
int number = Convert.ToInt32(Console.ReadLine());

int ThreeDigit(int num)
{
    int theFirstAction = num / 100;
    int secondAction = theFirstAction % 10;
    int result = secondAction;
    return result;
}
int threeDigit = ThreeDigit(number);

if (number < 100) Console.WriteLine("There is no third digit");
else Console.WriteLine($"The second digit of the number --> {threeDigit}");
