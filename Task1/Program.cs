// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Не

void Main()
{
    int arraySize = ReadInt("Введите количество чисел в массиве: ");

    int[] array = GenerateArray(arraySize, -9, 9);
    PrintArray(array);

    int number = ReadInt("Введите искомое число: ");

    bool numberIsFinded = NumberIsExist(array, number);

    if (numberIsFinded)
    {
        System.Console.WriteLine("Да");
    }
    else
    {
        System.Console.WriteLine("Нет");
    }
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
        System.Console.Write(arrayForPrint[i] + " ");
    }
}


bool NumberIsExist(int[] myArray, int number)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] == number)
        {
            return true;
        }
    }

    return false;
}


Main();