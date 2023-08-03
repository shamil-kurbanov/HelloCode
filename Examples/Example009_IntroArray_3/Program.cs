using System;
using static System.Console; 

Clear();

void FillArray(int[] collection)
{
    int n = collection.Length;

    for (int i = 0; i < n; i++)
    {
        collection[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] collection){
    int n = collection.Length;

    for (int i = 0; i < n; i++)
    {
        Write($"{collection[i]} ");
    }
}

//erstell ein Array mit FillArray
int[] numbers = new int[100];
FillArray(numbers);

//gib das Array mit PrintArray aus
PrintArray(numbers);

//Jetzt versuchen wir die Position eines Elements zu finden
try 
{
    WriteLine($"\n\nEnter the index of the element you want to see:");
    int index = Convert.ToInt32(ReadLine());
    int possition = IndexOf(numbers, index); //gibt die Position des Elements zurück

    switch (possition)
    {
    case -1:
        WriteLine("\nYour number is not in the array");
        break;
    default:
        WriteLine($"\nYour number is at possition {possition}");
        break;
    };

}
catch (System.Exception)
{
    WriteLine("\nPlease enter a valid number");
}

// Diese Methode gibt die Position des Elements zurück
int IndexOf(int[] collection, int findValue)
{
    int n = collection.Length;

    for (int i = 0; i < n; i++)
    {
        if (collection[i] == findValue)
        {
            return i;
        }
    }

    return -1;
}
