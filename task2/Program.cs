//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int i = Convert.ToInt32(Console.ReadLine());
int sam = 0;

while (i > 0)
{
    int number = i % 10;
    i = i / 10;
    sam = sam + number;
}
Console.WriteLine("Сумма всех цифр в числе равна: " + sam);