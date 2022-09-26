using static System.Console;
Clear();

WriteLine("Введите число");
int A = int.Parse(ReadLine()!);
int sum=GetSumm(A);
WriteLine($"Сумма числе от 1 до {A} равна:{sum}");


int GetSumm(int number)
{
    int result = 0;
    while (number>0)
    {
        result+=number;
        number--;
    }
    return result;
}
