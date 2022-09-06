Console.WriteLine("Введите число обозначающее день недели");
int numberDay=Convert.ToInt32(Console.ReadLine());

if (numberDay<1 || numberDay>7)
{
    Console.WriteLine("Ошибка");
}
if (numberDay==6 || numberDay==7)
{
    Console.WriteLine("Да - это выходной день!");
}
else if (numberDay>= 1 && numberDay<=5)
{
    Console.WriteLine("Нет - это не выдодной день.");
}
