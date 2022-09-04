// Задача №1
// /*
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber) {
    Console.WriteLine($"Минимум: {secondNumber}");
    Console.WriteLine($"Максимум: {firstNumber}");
} else if (firstNumber < secondNumber) {
    Console.WriteLine($"Минимум: {firstNumber}");
    Console.WriteLine($"Максимум: {secondNumber}");
} else {
    Console.WriteLine("Оба числа равны");
}
// */


// Задача №2
/*
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int max;

if ( firstNumber < secondNumber ) {
    max = secondNumber;
} else {
    max = firstNumber;
}
if ( max < thirdNumber ) {
    max = thirdNumber;
}
Console.WriteLine($"Максимум: {max}");
*/


// Задача №3
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if ( number % 2 == 0 ) {
    Console.WriteLine("Число чётное!");
} else {
    Console.WriteLine("Число нечётное!");
}
*/


// Задача №4
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ( number > 1 ) {
    for ( int i = 2; i <= number; i += 2) {
        Console.Write($"{i} ");
    }
} else { Console.Write("Таких чисел нет!"); }
*/