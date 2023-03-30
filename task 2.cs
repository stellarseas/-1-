int max = 0;
int min = 0;
string input = Console.ReadLine();
Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
Console.WriteLine ("max = " + firstNumber);
Console.WriteLine ("min = " + secondNumber);
}
if (firstNumber < secondNumber)
{
Console.WriteLine ("max = " + secondNumber);
Console.WriteLine ("min = " + firstNumber);
}
 Console.ReadLine();
