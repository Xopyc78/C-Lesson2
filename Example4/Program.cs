/* Void - Метод(функция) который ничего не возвращает
1) Определили массив (строка 46)
2) FillArray - метод заполнили массив
3) PrintArray - метод Распечатали массив
*/

void FillArray(int[] collection)                                
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int []col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
     return position;
}

int[] array = new int[10]; // Создай новый массив в котором будет 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine(); // просто отступ

int pos = Index0f(array, 4);
Console.WriteLine(pos);