//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(100, 1000);
}



int Numbers(int[] array)
{
    int d = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
            d = d + 1;
    }
    return d;
}


Console.Clear();
Console.Write("Введите размер массива >>> ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine($"{Numbers(array)}");

*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11);
}



int Numbers(int[] array)
{
    int d = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
            d = d + array[i];
    }
    return d;
}


Console.Clear();
Console.Write("Введите размер массива >>> ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine($"{Numbers(array)}");
*/


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 1001);
}

int Num(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
            if(max<array[i])
                max = array[i];

            else if(min>array[i])
                min = array[i];
    }
    int num = max - min;
    return num;
}

Console.Clear();

Console.Write("Введите размер массива >>> ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine($"Разница между максимальным и минимальным: {Num(array)} ");
*/








// **
//Что имеется под "Гарантируется, что во входных данных не более 100 чисел и среди них есть хотя бы одно число 0, перед которым идет как минимум 2 элемента."?
//Сделал сразу два варианта, с ручным вводом и рандомным :D

/*

int[] array = new int[100];

// for(int i = 0; i < array.Length; i++)
// {
//     Console.Write($"Введите число {i+1} >>> ");
//     array[i] = Convert.ToInt32(Console.ReadLine());

// }

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 101);
}

int m = new Random().Next(2, 101);
array[m] = 0;
Console.WriteLine($"[{string.Join(", ", array)}]");

int f = 0;
int Max = 0;
int noMax = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > Max)
    {
        Max = array[i];
    }
    else if(array[i] == 0)
    {
        f = i;
        break;
    }
}

int j = 0;
while(j < f)
{
    if(array[j] > noMax && array[j] < Max)
        noMax = array[j];
    j++;
}

Console.WriteLine(Max);
Console.WriteLine(noMax);

*/


//Не успел додумать (

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число {i+1} >>> ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}



void Numbers(int[] array, int k)
{
    int t = 0;
    for (int i = 0; i < array.Length * k; i = i + k)
    {
        array[i+k] = array[i];
    }
}


Console.Clear();

Console.Write("Введите размер массива >>> ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

Console.Write("Введите число на которое нужно сдвинуть массив >>> ");
int k = Convert.ToInt32(Console.ReadLine());


InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");



Numbers(array, k);
Console.WriteLine($"[{string.Join(", ", array)}]");

