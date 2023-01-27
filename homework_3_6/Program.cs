//Показать кубы чисел, заканчивающихся на четную цифру
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int k = 0;
for (int i = 0; i < array.Length; i++)
     if ((array[i] % 2) == 0)
          {k = array[i] * array[i] * array[i];
           Console.WriteLine(k);}