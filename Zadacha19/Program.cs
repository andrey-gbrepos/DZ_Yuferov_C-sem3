//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

// Метод - определяет: пятизначное число или нет
bool plndrStatus(int fiveSign)
{
    if (fiveSign < 10000 || fiveSign > 99999)
    {       
        return false;
    }
    else
    {
        return true;
    }
}
//Метод - определяет палиандр или нет
bool plndrYesOrNow (int polindr)
{
    // Отбираем двухзначные числа по краям
    int start2 = polindr/1000;
    int end2 = polindr%100;
    //Перекрестная проверка
    if (start2/10 == end2%10 && start2%10 == end2/10)
        {      
                return true;
        }
     else
        {      
            return false;
        }

    }

//Собственно сама программа

Console. Clear(); 
Console.WriteLine("Программа определит, является ли введенное Вами пятизначное число ПАЛИНДРОМОМ");
Console.WriteLine("");
Console.Write("Введите пятизначное число: ");
int number =int.Parse(Console.ReadLine()); 

if (plndrStatus(number))
{
    if (plndrYesOrNow (number))
    {
    Console.Write("Введенное Вами число ЯВЛЯЕТСЯ палиндромом");
    }
    else
    {
    Console.Write("Введенное Вами число НЕ является палиндромом"); 
    }
}
else
{
    Console.Write("Вы ввели не пятизначное число");
    return;
}