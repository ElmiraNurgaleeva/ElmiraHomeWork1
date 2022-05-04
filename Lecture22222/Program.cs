// Метод или функция которая будет выводить все элементы по порядку - Код поиска превратив в Метод :
//Есть методы в языке СиШарп которые могут возвращать значения а могeт не возвращать, метод не возвращает  это Void

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

int[] array = new int [10];   // new int [10]; - означает создай новый массив в котором будет 10 элементов, по умолч здесь будут 000

FillArray(array);     // Метод заполнения массива
PrintArray(array);    //Метод печати массива

