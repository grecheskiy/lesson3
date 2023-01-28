//Задать массив, 
//заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел
int[] arr = new int[10];
Random rnd = new Random();
int count1 = 0; int count2 = 0;
for (int i=0; i<arr.Length; i++)
{arr[i] = rnd.Next(100,999);
Console.Write($"{arr[i]} ");}
Console.WriteLine();
for (int j=0; j<arr.Length; j++)
{if( arr[j] % 2 != 0 )
 count1 = count1 + 1;
 else count2 = count2 +1;}
 Console.Write($"number of odd numbers: {count1}");
 Console.WriteLine();
 Console.Write($"number of even numbers: {count2}");
 Console.WriteLine();