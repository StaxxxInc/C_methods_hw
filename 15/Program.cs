// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели,и проверяет,
// является ли этот день выходным.
int day;

void get_day()
{
    Console.Write("Введите день = ");
    int a = Convert.ToInt32(Console.ReadLine());
    day = a;
}

void get_holliday(int day)
{
    if (day == 0)
    {
        Console.Write("такого дня недели нет");
    }
    if (day > 7)
    {
        Console.Write("такого дня недели нет");
    }
   
    if (day > 5)
        Console.Write("да");
    else
        Console.Write("нет");

}



get_day();
get_holliday(day);

