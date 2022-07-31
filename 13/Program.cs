//  Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет


//обьявляем глабальную переменную - массив из трех элементов
char[] mas = new char[3];
int third;


//заполняем массив с полученной строки из консоли
void make_array()
{
            Console.WriteLine("Введите массив:");       
            string s = Console.ReadLine();
            third = s.Length;

            char[] entered_mas = new char[s.Length];
            //разбиваем полученную строку на массив 
            for (int i = 0; i < s.Length; i++)
            {
                entered_mas[i] = s[i];
                //заполняем глобально созданный массив
                mas[i] = entered_mas[i];
            }

           // Console.ReadLine();

}

// выводим третий элемент массива 
void third_item(char[] mas)
{
   Console.WriteLine("третий элемет:");
   Console.WriteLine(mas[2]);
}

void third_element()
{
    if (third < 3)
        Console.WriteLine("Третьего элемента нет");
    else
        third_item(mas); 
}

make_array();
third_element();
