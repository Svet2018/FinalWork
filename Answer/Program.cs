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


void GenerateNewArray(string [] array, int count)
{
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= count)
        {
            array[i] = array[i];
        }
    }       
}


void PrintNewArray(string [] array, int count)
{
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= count)
        {
            System.Console.Write($"\"{array[i]}\", ");    
        }
    }   
    System.Console.WriteLine();    
}


System.Console.WriteLine("Введите какое количество строк Вы хотите проверить. ");

int lengthArray = Convert.ToInt32(Console.ReadLine());
string [] newArray = new string [lengthArray];


GenerateArray(newArray, lengthArray);
System.Console.WriteLine();
System.Console.WriteLine($"Сгененрирован массив из {lengthArray} строк:");
System.Console.WriteLine();
PrintArray(newArray, lengthArray);
System.Console.WriteLine();
int count = 3;
System.Console.WriteLine($"Сгененрирован новый массив, в котором длина строк меньше или равна {count} символам:");
System.Console.WriteLine();
GenerateNewArray(newArray, count);
PrintNewArray(newArray, count);
System.Console.WriteLine();