// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


// int[] FillArrayWithRandomNumber(int size, int leftRange, int rightRange)
// {
//     int[] array = new int[size];

//     Random random = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = random.Next(leftRange, rightRange+1);
//     }
//     return array;
// }

// int[] arr = FillArrayWithRandomNumber(10, -10, 10);
// Console.WriteLine(string.Join(", ", arr));

int[] arr = {6, 7, 3, 6};

int newLength = arr.Length / 2 + arr.Length % 2;

int[] resultArr = new int[newLength];

for (int i = 0; i < newLength; i++)
{
    resultArr[i] = arr[i] * arr[arr.Length - 1 - i];
}
if(arr.Length % 2 == 1)
{
    resultArr[resultArr.Length - 1] = arr[arr.Length / 2];
}

Console.WriteLine(string.Join(", ", resultArr));