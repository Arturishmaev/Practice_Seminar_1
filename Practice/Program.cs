/*System.Console.WriteLine("Введите Ваше число");
int num1 = Convert.ToInt32(Console.ReadLine());
int result = num1 * num1;
System.Console.WriteLine($"Результат :   {result}");



System.Console.WriteLine("Введите первое число :");
int num = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число :");
int num1 = Convert.ToInt32(System.Console.ReadLine());
int result = num * num1;
if (num == result)
{
    System.Console.WriteLine("Первое число являтся квадратом второго");

}
else
{
    System.Console.WriteLine("Первое число не является квадратом второго");
}*/

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
System.Console.WriteLine("Понедельник");
}
 else if (num == 2)
{
    System.Console.WriteLine("Вторник");
}
else if (num == 3)
{
    System.Console.WriteLine("Среда");
}
else if (num == 4)
{
    System.Console.WriteLine("Четверг");
}
else if (num == 5)
{
    System.Console.WriteLine("Пятница");
}
else if (num == 6)
{
    System.Console.WriteLine("Суббота");
}
else if (num == 7)
{
    System.Console.WriteLine("Воскресенье");
}
else
{
System.Console.WriteLine("ERORR");
}




