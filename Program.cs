// Задача №41
// /*
Console.Write("Количество вводимых чисел: ");
int number = Convert.ToInt32(Console.ReadLine());

while ( number<=0 ) {
    Console.Write("Количество вводимых чисел должно быть больше нуля: ");
    number = Convert.ToInt32(Console.ReadLine());
}

int count = 0;
string allNumber = string.Empty;
for ( int i=0; i<number; i++ ) {
    Console.Write("Введите число: ");
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    if ( inputNumber > 0 ) {
        count++;
    }
    allNumber += inputNumber + " ";
}
Console.WriteLine($"Количество положительных чисел из ряда ( {allNumber}) равно: {count}");
// */



// Задача №43
/*
Console.Write("Первый угловой коэффициент: k1=");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Первый коэффициент смещения по Oy: b1=");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Второй угловой коэффициент: k2=");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Второй коэффициент смещения по Oy: b2=");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = ( b2-b1 ) / ( k1-k2 );
double y = k1 * x + b1;

Console.WriteLine($"Для функций y={k1}*x+{b1} и y={k2}*x+{b2} точкой пересечения будет ({x}, {y})");
*/



// Транспонирование
/*
Console.Write("Количество строк и столбцов в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());

while ( number < 1 ) {
    Console.Write("Количество строк и столбцов должно быть больше нуля: ");
    number = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("");
Console.WriteLine("Первый массив");
Console.WriteLine("");

int[,] array = new int[number, number];
for ( int i=0; i<array.GetLength(0); i++ ) {
    for ( int k=0; k<array.GetLength(1); k++ ) {
        array[i, k] = new Random().Next(-100, 101);
        Console.Write($"{array[i, k]}       ");
    }
    Console.WriteLine("");
}

Console.WriteLine("");
Console.WriteLine("Второй массив");
Console.WriteLine("");

int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
for ( int m=0; m<newArray.GetLength(0); m++ ) {
    for ( int n=0; n<newArray.GetLength(1); n++ ) {
        newArray[m, n] = array[array.GetLength(1)-1-n, array.GetLength(0)-1-m];
        Console.Write($"{newArray[m, n]}        ");
    }
    Console.WriteLine("");
}
*/