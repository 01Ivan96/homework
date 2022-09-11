// Задача №25
// /*
Console.Write("Первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

while ( secondNumber < 1) {
    Console.Write("Введите натуральное число: ");
    secondNumber = Convert.ToInt32(Console.ReadLine());
}

double exponentiation = 1;
for ( int i=1; i<=secondNumber; i++ ) {
    exponentiation *= firstNumber;
}

Console.Write($"Число {firstNumber} в степени {secondNumber} равно {exponentiation}");
// */



// Задача №27
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int absNumber = Math.Abs(number);

int sumDigits = 0;
while ( absNumber > 0 ) {
    sumDigits += absNumber % 10;
    absNumber /= 10;
}

Console.Write($"Сумма цифр числа {number} равна {sumDigits}.");
*/



// Задача №29
/*
int[] array = new int[8];
for ( int i=0; i<array.Length; i++ ) {
    Console.Write($"Введите число №{i+1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write($"[{string.Join(", ", array)}]");
*/



// Задача - "Черника"
/*
Console.Write("Введите количество кустов (от 3 до 1000): ");
int numberBushes = Convert.ToInt32(Console.ReadLine());

int[] bushes = new int[numberBushes];
for ( int i=0; i<numberBushes; i++ ) {
    bushes[i] = new Random().Next(3, 1001);
}
Console.WriteLine(string.Join(", ", bushes));

int maxNumberBerries = 0;
int indexBushes = 0;

for ( int n=1; n<numberBushes-1; n++ ) {
    int numberBerries = bushes[n-1] + bushes[n] + bushes[n+1];
    if ( numberBerries > maxNumberBerries ) {
        maxNumberBerries = numberBerries;
        indexBushes = n+1;
    }
}

int numberBerriesFirstIndex = bushes[numberBushes-1] + bushes[0] + bushes[1];
int numberBerriesLastIndex = bushes[numberBushes-2] + bushes[numberBushes-1] + bushes[0];

if ( numberBerriesFirstIndex > maxNumberBerries ) {
    maxNumberBerries = numberBerriesFirstIndex;
    indexBushes = 1;
}
if ( numberBerriesLastIndex > maxNumberBerries ) {
    maxNumberBerries = numberBerriesLastIndex;
    indexBushes = numberBushes;
}

Console.Write($"Перед кустом №{indexBushes} модуль соберёт больше всего ягод, а именно {maxNumberBerries}!");
*/