// С клавиатуры считывается массив чисел через запятую
//в виде: 1,3,4,5,6,7,8,3,4

//Получить новый массив, в котором будут квадраты четных чисел

////16,36,64,16
//С клавиатуры считывается массив чисел через запятую
//в виде: 1,3,4,5,6,7,8,3,4

//Получить новый массив, в котором будут квадраты четных чисел

//16,36,64,16

//НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ split 
//ИДЕАЛЬНО - если будет алгоритм(БС) основного действия


string s_global;
string incept;
int leng;
int[] array = new int[10];

//получаем массив от пользователя
void get_array()
{
            Console.WriteLine("Введите массив:");       
            string s = Console.ReadLine();
            leng = s.Length; //нужна длинна для цикла перебора элементов
            s_global = s; 

}

//вынимаем необходимые данные из полученного массива в get_array
void incept_array(string s)
{

int i= 0; 
//int j= 0;


while (i < leng)
 {
    //array[i] = Convert.ToInt32(s_global[i].ToString());
    
    //array[i] = s_global[i];

    
    for(int k=0; k<leng; k++)
    {
        

        if(array[i] == ',')
        {
         // incept = ;
        }

    }
    Console.WriteLine("array = " + array[j]);  
    j = j+j;
 }
 
    
    make_kvadrat();
}

//берем данные из отсортированного массива и ворзводим в квадрат
void make_kvadrat()
{
      for (int i=0; i<10; i++)
    {
        array[i] = array[i] * array[i];
        Console.WriteLine("Измененный массив:");  
        Console.WriteLine(array[i]);
    }
    

}



get_array();

incept_array(s_global);

/*

string s = "123";
Console.WriteLine(4 + Convert.ToInt32(s[0].ToString()));
Console.WriteLine(Convert.ToInt32(' '));
Console.WriteLine(s[0]);

*/

