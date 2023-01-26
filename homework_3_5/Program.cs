//Написать программу вычисления произведения чисел от 1 до N
int [] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int n = array.Length;
int i = 0;
int p = 1;
while (i < n)
{p = p * array[i];
i++;}
Console.WriteLine(p);