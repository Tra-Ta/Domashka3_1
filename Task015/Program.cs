Console.WriteLine("Enter digit ->");
int digit =Convert.ToInt32(Console.ReadLine());

bool MultiplicityTwoDigits (int num)
{
   return num % 7 == 0 && num % 23 == 0;
}

bool result = MultiplicityTwoDigits(number);

string resultStr = result ? "ДА" : "НЕТ";

Console.WriteLine($"{number} weekend?-> {resultStr}");
