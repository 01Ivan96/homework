// Задача №66
// /*
Console.Write("Введите натуральное число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
while ( firstNumber<1 ) {
    Console.Write("Число должно быть больше нуля: ");
    firstNumber = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Введите второе натуральное число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
while ( secondNumber<firstNumber ) {
    Console.Write($"Число должно быть больше первого числа ({firstNumber}): ");
    secondNumber = Convert.ToInt32(Console.ReadLine());
}

int SumNumbers( int firstNumber, int lastNumber ) {
    if ( lastNumber >= firstNumber ) {
        return lastNumber + SumNumbers(firstNumber, --lastNumber);
    } else return 0;
}

int sumAllNumbers = SumNumbers(firstNumber, secondNumber);
Console.WriteLine($"Сумма всех чисел от {firstNumber} до {secondNumber} равна: {sumAllNumbers}");
// */




// Задача №68
/*
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int FunctionAckermann( int firstNumber, int secondNumber ) {
    
    if ( firstNumber == 0 ) {
        return secondNumber+1;
    }
    if ( firstNumber > 0 && secondNumber == 0 ) {
        return FunctionAckermann( firstNumber-1, secondNumber+1 );
    } else return FunctionAckermann( firstNumber-1, FunctionAckermann( firstNumber, secondNumber-1 ) );
}


int functionAckermann = FunctionAckermann( firstNumber, secondNumber );
Console.WriteLine($"{functionAckermann}");
*/