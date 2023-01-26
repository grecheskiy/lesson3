//Подсчитать сумму цифр в числе
Console.WriteLine("Enter three-digit number: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int x1 = n / 100;
int x2 = (n / 10) % 10;
int x3 = n % 10;
int s = x1 + x2 + x3;
if (n>=100)
Console.WriteLine(s);
else
Console.WriteLine(" False ");