Console.WriteLine("Введите Число: ");
int a = int.Parse(Console.ReadLine());
int b = -a;
Console.WriteLine("Ваши числа: ");
while (b<=a)
{
    Console.Write(b);
    Console.Write(", ");
    b = b + 1;
}