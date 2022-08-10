
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int number = Convert.ToInt32(Console.ReadLine());


void findsnumber (int number3){
    if (number3 <= 7){
        if (number3 > 5){
            Console.WriteLine("да");
        }
        else {
            Console.WriteLine("нет");
}
}

    else{
        Console.WriteLine("Введите число от 1 до 7");
}
}

findsnumber(number);