// Написать программу, которая изимеющегося массива строк формирует 
//массив из строк длина которых меньше либо равна три символа. Первоначальный массив
//можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении 
//не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
//

Console.Clear();

void GenerateArray(string [] array, int arrayLength)
{
    int sum = 0;
    for(int i = 0; i < arrayLength; i++)
    {
        sum++;
        System.Console.WriteLine($"Введите {sum} строку из {arrayLength}:");
        array[i] = Console.ReadLine();     
    }       
}


void PrintArray(string [] array, int lengthArray)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"\"{array[i]}\", ");
    }
    System.Console.WriteLine();
}
