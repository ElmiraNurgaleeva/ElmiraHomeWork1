﻿//метод отличный от Void

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;   // или  index = index + 1
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}

int[] array = new int [10];   // new int [10]; - означает создай новый массив в котором будет 10 элементов, по умолч здесь будут 000

FillArray(array);     // Метод заполнения массива
PrintArray(array);    //Метод печати массива
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
