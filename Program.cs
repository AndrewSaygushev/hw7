// TASK 47

/*double [,] GetRandomArray (int rows, int columns, int deviation)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return array;
}

void PrintArray (double[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

double[,] array = GetRandomArray(5,6,1000);
PrintArray(array);*/


// TASK 50


/*Console.WriteLine("Enter the row's number");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the column's number");
int B = Convert.ToInt32(Console.ReadLine());

int [,] numbers = new int [5,5];

FillArrayRandomNumbers(numbers);

if (A > numbers.GetLength(0) || B > numbers.GetLength(1))
{
    Console.WriteLine("There is no such an element");
}
else
{
    Console.WriteLine($"The value of element ({A}, {B}) is {numbers[A-1,B-1]}");
}

Console.WriteLine();

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(1, 1500);
            }   
        }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}

Console.WriteLine();*/


// TASK 52

Console.WriteLine("Enter the number of rows");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number of columns");
int B = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[A, B];

Console.WriteLine();
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double AvarageNumbers = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        AvarageNumbers = (AvarageNumbers + numbers[i, j]);
    }
    AvarageNumbers = AvarageNumbers/ A;
    Console.Write(AvarageNumbers + "; ");
    Console.WriteLine();
}

Console.WriteLine();
PrintArray(numbers);



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

