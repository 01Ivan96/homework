int[,] CreationMatrix() {
    Console.Write("Количество строк массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    while ( rows < 1 ) {
        Console.Write("Количество строк должно быть больше нуля: ");
        rows = Convert.ToInt32(Console.ReadLine());
    }

    Console.Write("Количество столбцов массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    while ( columns < 1 ) {
        Console.Write("Количество столбцов должно быть больше нуля: ");
        columns = Convert.ToInt32(Console.ReadLine());
    }

    Console.Write("Минимальное возможное значение в массиве: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Максимальное возможное значение в массиве: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    while ( minValue > maxValue ) {
        Console.Write($"Максимальное значение в массиве должно быть не меньше минимального ({minValue}): ");
        maxValue = Convert.ToInt32(Console.ReadLine());
    }

    int[,] array = new int[rows, columns];
    InputMatrix(array, minValue, maxValue+1);
    return array;
}

void InputMatrix(int[,] matrix, int minValue, int maxValue ) {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(minValue, maxValue);
    }
}


void PrintMatrix(int[,] matrix) {
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");
        Console.WriteLine();
    }
}


// Задача №47
// /*
Console.Write("Количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
while ( rows < 1 ) {
    Console.Write("Количество строк должно быть больше нуля: ");
    rows = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
while ( columns < 1 ) {
    Console.Write("Количество столбцов должно быть больше нуля: ");
    columns = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Минимальное возможное значение в массиве: ");
double minValue = Convert.ToDouble(Console.ReadLine());
Console.Write("Максимальное возможное значение в массиве: ");
double maxValue = Convert.ToDouble(Console.ReadLine());
while ( minValue > maxValue ) {
    Console.Write($"Максимальное значение в массиве должно быть не меньше минимального ({minValue}): ");
    maxValue = Convert.ToDouble(Console.ReadLine());
}

double[,] array = new double[rows, columns];
for (int i = 0; i < array.GetLength(0); i++ ) {
    for (int j = 0; j < array.GetLength(1); j++ ) {
        array[i, j] = minValue + new Random().NextDouble() * ( Math.Abs(minValue) + maxValue );
        Console.Write($"{array[i, j]}\t");
    }
    Console.WriteLine();
}
// */



// Задача №50
/*
int[,] array = CreationMatrix();
PrintMatrix(array);

Console.Write("Номер строки элемента в массиве: ");
int numberRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Номер столбца элемента в массиве: ");
int numberColumn = Convert.ToInt32(Console.ReadLine());

if ( numberRow > array.GetLength(0) || numberColumn > array.GetLength(1) ) {
    Console.Write($"Элемента с индексом ({numberRow-1}; {numberColumn-1}) не существует!");
} else {
    Console.Write($"Элемент с индексом ({numberRow-1}; {numberColumn-1}) равен: {array[numberRow-1, numberColumn-1]}");
}
*/



// Задача №52
/*
int[,] array = CreationMatrix();
PrintMatrix(array);

for ( int i=0; i<array.GetLength(1); i++ ) {
    int sum = 0;
    for (int j = 0; j < array.GetLength(0); j++) {
        sum += array[j, i];
    }
    double arithmeticalMean = sum * Math.Pow(array.GetLength(0), -1);
    Console.WriteLine($"Среднее арифметическое {i+1} столбца: {arithmeticalMean}");
}
*/



// Задача - "Симпатичный узор"
/*
char[,] array = new char[4, 4];
char[] colorTile = new char[]{'B', 'W'};

for (int i=0; i<array.GetLength(0); i++ ) {
    for (int j=0; j<array.GetLength(1); j++ ) {
        array[i, j] = colorTile[new Random().Next(colorTile.Length)];
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

bool beautiful = true;
for (int i = 0; i<array.GetLength(0)-1; i++) {
    for (int j = 0; j<array.GetLength(1)-1; j++) {
        if ( array[i, j] == array[i, j+1] && array[i+1, j] == array[i+1, j+1] && array[i, j] == array[i+1, j+1] ) {
            beautiful = false;
            break;
        }
    }
    if ( beautiful == false ) {
        break;
    }
}

Console.WriteLine();
if ( beautiful == true ) {
    Console.WriteLine("Узор красивый)");
} else {
    Console.WriteLine("Узор некрасивый(");
}
*/