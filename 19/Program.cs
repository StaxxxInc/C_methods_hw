// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, 
// является ли оно палиндромом.


//обьявляем необходимые переменные
int numbers;
int rev, a;
int result =0;

//метод получение числа с консоли от пользователя
void get_numbers()
{
    Console.Write("Введите число = ");
    int a = Convert.ToInt32(Console.ReadLine());
    numbers = a;
}

//метод проверки на полиндром
void get_polindrom()
{
    int n1n2, n4n5;

    n1n2 = numbers / 1000; //делением на 1000 получаем первые 2 числа
   // Console.WriteLine("n1n2 : " + n1n2);
    n4n5 = numbers % 100; //получаем остаток от деления и получаем последние 2 числа
   // Console.WriteLine("n4n5 : " + n4n5);
    rev = n4n5;
    reverse(rev); // нужно развернуть ччисла наоборот, вызовем отдельный метод который результатом своей работы вернет нам перевернутое число
    //проверка
    if (n1n2 == result)
    {   
       Console.WriteLine("Полиндром!");
    }
    else 
    Console.WriteLine("Число не является полиндромом");

}

//метод разворота числа
int reverse(int rev)
{
    a = rev % 10;
    rev = rev / 10;
    result += a * 10;

    a = rev % 10;
    rev = rev / 10;
    result += a;

   // Console.WriteLine("result : " + result);
    return result;

}


get_numbers();
get_polindrom();