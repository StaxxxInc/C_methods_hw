// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

//обьвляем необходимые переменные
int number, leng;
int coub = 0;

//метод получения данных от пользователя
void get_numbers()
{
    Console.Write("Введите число : ");
    number = Convert.ToInt32(Console.ReadLine());
    coub = number;
}

//метод получения кубов по условию
void create_coub()
{
    leng = coub;
    coub = 1;

    for (int i = 0; i < leng; i++)
    {

        number = coub;
        number = number * number * number;
        Console.WriteLine("куб " + coub + " : " + number);
        coub = coub + 1;

    }

}
get_numbers();
create_coub();