int[] array = {4, 9, 3, 7, 2, 9, 2, 5};
int[] array2 = {4, 2, 3, 2, 2, 9, 1, 5};

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array2[i]}");

Sort(array2);
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array2[i]}");

void Sort(int[] _array)
{
    for (int j = 0; j < _array.Length - 1; j++)
    {
        for (int i = 0; i < _array.Length - 1 ; i++)
        {
            if (_array[i] > _array[i+1])
            {
                int temp = _array[i];
                _array[i] = _array[i+1];
                _array[i+1] = temp;

            }
        }
    }
}