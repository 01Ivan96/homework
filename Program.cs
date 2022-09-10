// Задача №10
// /*
Console.Write("Введите трёхзначное число по модулю: ");
int number = Convert.ToInt32(Console.ReadLine());
int absNumber = Math.Abs(number);
string stringNumber = Convert.ToString(absNumber);

while ( stringNumber.Length != 3 ) {
    Console.Write("Введите трёхзначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
    absNumber = Math.Abs(number);
    stringNumber = Convert.ToString(absNumber);
}

Console.Write($"Вторая цифра числа '{number}' равна: {stringNumber[1]}");
// */


// Задача №13
/*
Console.Write("Введите число по модулю больше 99: ");
int number = Convert.ToInt32(Console.ReadLine());
int absNumber = Math.Abs(number);
string stringNumber = Convert.ToString(absNumber);

while (stringNumber.Length < 3) {
    Console.Write("Третьей цифры нет! Введите число по модулю больше 99: ");
    number = Convert.ToInt32(Console.ReadLine());
    absNumber = Math.Abs(number);
    stringNumber = Convert.ToString(absNumber);
}

Console.Write($"Третья цифра числа '{number}' равна: {stringNumber[2]}");
*/


// Задача №13 (математический метод)
/*
Console.Write("Введите число по модулю больше 99: ");
int number = Convert.ToInt32(Console.ReadLine());

while (Math.Abs(number) < 100) {
    Console.Write("Третьей цифры нет! Введите число по модулю больше 99: ");
    number = Convert.ToInt32(Console.ReadLine());
}

int firstThreeDigitsNumber = Math.Abs(number);
while (firstThreeDigitsNumber > 999) {
    firstThreeDigitsNumber = firstThreeDigitsNumber / 10;
}

int thirdDigitNumber = firstThreeDigitsNumber % 10;
Console.Write($"Третья цифра числа '{number}' равна: {thirdDigitNumber}");
*/


// Задача №15
/*
Console.Write("Введите день недели (числом): ");
int day = Convert.ToInt32(Console.ReadLine());
while ( day<1 || day>7 ) {
    Console.Write("Введите день недели (числом): ");
    day = Convert.ToInt32(Console.ReadLine());
}

if ( day==6 || day==7 ) {
    Console.WriteLine("Выходной!");
} else {
    Console.WriteLine("Будний день(");
}
*/


// Задача - "Электричка"
/*
Console.Write("Номер вагона от 'головы' электрички (от 1 до 1000): ");
int numberFromHead = Convert.ToInt32(Console.ReadLine());
Console.Write("Номер вагона от 'хвоста' электрички (от 1 до 1000): ");
int numberFromTail = Convert.ToInt32(Console.ReadLine());

while ( numberFromHead<1 || numberFromHead>1000 || numberFromTail<1 || numberFromTail>1000 ) {
    Console.WriteLine("Некорректные номера вагонов!");
    Console.Write("Номер вагона от 'головы' электрички (от 1 до 1000): ");
    numberFromHead = Convert.ToInt32(Console.ReadLine());
    Console.Write("Номер вагона от 'хвоста' электрички (от 1 до 1000): ");
    numberFromTail = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Номер вагона от 'головы' и от 'хвоста' электрички соответственно: {numberFromHead}, {numberFromTail}");

int numberOfWagons = numberFromHead + numberFromTail - 1;
Console.WriteLine($"Количество вагонов электрички: {numberOfWagons}");
*/


// Задача - "Мороженое"
/*
Console.Write("Введите количество шариков мороженого, которое планируете брать: ");
int numberScoops = Convert.ToInt32(Console.ReadLine());

int i=0;
int n=0;
int selectionNumberScoops;
int result = 0;
while ( i<=(numberScoops/3) ) {
    n=0;
    while ( n<=(numberScoops/5) ) {
        selectionNumberScoops = i*3 + n*5;
        if ( selectionNumberScoops <= numberScoops ) {
            if (selectionNumberScoops == numberScoops ) {
                result = 1;
            }
        } else {
            break;
        }
        if (result == 1) {
            break;
        }
        n++;
    }
    if (result == 1) {
        break;
    }
    i++;
}

if (result == 1) {
    Console.Write($"Есть возможность купить {numberScoops} шариков, если взять {i} по 3 шарика и {n} по 5 шариков!");
} else {
    Console.Write($"Нет возможности купить {numberScoops} шариков(");
}
*/


// Задача - "Лесенка"
/*
Console.Write("Введите натуральное число, но меньше 10: ");
int number = Convert.ToInt32(Console.ReadLine());

while ( number < 1 || number > 9) {
    Console.Write("Введите натуральное число, но меньше 10: ");
    number = Convert.ToInt32(Console.ReadLine());
}

for ( int i=1; i<=number; i++ ) {
    for ( int n=1; n<=i; n++ ) {
        Console.Write($"{n} ");
    }
    Console.WriteLine("");
}
*/