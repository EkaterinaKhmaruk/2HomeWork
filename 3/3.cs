/*Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.*/

bool correct = false;

while(!correct)
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number < 1 || number > 7)
    {
          Console.WriteLine("Некорректное число. ");
    }
    else if (number == 6 || number == 7) 
    {
        Console.WriteLine("Выходной!");
        break;
    }
    else
    {
        correct = true;
        Console.WriteLine("Будние");
    }  
}