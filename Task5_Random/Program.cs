Random rnd = new Random();

int size = 10;
int[] arr_int = new int [size];
int i = 0;

while (i < size)
{
    arr_int[i] = rnd.Next(1, 10); // Верхняя граница (10 в данном случае) не включается в генерируемые случайные числа
    Console.Write($"{arr_int[i]} ");
    i++;
}