// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76
int size = ReadInt("Введите размер массива: ");
double[] numbers = new double[size];
double Max = 0; 
double Min = 0;
double raznost = 0;

FillArrayRandomNumbers(numbers, 0, 100);
WriteArray(numbers);

FindMinMaxValue();    

raznost = Max - Min;

Console.WriteLine(raznost);


void FillArrayRandomNumbers(double[] array, int min, int max)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble()*100;
    }
}

void WriteArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FindMinMaxValue()
{   
    Min = numbers[0];
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] > Max)
                Max = numbers[i];
        if(numbers[i] < Min)
                Min = numbers[i];
    }
}

