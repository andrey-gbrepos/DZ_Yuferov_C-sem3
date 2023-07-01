//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console. Clear(); 
Console.WriteLine("Программа принимает на вход число N и выдает таблицу кубов чисел от 1 до N ");
Console.WriteLine();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();
int[]arr = new int[Math.Abs(N)];

int sign = 1;// для знака введенного числа
if (N<0)
{
   sign = -1; 
}
else
{
  sign = 1;  
}

for (int i= 0; i<Math.Abs(N); i++)
{
arr[i] = (i+1)*sign;
Console.Write($"{Math.Pow(arr[i],3)}  ");
}

