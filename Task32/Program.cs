// Задача 32: Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] arr = FillArrayWithRandomNumber(10, -10, 10);
Console.WriteLine(string.Join(", ", arr)); // Вывод исходного массива
SwapSignOfArrayElements(arr);
Console.WriteLine(string.Join(", ", arr)); // Вывод результирующего массива


// Метод возвращает на size элементов
int[] FillArrayWithRandomNumber(int size, int leftSize, int rightSize)
{
    int[] array = new int[size];

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(leftSize, rightSize+1);
    }
    return array;
}

void SwapSignOfArrayElements(int[] array) //метод принимает в себя только массив 
// и ничего не возвращает
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = - array[i];
        // array[i] = array[i] * - 1;
    }
}
