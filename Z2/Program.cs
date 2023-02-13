// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-99,99);
    }
}
void PrintArray(int[] numbers)
{
       for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
        Console.WriteLine();
}

int[] numbers = new int[4];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int rezult = 0;
for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] % 2 == 0)
    {
    
    }
    else
    {
    rezult=rezult+numbers[z];    
    }
}
Console.WriteLine($"Сумма не четных чисел {rezult}");