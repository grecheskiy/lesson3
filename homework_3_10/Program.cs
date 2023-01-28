//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] arr1 = new int[123];
Random rnd = new Random();
int count1 = 0;
for (int i=0; i<arr1.Length; i++)
{arr1[i] = rnd.Next(1,123);
Console.Write($"{arr1[i]} ");}
Console.WriteLine();
for (int j=0; j<arr1.Length; j++)
{if (arr1[j] >= 10 && arr1[j] <= 99 ) 
 count1 = count1 + 1;
 }
Console.Write($"количество чисел из отрезка [10,99] : {count1}");
Console.WriteLine();