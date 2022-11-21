Console.WriteLine("Enter digit ->");
int digit =Convert.ToInt32(Console.ReadLine());

bool CheckingWeekend (int num)
{
   if(num == 1) Console.Write("Monday");
else if(num == 2) Console.Write("Tuesday");
else if(num == 3) Console.Write("Wednesday");
else if(num == 4) Console.Write("Thursday");
else if(num == 5) Console.Write("Friday");
else if(num == 6) Console.Write("Saturday");
else if(num == 7) Console.Write("Sunday");
return num > 5;
}

bool result = CheckingWeekend (digit);

if (digit > 7 )Console.WriteLine("Out diaposon");  

else Console.WriteLine($" weekend?-> {result}");

