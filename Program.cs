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

    int[,] matrix = new int[rows, columns];
    InputMatrix(matrix, minValue, maxValue);
    return matrix;
}

void InputMatrix(int[,] matrix, int minValue, int maxValue ) {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(minValue, maxValue+1);
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


// Задача №54
// /*
int[,] matrix = CreationMatrix();
Console.WriteLine("Первый массив:");
PrintMatrix(matrix);

for ( int i=0; i<matrix.GetLength(0); i++ ) {
    for ( int j=0; j<matrix.GetLength(1)-1; j++ ) {
        for (int k=j+1; k<matrix.GetLength(1); k++ ) {
            if ( matrix[i, j] < matrix[i, k] ) {
                int fixValue = matrix[i, k];
                matrix[i, k] = matrix[i, j];
                matrix[i, j] = fixValue;
            }
        }
    }
}

Console.WriteLine("Второй массив:");
PrintMatrix(matrix);
// */



// Задача №56
/*
int[,] matrix = CreationMatrix();
PrintMatrix(matrix);

int[] sumEachRow = new int[matrix.GetLength(0)];
for ( int i=0; i<matrix.GetLength(0); i++ ) {
    int sumRow = 0;
    for ( int j=0; j<matrix.GetLength(1); j++ ) {
        sumRow += matrix[i, j];
    }
    sumEachRow[i] = sumRow;
}
Console.WriteLine();
Console.WriteLine($"Сумма каждой строки по отдельности: [{string.Join(", ", sumEachRow)}]");
Console.WriteLine();

int[] indexRowsWithMinSum = new int[sumEachRow.Length];
indexRowsWithMinSum[0] = 0;
int count = 0;
for ( int i=1; i<sumEachRow.Length; i++ ) {
    if ( sumEachRow[i] < sumEachRow[ indexRowsWithMinSum[0] ] ) {
            indexRowsWithMinSum = new int[sumEachRow.Length-i];
            indexRowsWithMinSum[0] = i;
            count = 0;
    } else if ( sumEachRow[i] == sumEachRow[ indexRowsWithMinSum[0] ] ) {
        count++;
        indexRowsWithMinSum[count] = i;
    }
}

int[] numbersRowsWithMinSum = new int[count+1];
for ( int i=0; i<numbersRowsWithMinSum.Length; i++ ) {
    numbersRowsWithMinSum[i] = indexRowsWithMinSum[i] + 1;
}
Console.WriteLine($"Строки с номерами ({string.Join(", ", numbersRowsWithMinSum)}) имеют min сумму: {sumEachRow[ indexRowsWithMinSum[0] ]}");
*/



// Задача №58
/*
int[,] firstMatrix = CreationMatrix();

int[,] secondMatrix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];

Console.WriteLine();
Console.WriteLine("Заполним второй массив!");
Console.Write("Минимальное возможное значение в массиве: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальное возможное значение в массиве: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
while ( minValue > maxValue ) {
    Console.Write($"Максимальное значение в массиве должно быть не меньше минимального ({minValue}): ");
    maxValue = Convert.ToInt32(Console.ReadLine());
}
InputMatrix(secondMatrix, minValue, maxValue);

Console.WriteLine();
Console.WriteLine("Первый массив:");
PrintMatrix(firstMatrix);

Console.WriteLine();
Console.WriteLine("Второй массив:");
PrintMatrix(secondMatrix);

int[,] productTwoMatrices = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
for ( int i=0; i<productTwoMatrices.GetLength(0); i++ ) {
    for ( int j=0; j<productTwoMatrices.GetLength(1); j++ ) {
        productTwoMatrices[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
    }
}

Console.WriteLine();
Console.WriteLine("Произведение двух массивов:");
PrintMatrix(productTwoMatrices);
*/



// Задача №60
/*
int[] matrixValue = new int[90];
for ( int i=10; i<100; i++ ) {
    matrixValue[i-10] = i;
}

int[] ValueDimension() {
    Console.Write("Первое измерение массива: ");
    int firstDimension = Convert.ToInt32(Console.ReadLine());
    while ( firstDimension<1 ) {
        Console.WriteLine("Измерение массива должно быть больше нуля!");
        Console.Write("Первое измерение массива: ");
        firstDimension = Convert.ToInt32(Console.ReadLine());        
    }
    Console.Write("Второе измерение массива: ");
    int secondDimension = Convert.ToInt32(Console.ReadLine());
    while ( secondDimension<1 ) {
        Console.WriteLine("Измерение массива должно быть больше нуля!");
        Console.Write("Второе измерение массива: ");
        secondDimension = Convert.ToInt32(Console.ReadLine());      
    }
    Console.Write("Третье измерение массива: ");
    int thirdDimension = Convert.ToInt32(Console.ReadLine());
    while ( thirdDimension<1 ) {
        Console.WriteLine("Измерение массива должно быть больше нуля!");
        Console.Write("Третье измерение массива: ");
        thirdDimension = Convert.ToInt32(Console.ReadLine());   
    }
    int[] allDimension = new int[3]{firstDimension, secondDimension, thirdDimension};
    return allDimension;
}

int[] allDimesion = ValueDimension();
while ( allDimesion[0]*allDimesion[1]*allDimesion[2] > 90 ) {
    System.Console.WriteLine($"Количество элементов не может быть больше 90, соответственно произведение трёх измерений ({string.Join(", ", allDimesion)}) тоже!");
    allDimesion = ValueDimension();
}
Console.WriteLine();

int[] RemoveElement(int[] array, int index) {
    int[] newArray = new int[array.Length-1];
    bool condition = true;
    for ( int i=0; i<newArray.Length; i++ ) {
        if ( condition == true ) {
            if ( i != index ) {
                newArray[i] = array[i];
            } else {
                condition = false;
            }
        }
        if ( condition == false ) {
            newArray[i] = array[i+1];
        }
    }
    return newArray;
}

int[,,] matrix = new int[allDimesion[0], allDimesion[1], allDimesion[2]];
for ( int i=0; i<matrix.GetLength(0); i++ ) {
    for ( int j=0; j<matrix.GetLength(1); j++ ) {
        for ( int k=0; k<matrix.GetLength(2); k++ ) {
            int randomIndexElement = new Random().Next(0, matrixValue.Length);
            matrix[i, j, k] = matrixValue[randomIndexElement];
            matrixValue = RemoveElement(matrixValue, randomIndexElement);
        }
    }
}

Console.WriteLine("Вывод значений трёхмерного массива:");
for ( int i=0; i<matrix.GetLength(0); i++ ) {
    for ( int j=0; j<matrix.GetLength(1); j++ ) {
        for ( int k=0; k<matrix.GetLength(2); k++ ) {
            Console.WriteLine($"({i}, {j}, {k}): {matrix[i, j, k]}");
        }
    }
}
*/



// Задача №61
/*
Console.Clear();

int[] NewRowTrianglePascal(int[] array) {
    int[] newArray = new int[array.Length+1];
    newArray[0] = 1;
    for ( int i=0; i<array.Length-1; i++ ) {
        newArray[i+1] = array[i] + array[i+1];
    }
    newArray[newArray.Length-1] = 1;
    return newArray;
}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] rowsTrianglePascal = new int[0];
for ( int i=0; i<=number; i++ ) {
    rowsTrianglePascal = NewRowTrianglePascal(rowsTrianglePascal);
    if ( rowsTrianglePascal.Length%2 == 1 ) {
        string stringRowTrianglePascal = Convert.ToString(rowsTrianglePascal[rowsTrianglePascal.Length/2]);
        for ( int j=rowsTrianglePascal.Length/2-1; j>=0; j-- ) {
            stringRowTrianglePascal = Convert.ToString(rowsTrianglePascal[j]) + "       " + stringRowTrianglePascal + "       " + Convert.ToString(rowsTrianglePascal[j]);
        }
        Console.SetCursorPosition((Console.WindowWidth - stringRowTrianglePascal.Length)/2, i+2);
        Console.WriteLine(stringRowTrianglePascal);
    } else {
        string stringRowTrianglePascal = Convert.ToString(rowsTrianglePascal[rowsTrianglePascal.Length/2-1]) + "       " + Convert.ToString(rowsTrianglePascal[rowsTrianglePascal.Length/2-1]);
        for ( int j=rowsTrianglePascal.Length/2-2; j>=0; j-- ) {
            stringRowTrianglePascal = Convert.ToString(rowsTrianglePascal[j]) + "       " + stringRowTrianglePascal + "       " + Convert.ToString(rowsTrianglePascal[j]);
        }
        Console.SetCursorPosition((Console.WindowWidth - stringRowTrianglePascal.Length)/2, i+2);
        Console.WriteLine(stringRowTrianglePascal);
    }
}
*/



// Задача №62
/*
int[,] matrix = new int[8, 6];

int i = 0;
int j = 0;
matrix[i, j] = 1;
while ( matrix[i, j+1] == 0 ) {
    while ( j<matrix.GetLength(1)-1 && matrix[i, j+1]==0 ) {
        j++;
        matrix[i, j] = matrix[i, j-1] + 1;
    }
    while ( i<matrix.GetLength(0)-1 && matrix[i+1, j]==0 ) {
        i++;
        matrix[i, j] = matrix[i-1, j] + 1;
    }
    while ( j>0 && matrix[i, j-1]==0 ) {
        j--;
        matrix[i, j] = matrix[i, j+1] + 1;
    }
    while ( matrix[i-1, j]==0 ) {
        i--;
        matrix[i, j] = matrix[i+1, j] + 1;
    }
}

for ( int k=0; k<matrix.GetLength(0); k++ ) {
    for ( int l=0; l<matrix.GetLength(1); l++ ) {
        Console.Write($"{matrix[k, l]}\t");
    }
    Console.WriteLine();
}
*/