//Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] arr = new int[10];
int l = arr.Length;
Random rnd = new Random();
for (int i=0; i<l; i++)
{arr[i] = rnd.Next(1,10);
Console.Write($"{arr[i]} ");}
Console.WriteLine();   
int result = 0;
for (int j=0; j<l / 2; j++)
{result += arr[j] * arr[arr.Length - 1 - j];
Console.WriteLine(result);}