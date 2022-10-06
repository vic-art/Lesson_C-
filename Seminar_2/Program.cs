int[] array = {4, 9, 3};

int max = Max(array[0], array[1], array[2]); // запуск функции

Console.WriteLine($"{max}");

int Max(int _a, int _b, int _c)
{
    int max = _a;
    if (_b > max) max = _b;
    if (_c > max) max = _c;
    return max;

}

