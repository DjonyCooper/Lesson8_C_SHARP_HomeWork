// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
/*
int[,] CreateRandom2dArray() // Создание массива и обработка ошибок ввода(отсутствие числа или задание отрицательного значения для rows и columns)
{
    try
    {
        Console.Write($"░ Отлично, теперь Вам необходимо задать размеры массива и то какими значениями его будем наполнять.\n");
        Console.Write("» Задайте кол-во строк массива: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("» Задайте кол-во колонок массива: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.Write("» Задайте минимальное число, от которого будем генерировать массив: ");  
        int minValue = Convert.ToInt32(Console.ReadLine());
        Console.Write("» Задайте максимальное число, до которого будем генерировать массив: ");
        int maxValue = Convert.ToInt32(Console.ReadLine());
        int[,] error = new int [0,0];
        int[,] newArray = new int [rows,columns];
        
        if(minValue > maxValue)
        {
            Console.Write($"Oh, sorry it is impossible to fulfill your request.\nSet by you min value: {minValue}, more than max value: {maxValue}.\nFix the error and try again.\n");
            return error;
        }
        else
        {
            for(int i = 0; i< rows;i++)
            {
                for(int j = 0; j < columns; j++ )
                {
                    newArray[i,j] = new Random().Next(minValue, maxValue + 1);           
                }
            } 
            return newArray;
        }
    }
    catch    
    {
        int[,] error = new int [0,0];
        Console.Write("To complete the task, we need all the values as well as the rows and columns values to be positive!\nFix the error and try again.");
        return error;
    }
}    
void Show2dArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
       Console.WriteLine();
    } 
    Console.WriteLine();  
}  
int[,] ReturnAnswerAverage(int [,] array)
{
    Console.Write("░ А теперь узри магию: \n");
    for(int i = 0; i<array.GetLength(0);i++)
    {  
        for(int j=0;j<array.GetLength(1); j++)
        {   
            for(int k = 0; k < array.GetLength(0); k++)
            {
                if(array[i,k] < array[i,k+1])
                {
                    int temp = array[i,k];
                    array[i,k] = array[i,k+1];
                    array[i,k+1] = temp; 
                }
            }                   
        } 
    }
    return array; 
}  

Console.Write("░ Здравствуй, босс, я готов к новым мучениям, кхм... исчислениям!\n");
Console.Write("░ Народная мудрость гласит, что 90% успеха вычисления, зависит от корректно введенных данных!\n");
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int[,] Arr = ReturnAnswerAverage(myArray);
Show2dArray(Arr);
*/
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int[,] CreateRandom2dArray() // Создание массива и обработка ошибок ввода(отсутствие числа или задание отрицательного значения для rows и columns)
{
    try
    {
        Console.Write("Задайте кол-во строк массива: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Задайте кол-во колонок массива: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.Write("Задайте минимальное число, от которого будем генерировать массив: ");  
        int minValue = Convert.ToInt32(Console.ReadLine());
        Console.Write("Задайте максимальное число, до которого будем генерировать массив: ");
        int maxValue = Convert.ToInt32(Console.ReadLine());
        int[,] error = new int [0,0];
        int[,] newArray = new int [rows,columns];
        
        if(rows == columns)
        {
            Console.Write("ERROR:\n");
            Console.Write($"░ Извините, я думаю мы не поняли друг друга, нужен ведь прямоугольный массив.\n░ А у вас кол-во колонок: {columns}, равно, кол-ву строк: {rows}.\n░ Не-е так дело не пойдет, подумайте над своим поведением и приходите снова.\n");
            return error;
        }
        if(minValue > maxValue)
        {
            Console.Write("ERROR:\n");
            Console.Write($"░ Ох, извините, но выполнить вашу задачу невозможно.\n░ Вы задали минимальное возможное число в массиве: {minValue}, больше, чем максимальное: {maxValue}.\n░ Не-е так дело не пойдет, подумайте над своим поведением и приходите снова.\n");
            return error;
        }
        else
        {
            for(int i = 0; i< rows;i++)
            {
                for(int j = 0; j < columns; j++ )
                {
                    newArray[i,j] = new Random().Next(minValue, maxValue + 1);           
                }
            } 
            return newArray;
        }
    }
    catch    
    {
        int[,] error = new int [0,0];
        Console.Write("ERROR:\n");
        Console.Write("░ To complete the task, we need all the values as well as the rows and columns values to be positive!\n░ Fix the error and try again.");
        return error;
    }
}    
void Show2dArray(int[,] array)
{
    Console.Write($"░ Сгенерирован случайный двумерный массив:\n");
    for(int i = 0; i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
       Console.WriteLine();
    } 
    Console.WriteLine();  
}  
int[] ReturnAnswerAverage(int [,] array)
{
    int[] arr = new int [array.GetLength(0)];
    for(int i = 0; i<array.GetLength(0);i++)
    {
        int averange_value = 0;
        for(int j=0;j<array.GetLength(1); j++)
        {
            averange_value += array[i,j];
            arr[i] = averange_value;    
        } 
    }
   return arr; 
}  
void ShowArray(int[] array)
{
    int min_value = array[0];
    int count = 1;
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"░ Сумма чисел в {i+1} строке, равна: {array[i]}\n");
        if(min_value > array[i])
        {
            min_value = array[i];
            count++;
        }
    } 
    Console.Write("\n");
    Console.Write($"░ Наименьшая сумма чисел находится в {count} строке и равна: {min_value}\n");
} 
int[,] ArrayNumUser = CreateRandom2dArray();
Show2dArray(ArrayNumUser);
int[] Arr = ReturnAnswerAverage(ArrayNumUser);
ShowArray(Arr);
*/

