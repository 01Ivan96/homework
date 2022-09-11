// Задача №19
// /*
Console.Write("Введите пятизначное число по модулю: ");
int number = Convert.ToInt32(Console.ReadLine());
int absNumber = Math.Abs(number);

while ( absNumber < 10000 || absNumber > 99999 ) {
    Console.Write("Введите пятизначное число по модулю: ");
    number = Convert.ToInt32(Console.ReadLine());
    absNumber = Math.Abs(number);
}

int secondNumber = 0;
int remainderDivision;
while ( absNumber > 0 ) {
    remainderDivision = absNumber % 10;
    absNumber /= 10;
    secondNumber = secondNumber*10 + remainderDivision;
}

if ( Math.Abs(number) == secondNumber ) {
    Console.Write($"Число {number} палиндром!");
} else {
    Console.Write($"Число {number} не палиндром.");
}
// */


// Задача №21
/*
Console.Write("Первая точка по Ox: ");
int firstX = Convert.ToInt32(Console.ReadLine());
Console.Write("Первая точка по Oy: ");
int firstY = Convert.ToInt32(Console.ReadLine());
Console.Write("Первая точка по Oz: ");
int firstZ = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка по Ox: ");
int secondX = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка по Oy: ");
int secondY = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка по Oz: ");
int secondZ = Convert.ToInt32(Console.ReadLine());

double length = Math.Sqrt( Math.Pow((secondX - firstX), 2) + Math.Pow((secondY - firstY), 2) + Math.Pow((secondZ - firstZ), 2) );

Console.Write($"Длина между точкой ({firstX}; {firstY}; {firstZ}) и точкой ({secondX}; {secondY}; {secondZ}) равна {length}");
*/


// Задача №23
/*
Console.Write("Введите число больше нуля: ");
int number = Convert.ToInt32(Console.ReadLine());

while ( number<1 ) {
    Console.Write("Введите число больше нуля: ");
    number = Convert.ToInt32(Console.ReadLine());
}

for ( int i=1; i<=number; i++ ) {
    Console.Write( Math.Pow(i, 3) + " " );
}
*/