// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

void Main()
{
    int arraySize = ReadInt("Введите количество чисел в массиве: ");
    int[] array = GenerateArray(arraySize, -10, 10);
    PrintArray(array);

    ChangeArray(array);
    System.Console.WriteLine();
    PrintArray(array);
}


int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}


int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] myArray = new int[size];

    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(leftRange, rightRange + 1); // 0 до 10;
    }

    return myArray;
}


void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        System.Console.Write(arrayForPrint[i] + "\t");
    }
}

void ChangeArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] *= -1; // array[i] = array[i] * -1
    }
}

Main();