// Функция - Заполнение массива
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = i + 1;
        // Console.Write($"{arr[i]}; ");
    }
}

// Функция - Вывод массива
void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

// Функция - Получение суммы элементов массива
int GetSumOfElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum = sum + arr[i];
    }
    return sum;
}

// Функция - Получение произведения элементов массива
int GetProductOfElements(int[] arr)
{
    int product = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        product = product * arr[i];
    }
    return product;
}

// Ввод данных
int n = 4;
int[] arr = new int[n];
FillArray(arr);
PrintArray(arr);
int sum = GetSumOfElements(arr);
int product = GetProductOfElements(arr);
Console.WriteLine($"\nСумма элементов массива = {sum}.");
Console.WriteLine($"Произведение элементов массива = {product}.");