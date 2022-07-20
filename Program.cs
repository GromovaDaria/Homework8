//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*int[,] GetTwoDimesionalArray(int rows, int columns) {
    Random rnd = new Random();
    int[,] arr = new int[rows, columns];

    for (var i = 0; i < rows; i++) {
        for (var i2 = 0; i2 < columns; i2++) {
            arr[i, i2] = rnd.Next(1, 10);
        }
    }

    return arr;
}

int[,] Sort2DArray(int[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        // loop for column of matrix
        for (int j = 0; j < m.GetLength(1); j++) 
        {
            // loop for comparison and swapping
            for (int k = 0; k < m.GetLength(1) - j - 1; k++) 
            {
                if (m[i, k] > m[i, k + 1]) 
                {
                    // swapping of elements
                    int t = m[i, k];
                    m[i, k] = m[i, k + 1];
                    m[i, k + 1] = t;
                }
            }
        }
    }

    return m;
}

Console.WriteLine("Write number of rows and columns to specify two dimensional array.");

Console.Write("Rows: ");
var inputRows = Console.ReadLine();

Console.Write("Columns: ");
var inputColumns = Console.ReadLine();

if (Int32.TryParse(inputRows, out int parsedInputRows) && Int32.TryParse(inputColumns, out int parsedInputColumns)) {
    if (parsedInputRows <= 0 || parsedInputColumns <= 0) {
        Console.WriteLine("Error: Row and column has to be positive numbers");
        return;
    }

    var array = GetTwoDimesionalArray(parsedInputRows, parsedInputColumns);
    for (var i = 0; i < parsedInputRows; i++) {
        for (var i2 = 0; i2 < parsedInputColumns; i2++) {
            Console.Write($"{array[i, i2]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();

    var sortedArray = Sort2DArray(array);
    for (var i = 0; i < parsedInputRows; i++) {
        for (var i2 = 0; i2 < parsedInputColumns; i2++) {
            Console.Write($"{sortedArray[i, i2]} ");
        }
        Console.WriteLine();
    }
}

else Console.WriteLine("Error: Input not valid");
*/

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*int[,] GetTwoDimesionalArray(int rows, int columns) {
    Random rnd = new Random();
    int[,] arr = new int[rows, columns];

    for (var i = 0; i < rows; i++) {
        for (var j = 0; j < columns; j++) {
            arr[i, j] = rnd.Next(1, 10);
        }
    }

    return arr;
}

string RowWithSmallestSum(int[,] array) {
    var rowWithHighestSum = "1";
    var highestSum = 0;

    for(var i = 0; i < array.GetLength(0); i++) {
        var sum = 0;

        for (var j = 0; j < array.GetLength(1); j++) {
            sum += array[i, j];
        }

        if (sum > highestSum) {
            highestSum = sum;
            rowWithHighestSum = $"{i + 1}";
        }

        else if (sum == highestSum) {
            rowWithHighestSum += $" and {i + 1}";
        }
    }

    return rowWithHighestSum;
}

Console.WriteLine("Write number of rows and columns to specify two dimensional array.");

Console.Write("Rows: ");
var inputRows = Console.ReadLine();

Console.Write("Columns: ");
var inputColumns = Console.ReadLine();

if (Int32.TryParse(inputRows, out int parsedInputRows) && Int32.TryParse(inputColumns, out int parsedInputColumns)) {
    if (parsedInputRows <= 0 || parsedInputColumns <= 0) {
        Console.WriteLine("Error: Row and column has to be positive numbers");
        return;
    }

    var array = GetTwoDimesionalArray(parsedInputRows, parsedInputColumns);
    for (var i = 0; i < parsedInputRows; i++) {
        for (var i2 = 0; i2 < parsedInputColumns; i2++) {
            Console.Write($"{array[i, i2]} ");
        }
        Console.WriteLine();
    }

    var rowWithHighestSumValue = RowWithSmallestSum(array);
    Console.WriteLine($"The row with the highest sum is row {rowWithHighestSumValue}");
}

else Console.WriteLine("Error: Input not valid");
*/

//Заполните спирально массив 4 на 4.
/*void DrawSpiral() {
    int n = 4;
    int[,] a = new int[n, n];  
    int printValue = 1;  
    int x = 0, y = n - 1; 

    while (printValue <= n * n)
    {  
        for (int i = x; i <= y; i++) a[x, i] = printValue++;  
        for (int j = x + 1; j <= y; j++) a[j, y] = printValue++;
        for (int i = y - 1; i >= x; i--) a[y, i] = printValue++;  
        for (int j = y - 1; j >= x + 1; j--) a[j, x] = printValue++;  
        
        x++;  
        y--;  
    }  
    for (int i = 0; i < n; i++)  
    {  
        for (int j = 0; j < n; j++)  
        {  
            Console.Write($"{a[i, j]} ");  
        }  
        Console.WriteLine();  
    }
}
DrawSpiral();
*/