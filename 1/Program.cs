﻿ // Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равно 3 символа. Первоначальный массив можно ввести с клавиатуры,
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами. 

Main();

void Main() {

string [] strArray = {"Hello", "Hi", "Tomorro", "GB", "Forever"};
int N = 0;
string [] rezalt = new string [N];

PrintArr(Find(strArray));

string [] Find(string[] strArr) 
{
    int j = 0;
    for (int i = 0; i < strArr.Length; i++)
    {
        if (3 >= strArr[i].Length) 
        {
            Array.Resize(ref rezalt, ++N);  
            rezalt[j] = strArr[i];
            j++;            
        }
    }
    return rezalt;
}
 
void PrintArr(string [] a)                                     
{                                
    Console.Write ("[ ");
    for (int i = 0; i < a.Length; i++) {
        if (i < a.Length-1)   {
        Console.Write ($"{a[i]}, ");    }
        else  {
            Console.Write (a[i]);       } 
  }
    Console.Write (" ]");
    Console.WriteLine("  "); 
}

}