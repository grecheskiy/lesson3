//Определить, присутствует ли в заданном массиве, некоторое число
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Console.WriteLine("Enter find number: ");
int x = int.Parse(Console.ReadLine() ?? "0");
for (int i = 0; i < array.Length; i++)
   {  if (array[i] == x) 
          {Console.WriteLine("Yes");
          break;}
       else {Console.WriteLine("No");}   
   }  