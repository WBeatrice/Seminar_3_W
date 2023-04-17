/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

int Read()
{
    Console.Write("Enter a five-digit number: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

bool Palindrom(int num)
{
    if (num >= 0 && num < 10000)
        return true;
    int numLength = GetLength(num);
    int[] digits = new int[numLength];
    for (int i = numLength - 1; i >= 0; i--)
    {
        digits[i] = num % 10;
        num /= 10;
    }
    for (int i = 0; i < numLength / 2; i++)
    {
        if (digits[i] != digits[numLength - i - 1])
            return false;
    }
    return true;
}

int GetLength(int num)
{
    int n = 0;
    while (num > 0)
    {
        num /= 10;
        n++;
    }
    return n;
}

int number = Read();
Console.WriteLine(Palindrom(number));
