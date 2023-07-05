// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;

Clear();
WriteLine();
int[,] arrr = new int[5, 9];
FilArray(arrr);
PrintArray(arrr);
SortArray(arrr);
PrintArray(arrr);

void FilArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++) ar[i, j] = new Random().Next(1, 99);
    }
}


void PrintArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++) Write(ar[i, j] + " ");
        WriteLine();
    }
    WriteLine();
}


void SortArray(int[,] ar)
{
    for (int k = 0; k < ar.GetLength(0); k++)
    {
        for (int j = 0; j < ar.GetLength(1) - 1; j++)
        {
            for (int i = 0; i < ar.GetLength(1) - 1; i++)
            {

                if (ar[k, i] < ar[k, i + 1])
                {
                    int c = ar[k, i];
                    ar[k, i] = ar[k, i + 1];
                    ar[k, i + 1] = c;

                }

            }
        }
    }
    return;
}