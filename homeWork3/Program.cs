
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int number = Convert.ToInt32(Console.ReadLine());

// void findWeekend (int number3){
//     if (number3 <= 7){
//         if (number3 > 5){
//             Console.WriteLine("да");
//         }
//         else {
//             Console.WriteLine("нет");
// }
// }

//     else{
//         Console.WriteLine("Введите число от 1 до 7");
// }
// }

// findWeekend(number);

bool findWeekend(int nums){
    if ((nums <= 7) == true){
       if ((nums > 5) == true){
           Console.WriteLine("да");
           return true;
       }
        else {
                Console.WriteLine("нет");
                return false; 
        }
       }
       
       else{
                Console.WriteLine("Введите число от 1 до 7");
                return false;
    }
}

findWeekend(number);