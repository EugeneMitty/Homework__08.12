Console.WriteLine("Введите массив");
int size = Convert.ToInt32(Console.ReadLine);
int[] numbers = new int[size];
RandonNumbers(numbers);
Console.WriteLine("Массив ");
PrintArray(numbers);

void RandonNumbers(int[] numbers)
{
    for (int i = 0; i<size; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}

