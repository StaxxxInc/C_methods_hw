//обьявляем глабальную переменную - массив из трех элементов
char[] mas = new char[3];

//заполняем массив с полученной строки из консоли
void make_array()
{
            Console.WriteLine("Введите массив:");       
            string s = Console.ReadLine();

            char[] entered_mas = new char[s.Length];
            //разбиваем полученную строку на массив 
            for (int i = 0; i < s.Length; i++)
            {
                entered_mas[i] = s[i];
                //заполняем глобально созданный массив
                mas[i] = entered_mas[i];
            }

            //Console.ReadLine();

}

// выводим второй элемент массива 
void second_item(char[] mas)
{
   Console.WriteLine("Второй элемет:");
   Console.WriteLine(mas[1]);
}
//выполняем
make_array();
second_item(mas);
