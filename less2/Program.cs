
void newmetod(){
int randomValue = new Random().Next(100, 1000);

Console.WriteLine(randomValue);

int number1 = randomValue / 100;
int number3 = randomValue % 10;

Console.WriteLine(number1);
Console.WriteLine("первое число");
Console.WriteLine(number3);
Console.WriteLine("третье число");

int newNumber = number1 * 10 + number3;
Console.WriteLine(newNumber);
}

newmetod();
newmetod();