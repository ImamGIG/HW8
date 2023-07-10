
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// void OrderingАrray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }
// int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for (int j = 0; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[,] myArray = Create2DArray(5, 5, 1, 10);
// Print2DArray(myArray);
// OrderingАrray(myArray);
// Print2DArray(myArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// void ResultSum(int [,] array) 
// {
// int minSumLine = 0;
// int sumLine = SumLineElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempSumLine = SumLineElements(array, i);
//   if (sumLine > tempSumLine)
//   {
//     sumLine = tempSumLine;
//     minSumLine = i;
//   }
// }
// Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");
// }


// int SumLineElements(int[,] array, int i)
// {
//   int sumLine = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumLine += array[i,j];
//   }
//   return sumLine;
// }

// int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for (int j = 0; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[,] myArray = Create2DArray(5, 5, 1, 10);
// Print2DArray(myArray);
// ResultSum(myArray);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:

// int[,] TwoMatrix(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// int[,] OneMatrix(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }


// int[,] ResultMatrix(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }


// void MultiplyMatrix(int[,] OneMatrix, int[,] TwoMatrix, int[,] ResultMatrix)
// {
//     for (int i = 0; i < ResultMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < ResultMatrix.GetLength(1); j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < ResultMatrix.GetLength(1); k++)
//             {
//                 sum += OneMatrix[i, k] * TwoMatrix[k, j];
//             }
//             ResultMatrix[i, j] = sum;
//         }
//     }
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

//     int[,] array1 = OneMatrix(2, 2, 1, 10);
//     int[,] array2 = TwoMatrix(2, 2, 1, 10);
//     int[,] arrayRes = ResultMatrix(2, 2, 1, 10);

//     Print2DArray(array1);
//     Print2DArray(array2);
//     MultiplyMatrix(array1, array2, arrayRes);
//     Print2DArray(arrayRes);

// Задача 62 Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:


// int[,] Spiral(int n) 
// {
//     int[,] myArray = new int [n, n];

//     int pos = 1;
//     int count = n;
//     int value = -n;
//     int sum = -1;

//     while (count > 0) 
//     {
//         value = -1 * value / n;
//         for (int i = 0; i < count; i++) 
//             {
//                 sum += value;
//                 myArray[sum / n, sum % n] = pos++;
//             }
//             value *= n;
//             count--;
//         for (int i = 0; i < count; i++) 
//             {
//                 sum += value;
//                 myArray[sum / n, sum % n] = pos++;
//             }
//     } 

//     return myArray;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// Print2DArray(Spiral(4));
