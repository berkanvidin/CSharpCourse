// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


int number1 = -2147483648; // -2.147.483.648 ile +2.147.483.647 arasında değer alabilir. 32 bit
long number2 = 9223372036854775807;// -9223372036854775808 ile +9223372036854775807 arasında değer alır. 64 bit
short number3 = 32767; // -32768 ile 32767 arasında değer alır. 16 bit 
byte number4 = 255; // 0 ile 255 arasında değer alır. 8 bit
bool condition = true; // True yada False alabilir.
char character = 'A'; // tek karekter tutar.
double number5 = 10.4; // Ondalıklı değerler tutar
decimal number6 = 10.4m;
var number7 = 10;
//number7 = 'A';

Console.WriteLine("Number1 is {0}",number1);
Console.WriteLine("Number2 is {0}", number2);
Console.WriteLine("Number3 is {0}", number3);
Console.WriteLine("Number4 is {0}", number4);
Console.WriteLine("Number5 is {0}", number5);
Console.WriteLine("Number6 is {0}", number6);
Console.WriteLine("Number7 is {0}", number7);
Console.WriteLine("Character is {0}", character);
Console.WriteLine((int)Days.Monday);

enum Days
{
    Monday,
    Tuesday, Wednesday,
    Thursday, Friday,
    Saturday, Sunday
}