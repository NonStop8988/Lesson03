double CalculateFormula(int a, int b, int c, int d) // Создаем функцию
{
    double numenator = a * b;
    int denomenator = c + d;
    double result = numenator / denomenator;
    return result;
}

double result = CalculateFormula(1, 2, 3, 4); // Запускаем созданную нами функцию
Console.Write(result);

