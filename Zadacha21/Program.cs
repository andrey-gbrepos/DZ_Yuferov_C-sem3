//Задача 21
//Напишите программу, которая принимает на вход координаты двух 
//точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

// Метод - ввод 3-х координат точки
int[] fillingArray (int count)
{
int[] array = new int[3];
while (count<3)
{
    switch (count)
        {
            case 0:
            Console.Write("Введите первую координату точки: ");
            break;
        
            case 1:
            Console.Write("Введите вторую координату точки: ");
            break;

            case 2:
            Console.Write("Введите третью координату точки: ");
            break;
        }
    array[count] =int.Parse(Console.ReadLine()); 
    count++;
    }
    return array;
}

Console. Clear(); 
Console.WriteLine("Программа определит расстояние между двумя точками в 3D пространстве");
Console.WriteLine("");

//Массивы для координат
int[] arrA = {0,0,0};
int[] arrB = {0,0,0};
// Для результата
double distance = 0;

Console.WriteLine("Введите три координаты первой точки (целочисленное значение)");
Console.WriteLine();
arrA = fillingArray(0);
Console.WriteLine();

Console.WriteLine("Введите три координаты второй точки (целочисленное значение) ");
Console.WriteLine();
arrB = fillingArray(0);
Console.WriteLine();  
distance = Math.Sqrt(Math.Pow(arrA[0]-arrB[0],2)+ Math.Pow(arrA[1]-arrB[1],2)+Math.Pow(arrA[2]-arrB[2],2));

Console.WriteLine($"Расстояние между точками: {distance:f2}");
Console.WriteLine();