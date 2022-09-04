// Написать программу, которая сортирует массив от большего к меньшему и находит медианное значение. 
//Массив заполняется случайными целыми числами от 1 до 100, а его размерность вводится с клавиатуры. 
//СМОТРИ В ЛЕКЦИЮ!!!!!!!!!!!!

Console.WriteLine("Введите размер массива");
int N =Convert.ToInt32(Console.ReadLine());
int[]array = new int[N];
for (int i = 0; i < array.Length; i++)     // создал массив
{
    array[i] = new Random().Next(1,101);         // в Next (можно указать из каких цифр)
}

void PrintArray (int[] array)
{
Console.Write("[");                     //Красиво печатаем массив
for (int i = 0; i < N - 1; ++i)
{
    Console.Write(array[i] + ", ");
}
Console.WriteLine(array[N - 1] + "]");
}
PrintArray(array);

void SelectionSort(int[] array)        // Сортировка массива от большего к меньшему
{
 for (int i = 0; i < array.Length - 1; i++)
 {
 int maxPosition = i;
 for (int j = i + 1; j < array.Length; j++)
 {
 if (array[j] > array[maxPosition])
 {
 maxPosition = j;
 }
 }
 int temporary = array[i];
 array[i] = array[maxPosition];
 array[maxPosition] = temporary;
 }

}
void FindMedian (int[]array)  // Поиск медианого значения
{
    double result=0.0;
    if (array.Length % 2==0)
    {
        int indLeft = array.Length/2-1;
        int indRight = array.Length/2;
        result=Convert.ToDouble((array[indLeft]+array[indRight]))/2;
    }
    else result=array[array.Length/2];

    Console.WriteLine($"медианное значение = {result}");
}

SelectionSort(array);
PrintArray(array);
FindMedian (array);



