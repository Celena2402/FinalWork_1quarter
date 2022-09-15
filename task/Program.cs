/*
Задача: Написать программу, которая из имеющегося массива строк формирует 
новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

*/

string [] StringArray(string[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i]=Console.ReadLine();

    }
    return array;
}

void PrintArray(string[] array)
{
    for (int i=0; i<array.Length;i++)
    {       
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] NewStringArray(string[] array)
{
    string[] result=new string[array.Length];
    int k=0;
    for (int i=0; i<array.Length;i++)
    {
        if (array[i].Length<=3)
        {
            result[k]=(array[i]);
            k++;
        }        
    }
return result;
}

Console.Write("Сколько слов будет вводиться? - ");
int leng=Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите {leng} слов(а):");
string [] Array=new string[leng];
StringArray(Array);
Console.WriteLine("Получился такой масив:");
PrintArray(Array);

Console.WriteLine();

string[] newArray= NewStringArray(Array);
Console.WriteLine("Новый масcив, в котором длина строк <=3 : ");
PrintArray(newArray);
