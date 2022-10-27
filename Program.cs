// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

string[] array1 = new string[5] {"more", "123", "world", "hello", "ok"};
string[] array2 = new string[array1.Length];

int count = 0;


void SecondArrayGenerator(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

 void PrintArray(string[] ar)
    {
           
    for (int i=0;i<ar.Length;i++) 
        {
            if (i!=ar.Length-1) Console.Write($"{ar[i]} ");
            else Console.WriteLine($"{ar[i]} ");
        }

    }

SecondArrayGenerator(array1, array2);
PrintArray(array2);



