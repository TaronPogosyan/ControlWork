// Задача: 
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 


string[] matrix1 = new string[4] { "Hello", "2", "world", ":-)" };
// string[] matrix1 = new string[3] { "Russia", "Denmark", "Kazan" };
// string[] matrix1 = new string[4] { "1234", "1567", "-2", "computer science" };


string[] matrix2 = new string[matrix1.Length];
void NewMatrix(string[] matrix1, string[] matrix2)
{
    int count = 0;
    for (int i = 0; i < matrix1.Length; i++)
    {
        if (matrix1[i].Length <= 3)
        {
            matrix2[count] = matrix1[i];
            count++;
        }
    }
}

void PrintMatrix(string[] matrix)
{
    Console.Write("[ ");
    for (int i = 0; i < matrix.Length; i++)
    {
        if (i < matrix.Length - 3) Console.Write($"{matrix[i]}; ");
        else Console.Write(matrix[i]);
    }
    Console.Write(" ]");
    Console.WriteLine();
}

NewMatrix(matrix1, matrix2);
PrintMatrix(matrix2);