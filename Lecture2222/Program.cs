// Задача2 Массивы и фукнкция : Имеется одномерный массив array из n  элементов, 
//требуется найти элемент массива, равный find

// индекс       0  1   2   3  4   5  6   7
int[] array = { 1, 18, 31, 4, 15, 6, 17, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while(index < n)
{
    if(array[index]==find)
    {
        Console.Write("Индекс данного числа равен:  ");
        Console.WriteLine(index);
        break;    //Новый оператор Означает Прерви то есть найдет 1й элемент под числом 18 и выдаст результат и прервет
    }
    index++;   // или  index = index + 1
}