// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
bool correct = false;

while(!correct)
{
    Console.WriteLine("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number / 100 == 0 || number / 100 > 9)
    {
          Console.WriteLine("Некорректное число, введите число из 3 цифр! ");
    }
    else
    {
        correct = true;
        int secondtDigit1 = number / 10;
        int secondtDigit2 = secondtDigit1 % 10;
        int firstDigit = number / 100;
        int lastDigit = number % 10;


        Console.WriteLine("Вторая цифра этого числа: "+ secondtDigit2);
    }  
}







