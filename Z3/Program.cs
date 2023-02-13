// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1,99);
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
int maxNumber = numbers[0];
int minNumbers = numbers[0];
for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z]  > maxNumber)
    {
    maxNumber = numbers[z];
    }
    if (numbers[z]<minNumbers)
    {
    minNumbers = numbers[z];   
    }
         
    }
rezult=maxNumber-minNumbers;   
Console.WriteLine(rezult);