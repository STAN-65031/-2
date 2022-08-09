
void findMultiple(){
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if ((number1 % number2) == 0 ){
    Console.WriteLine ("да");
}
else {
     int newNumber = number1 % number2;
     Console.WriteLine (newNumber);
    Console.WriteLine ("нет");
}
}

findMultiple();
findMultiple();
