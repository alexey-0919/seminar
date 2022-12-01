Console.WriteLine("Введите трехзначное число");
int N = Convert.ToInt32(Console.ReadLine());

if ((1000>N) && (N>99))
{
    int result = N % 10;
    Console.WriteLine("Последняя цифра " + result);
}
else
{
    Console.WriteLine("Ошибка, введите трехзначное число");
}
