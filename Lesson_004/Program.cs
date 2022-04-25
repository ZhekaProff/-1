Console.WriteLine("Введите Число: ");
int a = int.Parse(Console.ReadLine());
int b = -a;
Console.WriteLine("Ваши числа: ");
while (b<=a)
{
    Console.WriteLine(b);
    b = b + 1;
}