//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] GenerateArray(int sizeArray, int leftRange, int rightRange)
{
    int[] newArray = new int[sizeArray];
    Random rand = new Random();

    for(int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return newArray;
}

void PrintArray(int[] arrayForPrint)
{
     for(int i = 0; i < arrayForPrint.Length; i++)
     { 
         Console.Write(arrayForPrint[i] + " | ");
      }
 }     

int[] array = GenerateArray(8,-10000, 10000);
PrintArray(array);
