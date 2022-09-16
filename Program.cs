int[] InputArray ( int smallestNumber, int largestNumber ) {
    Console.Write("Количество элементов в массиве: ");
    int amountElements = Convert.ToInt32(Console.ReadLine());

    while ( amountElements < 1 ) {
        Console.Write("Количество элементов должно быть больше нуля: ");
        amountElements = Convert.ToInt32(Console.ReadLine());
    }

    int[] array = new int[amountElements];

    for ( int i=0; i<amountElements; i++ ) {
        array[i] = new Random().Next(smallestNumber, largestNumber+1);
    }

    return array;
}


// Задача №34
// /*
int smallestNumber = 100;
int largestNumber = 999;

int[] array = InputArray ( smallestNumber, largestNumber );
Console.WriteLine($"[{string.Join(", ", array)}]");

int amountEven = 0;
for ( int i=0; i<array.Length; i++ ) {
    if ( array[i] % 2 == 0 ) {
        amountEven++;
    }
}
Console.WriteLine($"Количество чётных чисел в массиве: {amountEven}");
// */



// Задача №36
/*
Console.Write("Самое маленькое возможное число в массиве: ");
int smallestNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Самое большое возможное число в массиве: ");
int largestNumber = Convert.ToInt32(Console.ReadLine());

while ( smallestNumber >= largestNumber ) {
    Console.WriteLine("Первое вводное число должно быть меньше второго!");
    Console.Write("Самое маленькое возможное число в массиве: ");
    smallestNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Самое большое возможное число в массиве: ");
    largestNumber = Convert.ToInt32(Console.ReadLine());
}

int[] array = InputArray ( smallestNumber, largestNumber );
Console.WriteLine($"[{string.Join(", ", array)}]");

int sumNumbersOnOddIndex = 0;
for ( int i=1; i<array.Length; i += 2 ) {
    sumNumbersOnOddIndex += array[i];
}
Console.WriteLine($"Сумма чисел расположенных в массиве на нечётном индексе равна: {sumNumbersOnOddIndex}");
*/



// Задача №38
/*
Console.Write("Количество элементов в массиве: ");
int amountElements = Convert.ToInt32(Console.ReadLine());

while ( amountElements < 1 ) {
    Console.Write("Количество элементов должно быть больше нуля: ");
    amountElements = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Самое маленькое возможное число в массиве: ");
double smallestNumber = Convert.ToDouble(Console.ReadLine());
Console.Write("Самое большое возможное число в массиве: ");
double largestNumber = Convert.ToDouble(Console.ReadLine());

while ( smallestNumber >= largestNumber ) {
    Console.WriteLine("Первое вводное число должно быть меньше второго!");
    Console.Write("Самое маленькое возможное число в массиве: ");
    smallestNumber = Convert.ToDouble(Console.ReadLine());
    Console.Write("Самое большое возможное число в массиве: ");
    largestNumber = Convert.ToDouble(Console.ReadLine());
}

double[] array = new double[amountElements];
for ( int i=0; i<array.Length; i++ ) {
    array[i] = new Random().NextDouble() * (largestNumber - smallestNumber) + smallestNumber;
}
Console.WriteLine(string.Join(", ", array));

double minElement = array[0];
double maxElement = array[0];
for ( int k=1; k<array.Length; k++ ) {
    if ( array[k] < minElement ) {
        minElement = array[k];
    }
    if ( array[k] > maxElement ) {
        maxElement = array[k];
    }
}
Console.WriteLine($"Разница между max и min элементом массива равна: {maxElement - minElement}");
*/



// Задача - "Двойной переворот"
/*
void ReverseArray(int[] array, int[] arrayIndex) {
    for ( int i=0; i<arrayIndex.Length/2; i++ ) {
        int start = arrayIndex[2*i];
        int end = arrayIndex[2*i+1];
        while ( end-start > 0 ) {
            int storage = array[start];
            array[start] = array[end];
            array[end] = storage;
            start++;
            end--;
        }
        Console.WriteLine($"{i+1} переворот: [{string.Join(", ", array)}]");
    }
}

Console.Write("Количество элементов в массиве (не больше 1000): ");
int amountElements = Convert.ToInt32(Console.ReadLine());

while ( amountElements < 1 || amountElements > 1000 ) {
    Console.Write("Количество элементов в массиве должно быть больше нуля и не больше 1000: ");
    amountElements = Convert.ToInt32(Console.ReadLine());
}

int[] array = new int[amountElements];
for ( int i=0; i<amountElements; i++ ) {
    array[i] = i + 1;
}
Console.WriteLine($"[{string.Join(", ", array)}]");

Console.Write("Количество переворотов интервалов массива: ");
int amountCoups = Convert.ToInt32(Console.ReadLine());

while ( amountCoups < 1 ) {
    Console.Write("Количество переворотов интервалов массива должно быть больше нуля: ");
    amountCoups = Convert.ToInt32(Console.ReadLine());
}

int[] arrayIndex = new int[2*amountCoups];
for ( int n=0; n<amountCoups; n++ ) {
    Console.Write("Стартовый индекс: ");
    int indexA = Convert.ToInt32(Console.ReadLine());
    while ( indexA >= amountElements || indexA<0 ) {
        Console.WriteLine($"Стартовый индекс не должен быть меньше нуля и больше последнего индекса массива - \"{amountElements-1}\"!");
        Console.Write("Стартовый индекс: ");
        indexA = Convert.ToInt32(Console.ReadLine());
    }

    Console.Write("Крайний индекс: ");
    int indexB = Convert.ToInt32(Console.ReadLine());

    while ( indexB >= amountElements || indexA > indexB ) {
        Console.WriteLine($"Крайний индекс не должен быть меньше стартового \"{indexA}\" и больше последнего индекса массива - \"{amountElements-1}\"!");
        Console.Write("Крайний индекс: ");
        indexB = Convert.ToInt32(Console.ReadLine());
    }

    arrayIndex[2*n] = indexA;
    arrayIndex[2*n+1] = indexB;
}
Console.WriteLine($"[{string.Join(", ", arrayIndex)}]");

ReverseArray(array, arrayIndex);
*/