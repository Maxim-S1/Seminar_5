// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
// Выводить сообщение "да" или "нет" ТОЛЬКО ОДИН РАЗ


// Первый метод
int[] FillArrayWithRandomNumber(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(leftRange, rightRange+1);
    }
    return array;
}
// Запуск первого метода - задание массива
int[] arr = FillArrayWithRandomNumber(10, -10, 10);
Console.WriteLine(string.Join(", ", arr)); // Вывод исходного массива
// Ввод данных с клавиатуры
Console.WriteLine("Какое число вы хотите найти в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
// Запуск второго метода
bool result = IsNumberInArray(arr, number);
if (result == true)
{
   Console.WriteLine("Да"); 
}
else
{
    Console.WriteLine("Нет");
}

// Второй метод - поиск числа
bool IsNumberInArray(int[] array, int fineNumber)
{
    bool flag = false; // Если элемента в массиве нет, то false(ложь), 
    //иначе - True (правда)
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == fineNumber)
        {
            flag = true; // исходный элемент найден
            break;
        }
    }
    return flag;
}