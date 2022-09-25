int [] CreateArray (int n, int x, int y){ // n - size;  x - min element; y - max+1 element
    int [] array = new int [n];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(x, y);
    }
    return array;
}

void PrintArray (int[] ar){
    for (int i = 0; i < ar.Length; i++)
    {
        Console.Write($"{ar[i]} ");
    }
    Console.WriteLine();
}

int MaxElementArray (int[] ar){
    int max = ar[0];
    for (int i = 0; i < ar.Length; i++)
    {
        if (max < ar[i]){
            max = ar[i];
        }
    }
    return max;
}

int MinElementArray (int[] ar){
    int min = ar[0];
    for (int i = 0; i < ar.Length; i++)
    {
        if (min > ar[i]){
            min = ar[i];
        }
    }
    return min;
}

int [] ShellSort(int []ar)
{
    int i, j, step;
    int help;
    for (step = ar.Length / 2; step > 0; step /= 2){
        for (i = step; i < ar.Length; i++)
        {
            help = ar[i];
            for (j = i; j >= step; j -= step)
            {
                if (help < ar[j - step])
                    ar[j] = ar[j - step];
                else
                    break;
            }
            ar[j] = help;
        }
    }
    return ar;
}

//------------Двумерные массивы--------------//

int [,] CreateArrayMatrix (int m, int n, int x, int y){ // m - rom; n - column;  x - min element; y - max+1 element
    int [,] ar = new int [m,n];
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            ar [i,j] = new Random().Next(x, y);
        }
    }
    return ar;
}

void PrintArrayMatrix (int[,] ar){
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++){
            Console.Write($"{ar[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int MaxElementArrayMatrix (int[,] ar){
    int max = ar[0,0];
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
           if (max < ar[i,j]){
                max = ar[i,j];
            } 
        }
            
    }
    return max;
}

int MinElementArrayMatrix (int[,] ar){
    int min = ar[0,0];
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
           if (min > ar[i,j]){
                min = ar[i,j];
            } 
        }
            
    }
    return min;
}

int [] MatrixToArray(int [,]ar){
    int [] array = new int [ar.GetLength(0) * ar.GetLength(1)];
    for (int i = 0, z = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++, z++)
        {
            array[z] = ar[i,j];
        }
    }
    return array;
}

int [,] ArrayToMatrix(int []ar, int m, int n){
    int [,] array = new int [m, n];
    for (int i = 0, z = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++, z++)
        {
            array[i,j] = ar[z];
        }
    }
    return array;
}

void ChangeRowsAndColumns(int [,] ar){
    int help = 0;
    if(ar.GetLength(0) == ar.GetLength(0)){
        for (int i = 0; i < ar.GetLength(0); i++)
        {
            for (int j = 0; j < i; j++)
            {
                help = ar[i,j];
                ar[i,j] = ar[j,i];
                ar[j,i] = help;
                //Console.Write($"{ar[j,i]} ");
            }
        }
    }
}

int [,] TrianglePascals (int [,] ar, int n){ // n - column, rows;  
    ar [0, (n+n/2)] = 1;
    ar [1, (n+n/2)-1] = 1;
    ar [1, (n+n/2)+1] = 1;
    for (int i = 2; i < n; i++)
    {
        for (int j = 0; j < i; j++)
        {   if(i % 2 == 0){
                ar [i, (n+n/2)] =         ar[i-1, (n+n/2 - 1)] + ar[i-1, (n + n/2 + 1)];
                ar [i, (n+n/2) + (j+2)] = ar[i-1, ((n+n/2) + (j+2)-1)] + ar[i-1, ((n+n/2) + (j+2)+1)];
                ar [i, (n+n/2) - (j+2)] = ar[i-1, ((n+n/2) - (j+2)-1)] + ar[i-1, ((n+n/2) - (j+2)+1)];
            }
            else {
                ar [i, (n+n/2) + 1 + j] = ar[i-1, (n+n/2) + j] + ar[i-1, (n+n/2) + 2 + j];
                ar [i, (n+n/2) - 1 - j] = ar[i-1, (n+n/2) - j] + ar[i-1, (n+n/2) - 2 - j];
            }
        }
    }
    return ar;
}


/*Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.*/
/*
void ChangeFirstAndLastRow (int [,] ar){
    int help = 0;
    for (int i = 0; i < ar.GetLength(1); i++)
    {
        help = ar[0,i];
        ar[0,i] = ar[ar.GetLength(0) - 1 , i];
        ar[ar.GetLength(0) - 1 , i] = help;
    }
}

Console.WriteLine("Задача 53");
int [,] array53 = CreateArrayMatrix(4, 3, 0, 10);
PrintArrayMatrix(array53);
ChangeFirstAndLastRow(array53);
PrintArrayMatrix(array53);
*/

/*Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя.*/


    
/*
Console.WriteLine("Задача 53");
int [,] array55 = CreateArrayMatrix(5, 5, 0, 10);
PrintArrayMatrix(array55);
ChangeRowsAndColumns(array55);
PrintArrayMatrix(array55);


*/
/*Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь 
содержит информацию о том, сколько раз встречается элемент входных данных.*/
/*
void FrequencyDictionary(int [] ar){
    
    for (int i = 0; i < ar.Length; i++)
    {
        int count = 1;
        for (int j = i; j < ar.Length; j++){
            if(j != ar.Length-1 && ar[j] == ar[j+1]){
                count++;
            }
            else {
                i=j;
                break;
            }
        }
        Console.WriteLine($"Число {ar[i]} встречается {count} раз");
    }
}

Console.WriteLine("Задача 57");
int [,] array57 = CreateArrayMatrix(5, 4, 0, 10);
PrintArrayMatrix(array57);
int [] array57row = ShellSort(MatrixToArray(array57)); // перевожу двумерный массив в одномерный
                                                        // и сортирую по возрастанию
FrequencyDictionary(array57row);

*/
/*Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7*/
/*
Console.WriteLine("Задача 59");
int [,] array59 = CreateArrayMatrix(5, 4, -100, 1000);
PrintArrayMatrix(array59);

int [] minPosition = new int [2]; // массив с коорд мин позиции

int min = array59[0,0];
for (int i = 0; i < array59.GetLength(0); i++)  // ищем минимальный элемент и запоминаем позицию
    {
        for (int j = 0; j < array59.GetLength(1); j++)
        {
           if (min > array59[i,j]){
                min = array59[i,j];
                minPosition [0] = i;
                minPosition [1] = j;

            } 
        }
            
    }

    Console.WriteLine($"Мин = {min} ");
    Console.WriteLine(minPosition[0]);
    Console.WriteLine(minPosition[1]);
    
int [,] array59help = new int [array59.GetLength(0)-1, array59.GetLength(1)-1];
for (int i = 0; i < array59.GetLength(0)-1; i++)  //в этом цикле мы копируем в новый массив элементы старого массива
    {                                               // без строки и столбца с мин элементом
        for (int j = 0; j < array59.GetLength(1)-1; j++)
        {
            if (i < minPosition[0] && j < minPosition[1] ) { 
                array59help[i, j] = array59[i, j];
            }
            else if (i < minPosition[0] && j >= minPosition[1]){
                    array59help[i, j] = array59[i, j+1];
            }
            else if (i >= minPosition[0] && j < minPosition[1]){
                    array59help[i, j] = array59[i+1, j];
            }
            else if (i >= minPosition[0] && j >= minPosition[1]){
                array59help[i, j] = array59[i+1, j+1];
            }
        }  
    }

PrintArrayMatrix(array59help);

*/

/*Задача 61: Вывести первые N строк треугольника Паскаля. 
Сделать вывод в виде равнобедренного треугольника*/

Console.WriteLine("Задача 61");
Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
int [,] array61 = new int [n, 3*n];


PrintArrayMatrix(TrianglePascals (array61, n));