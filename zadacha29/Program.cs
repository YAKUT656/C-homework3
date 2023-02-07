// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

//int lenArray = ReadInt("Введите длинну массива: ");

//int[] randomArray = new int[lenArray];
//for (int i = 0; i < randomArray.Length; i++)
//{
    //randomArray[i] = new Random().Next(1,9);
    //Console.Write(randomArray[i] + " ");
//}


// Функция ввода
//int ReadInt(string message)
//{
    //Console.Write(message);
    //return Convert.ToInt32(Console.ReadLine());
//}

int[] getArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,9);
    }
    return array;
}
void printArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
        Console.Write($"{inArray[i]} ");
}
int[] array = getArray(); printArray(array);
