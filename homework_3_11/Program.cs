//Найти сумму чисел одномерного массива стоящих на нечетной позиции
int[] arr = new int[10];
Random rnd = new Random();
int sum = 0;
for (int i=0; i<arr.Length; i++)
{arr[i] = rnd.Next(1,10);
Console.Write($"{arr[i]} ");}
Console.WriteLine();
for (int j=0; j<arr.Length - 1; j+=2)
{sum = sum + arr[j];}
Console.WriteLine($"Сумма чисел на нечетных позициях : {sum}");