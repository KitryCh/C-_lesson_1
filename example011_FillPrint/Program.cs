// Заполнение массива и печать его на экран.
// 1. возьмем метод (функцию), передадим в него массив и заполним массмв нужным количество эоементов
// 2. опишем метод (функцию), который будет выводить все элементы по порядку
// 3. Превратим код поиска нужного нам индекса в метод (функцию)

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random() .Next(1, 10);
        index = index + 1;           
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

int[] array = new int[10];

FillArray(array);
PrintArray(array);