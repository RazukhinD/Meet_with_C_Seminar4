using static System.Console;
Clear();

//int[] array1={1,0,0,1};
//int[] array2=new int[4];

WriteLine("Введиде размер массива: ");
int size = int.Parse(ReadLine()!);
int[] array=GetBinaryArray(size);
PrintArray(array);
int zero=HowManyZerro(array);
WriteLine(zero);





int[] GetBinaryArray(int lenght)
{
    int[] result = new int[lenght];
    for (int i=0; i<lenght; i++)
    {
        result[i]=new Random().Next(0,2);
    }
    return result;
}

void PrintArray(int[] inArray)
{
    Write("[");
    for (int i=0; i<inArray.Length-1; i++)
    {
        Write($"{inArray[i]},");
    }
    WriteLine($"{inArray[inArray.Length-1]}]");
}

int HowManyZerro(int[] ourArray)
{
    int result1 = 0;
    for (int i=0;i<ourArray.Length;i++)
    {
        if (ourArray[i]==0)
        result1++;
    }
    return result1;
}