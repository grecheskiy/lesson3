//Задать массив из 8 элементов 
//заполненных нулями и единицами 
//и вывести их на экран
int[] arr = new int[8];
Random rnd = new Random();
for (int i=0; i<arr.Length; i++)
{arr[i] = rnd.Next(0,2);
Console.Write($"{arr[i]} ");}
Console.WriteLine();