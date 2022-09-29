

string[] array1 = { "hello", "2", "world", ":-)", "123" , "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan"}; // Задаем наш массив
int length = 0; // Обнуляем счетчик элементов, длина которых <= 3 символам

int ArrayElementsCountLessThanThree(string[] array) // Считаем количество элементов массива,  длина которых <= 3 символам
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) length++;
    }
    return length;
}

void ArrayElementsWriteOut(string[] array,string[] array1) //Копируем элементы  <= 3 символам в новый массив
{
    int i = 0;
    int j = 0;
    while(i < array.Length)
    {
        if (array[i].Length <= 3) 
        {
            array1[j] = array[i];
            j++;
        }
        i++;
    }
}

void ArrayElementsOutput(string[] array) // Вывод массива
{
    for (int i = 0; i < array.Length; i++) System.Console.Write($"{array[i]} ");
}

ArrayElementsCountLessThanThree(array1); // Считаем длину нового массива (получаем length)
string[] array2 = new string[length]; // Создаем новый массив длиной length
ArrayElementsWriteOut(array1, array2); // Заполняем новый массив элементами  <= 3 символам
ArrayElementsOutput(array1); // Выводим изначальный массив
Console.WriteLine(" ");
ArrayElementsOutput(array2); // Выводим новый массив с элементами <= 3 символам
if (length == 0) Console.WriteLine("В заданном массиве нет элементов <= 3 символам");