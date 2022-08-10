// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int number = Convert.ToInt32(Console.ReadLine());


void findsnumber (int number3){

    string str = number3.ToString();
    if (number3 > 100)
    {
      Console.WriteLine(str[2]);
    }
    else{
    Console.WriteLine("третьей цифры нет");
}
}

findsnumber(number);
