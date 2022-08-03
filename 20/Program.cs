// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

int y0, x0, z0, y1, x1, z1;


void get_coordinats()
{
    Console.Write("Введите y0 = ");
    y0 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите x0 = ");
    x0 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите z0 = ");
    z0 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите y1 = ");
    y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите x1 = ");
    x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите z1 = ");
    z1 = Convert.ToInt32(Console.ReadLine());

}

void find_distance()
{
    double dist;
  // √((x2-x1)^2)+(y2-y1)^2+(z2-z1)^2
   dist = Math.Sqrt((Math.Pow((x1-x0),2))+Math.Pow((y1-y0),2)+Math.Pow((z1-z0),2));
   Console.Write("Расстояние =" + dist);


}


get_coordinats();
find_distance();