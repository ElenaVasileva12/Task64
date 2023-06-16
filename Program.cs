// Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
//головная рекурсия выводит в прямом порядке
void NaturalNumbers(int num)
{
    if (num==0) return;
    NaturalNumbers(num-1);  //сохраняются в стек 5,4,3,2,1
    
    Console.Write($"{num} "); //строка после перебора начинает выполняться - 1,2,3,4,5
}
*/
//хвостовая рекурсия (стек не используется) выводит в обратном порядке
void NaturalNumbers(int num)
{
    if (num==0) return;
    Console.Write($"{num} "); 
    NaturalNumbers(num-1);  
}

//проверка на корректность
bool CheckNaturalNumbers (int num)
{
   return num>0;      
}


Console.WriteLine("Введите натуральное число: ");
int number=Convert.ToInt32(Console.ReadLine());


if (CheckNaturalNumbers(number)) 
{
NaturalNumbers(number);
}
else 
{
Console.WriteLine($"Ошибка, число должно быть натуральным");
}


