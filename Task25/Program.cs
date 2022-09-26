using static System.Console;
Clear();


WriteLine("Введиде число А: ");
int number1 = int.Parse(ReadLine()!);
WriteLine("Введите число B:");
int number2 = int.Parse(ReadLine()!);
int exp = Exponintation(number1,number2);
WriteLine(exp);



int Exponintation(int A, int B)
{
    int result=1;
    for (int i=1; i<=B; i++)
    {
        result=result*A;
    }
    return result;
}