// Задача 32: Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array1(int size, int leftSize, int rightSize)
{
    int[] arr = new int[size];

    Random random = new Randome();
    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(leftSize, rightSize+1);
    }
    return arr;
}