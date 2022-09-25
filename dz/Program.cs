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

int MinElementArrayIndex (int[] ar){
    int min = ar[0];
    int index = 0;
    for (int i = 0; i < ar.Length; i++)
    {
        if (min > ar[i]){
            min = ar[i];
            index = i;
        }
    }
    return index;
}
/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
/*
int [,] array54 = CreateArrayMatrix(4, 6, -10, 100);
PrintArrayMatrix(array54);
int [] array54help = new int [array54.GetLength(1)];
for (int i = 0; i < array54.GetLength(0); i++)
{
    for (int j = 0; j < array54.GetLength(1); j++)
    {
        array54help[j] = array54[i,j];
    }
    ShellSort(array54help);
    for (int j = 0; j < array54.GetLength(1); j++)
    {
        array54[i,j] = array54help[j];
    }
}
PrintArrayMatrix(array54);
*/



/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка*/

/*
int [,] array56 = CreateArrayMatrix(3, 3, -10, 100);
PrintArrayMatrix(array56);
int [] sumrows = new int [array56.GetLength(0)];
for (int i = 0; i < array56.GetLength(0); i++)
{   
    int sumrow = 0;
    for (int j = 0; j < array56.GetLength(1); j++)
    {
        sumrows[i] += array56[i,j];
    }
}
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {MinElementArrayIndex (sumrows)+1} строка");
*/

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
/*
void MatrixMultiplication (int [,] matrixmultiplication, int [,] ar1, int [,] ar2){
    if (ar1.GetLength(0) != ar2.GetLength(1)){
         Console.WriteLine("Умножение матриц не возможно!");
    }
    else{
        for (int i = 0; i < ar1.GetLength(0); i++)
        {
            for (int j = 0; j < ar2.GetLength(1); j++)
            {
                for (int k = 0; k < ar2.GetLength(0); k++)
                {
                    matrixmultiplication[i,j] += ar1[i,k] * ar2[k,j];
                }
            }
        }
    }
}

int [,] array581 = CreateArrayMatrix(2, 3, 0, 6);
PrintArrayMatrix(array581);

int [,] array582 = CreateArrayMatrix(3, 2, 0, 6);
PrintArrayMatrix(array582);

int [,] array581582 = new int [array581.GetLength(0), array582.GetLength(1) ];
MatrixMultiplication(array581582, array581, array582);
PrintArrayMatrix(array581582);
*/


/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/
/*
int [,,] array60 = new int [2,2,2];
int q = 1;
for (int i = 0; i < array60.GetLength(0); i++)
{
    for (int j = 0; j < array60.GetLength(1); j++)
    {
        for (int k = 0; k < array60.GetLength(2); k++)
        {
            Console.Write($"{array60[i,j,k]=q} : [{i},{j},{k}] ");
            q++;
        }
        Console.WriteLine();
    }
}*/
    


/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/


int [,] array62 = new int [4,4];
    for (int i = 0; i < array62.GetLength(0)/2; i++)
    {
        for (int j = i; j < array62.GetLength(1)-1-i; j++)
        {
            array62 [i,j] = 10*i+i+j+1;
            array62 [j, array62.GetLength(1)-1-i] = array62 [i,j] + array62.GetLength(1) - 2*i - 1; 
            array62 [array62.GetLength(0)-1-i, array62.GetLength(1)-1-j] 
                        = array62 [j, array62.GetLength(1)-1-i]+array62.GetLength(0)-2*i-1;
            array62 [array62.GetLength(1)-j-1, i] 
                        = array62 [array62.GetLength(0)-i-1, array62.GetLength(1)-j-1] + array62.GetLength(1)-2*i-1;
            Console.WriteLine(i);
        }
        
    }

    PrintArrayMatrix(array62);
