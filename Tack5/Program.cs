// Задача 62. Заполните спиральный массив 4 на 4.
// 1   2  3 4
// 12 13 14 5
// 11 16 15 6
// 10  9  8 7


void FillSubMatrix(int[,] m, int offest)
{
    for (int i = offest + 1; i < m.GetLength(1) - offest; i++)
        m[offest,i] = m[offest,i - 1] + 1;
    for (int i = offest + 1; i < m.GetLength(0) - offest; i++)
        m[i, m.GetLength(1) - offest - 1] = m[i - 1, m.GetLength(1) - offest - 1] + 1;
    for (int i = m.GetLength(1) - offest - 2; i >= offest; i--)
        m[m.GetLength(0) - offest - 1,i] = m[m.GetLength(0) - offest - 1, i + 1] + 1;
        for (int i = m.GetLength(0) - offest - 2; i > offest; i--)
            m[i, offest] = m[i + 1, offest] + 1;
        
        if (m[offest + 1, offest + 1] == 0)
        {
            m[offest + 1, offest +1] =  m[offest + 1, offest] + 1;
            FillSubMatrix(m, offest + 1);
        }
}


int[,] CrateMatrix()
{
    Console.Write("Введите размер стороны матрицы:");
    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int[size[0], size[0]];
    matrix[0,0] = 1;
    FillSubMatrix(matrix, 0);
    return matrix;
}

void PritntMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j] :d2} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
int [,] matrix = CrateMatrix();
PritntMatrix(matrix);



