using static System.Console;
Clear();


WriteLine("Введиде число : ");
int number = int.Parse(ReadLine()!);
int sum = SummofNumber(number);
WriteLine(sum);










int SummofNumber(int number)
{
    int result = 0;
    while (number!=0)
    {
        result+=number%10;
        number=number/10;
    }

    return result;
}