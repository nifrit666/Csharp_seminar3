// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
//  0 1 2 3 4 5
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

void Main()
{
    int arraySize = ReadInt("Введите количество чисел в массиве: ");
    int[] array = GenerateArray(arraySize, -10, 10);
    PrintArray(array);

    System.Console.WriteLine();

    PrintArray(FindPair(array));
}

int[] FindPair(int[] myArray)
{
    int[] newArray = new int[myArray.Length / 2]; // 7 / 2 -> 3

    for (int i = 0, j = myArray.Length - 1; i < myArray.Length / 2; i++, j--)
    {
        newArray[i] = myArray[i] * myArray[myArray.Length - 1 - i]; // 6 - 1 - 1 -> 4
    }

    return newArray;
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

Main();
