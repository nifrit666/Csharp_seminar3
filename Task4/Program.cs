

void Main()
{
    int arraySize = ReadInt("Введите количество чисел в массиве: ");
    double[] array = GenerateDoubleArray(arraySize, -10, 10);
    PrintArray(array);
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

double[] GenerateDoubleArray(int size, int leftRange, int rightRange)
{
    double[] myArray = new double[size];

    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = Math.Round(new Random().NextDouble() + new Random().Next(leftRange, rightRange + 1), 3); // 0 до 10;
    }

    return myArray;
}

void PrintArray(double[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        System.Console.Write(arrayForPrint[i] + "\t");
    }
}

Main();