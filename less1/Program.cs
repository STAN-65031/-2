//int number = Convert.ToInt32(Console.ReadLine());

Random random = new Random();
int randomValue = random.Next(10,100);

Console.WriteLine(randomValue);

int lastnumber = randomValue % 10;
int firstnumber = randomValue / 10;

int max = lastnumber;

 if (lastnumber == firstnumber){
    Console.WriteLine("числа равны");
 }
 else{
    if (max < firstnumber){
        max = firstnumber;
    }
    Console.WriteLine(max);
    Console.WriteLine(" МАКСИМАЛЬНОЕ");
 }

Console.WriteLine(lastnumber);
Console.WriteLine(firstnumber);