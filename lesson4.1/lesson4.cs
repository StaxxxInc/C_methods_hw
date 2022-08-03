/// 1  Считывание
//  10 преобразовывание данных
/// 3  получение квадратов четных чисел
// первая - узнать сколько четных чисел
// вторая - создать набор квалратов
/// 
/// ++ 0  печать массива
/// 

void Print(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

string GetData(string title)
{
    Console.Write(title);
    return Console.ReadLine()!;
}

int[] MainEx(int[] array)
{
    int size = array.Length;
    int isEvenCount = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            isEvenCount++;
        }
    }

    int[] result = new int[isEvenCount];

    int index = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            result[index] = array[i] * array[i];
            index++;
        }
    }

    return result;
}

int CountSynbol(string s, char c)
{
    int count = 0;
    int length = s.Length;
    for (int i = 0; i < length; i++)
    {
        if (s[i] == c) count++;
    }
    return count;
}

int IndexOf(string s, char c)
{
    int length = s.Length;
    //int pos = -1;
    for (int i = 0; i < length; i++)
    {
        if (s[i] == c)
        {
            return i;
            //pos = i;
            //break;
        }
    }
    //return pos;
    return -1;
}

string Substring(string s, int position)
{
    string res = String.Empty;

    int size = s.Length;
    for (int i = position; i < size; i++)
    {
        res += $"{s[i]}";
    }

    return res;
}

string SubstringLength(string s, int position, int length)
{
    string res = String.Empty;

    int size = s.Length;
    for (int i = position; i < position + length; i++)
    {
        res += $"{s[i]}";
    }

    return res;
}


int[] Parse(string s)
{
    int[] result = new int[CountSynbol(s, ',') + 1];
    s += ",";
    int index = 0;

    while (s.Length != 0)
    {
        int posSeparator = IndexOf(s, ',');
        //System.Console.WriteLine($"pos {posSeparator}");
        string need = SubstringLength(s, 0, posSeparator);
        //System.Console.WriteLine($"need = {need}");
        string o = Substring(s, posSeparator + 1);

        //System.Console.WriteLine($"o    = {o}");
        //Console.ReadLine();
        s = o;
        result[index] = Convert.ToInt32(need);
        index++;
    }


    return result;
}


string str = GetData("Введите числа через запятую: ");
int[] inArr = Parse(str);
Print(inArr);
int[] outArr = MainEx(inArr);
Print(outArr);

// Console.WriteLine(
// Substring(s, 5)
// );

// Console.WriteLine(
// SubstringLength(s, 0, 5)
// );
// Console.WriteLine(
// IndexOf("143,243,3343,443,5434,643,71,8342", ',')
// );

// Console.WriteLine(CountSynbol(
// "143,243,3343,443,5434,643,71,8342",
// ','
// ));


// string str = GetArray("Введите числа через запятую: ");
// int[] inArr = { 1, 4, 5, 6, 87, 1, 111, 1000, 333, 4 };
// Print(inArr);
// int[] outArr = MainEx(inArr);
// Print(outArr);