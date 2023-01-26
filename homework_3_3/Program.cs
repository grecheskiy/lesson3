//Возведите число А в натуральную степень B используя цикл
int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};
int n = array.Length;
int i = 0;
while (i < n)
{double result = Math.Pow(array[i],array[i]);
{Console.WriteLine(result);}
i++;}