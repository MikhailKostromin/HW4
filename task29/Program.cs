//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int N =8;
int[]array = new int[N];
for (int i = 0; i < array.Length; i++)     // создал массив
{
    array[i] = new Random().Next();
}
Console.Write("[");                     //Красиво выводим массив
for (int i = 0; i < N - 1; ++i)
{
    Console.Write(array[i] + ", ");
}
Console.WriteLine(array[N - 1] + "]");

            
            

