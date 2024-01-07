using System.Text;

int[] createIntArray(int count)
{
    int[] result = new int[count];

    for (int i = 0; i < count; i++)
    {
        result[i] = new Random().Next(-100, 100);
        Console.Write(result[i] + " ");
    }

    return result;
}

//Найти минимальный элемент массива
void task1()
{
    var array = createIntArray(10);
    int result = array[0];

    foreach (var item in array)
    {
        if (result > item)
            result = item;
    }

    Console.WriteLine("\nМинимальный элемент массива: " + result);
}

//Найти максимальный элемент массива
void task2()
{
    var array = createIntArray(10);
    int result = array[0];

    foreach (var item in array)
    {
        if (result < item)
            result = item;
    }

    Console.WriteLine("\nМаксимальный элемент массива: " + result);
}


//Найти индекс минимального элемента массива
void task3()
{
    var array = createIntArray(10);
    int minElement = array[0];
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (minElement > array[i])
        {
            minElement = array[i];
            result = i;
        }
    }

    Console.WriteLine("\nИндекс минимального элемента массива: " + result);
}

//Найти индекс максимального элемента массива
void task4()
{
    var array = createIntArray(10);
    int maxElement = array[0];
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (maxElement < array[i])
        {
            maxElement = array[i];
            result = i;
        }
    }

    Console.WriteLine("\nИндекс максимального элемента массива: " + result);
}

//Посчитать сумму элементов массива с нечётными индексами
void task5()
{
    var array = createIntArray(10);
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            result += array[i];
    }

    Console.WriteLine("\nСумма элементов массива с нечётными индексами: " + result);
}

//Сделать реверс массива
void task6()
{
    Console.WriteLine("Введите длину массива: ");
    var array = createIntArray(Convert.ToInt32(Console.ReadLine()));
    int temp;

    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    Console.WriteLine("\nРезультат: ");
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
}

//Посчитать количество нечётных элементов массива
void task7()
{
    Console.WriteLine("Введите длину массива: ");
    var array = createIntArray(Convert.ToInt32(Console.ReadLine()));
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            result++;
    }

    Console.WriteLine("\nКоличество нечётных элементов массива: " + result);
}

//Поменять местами первую и вторую половины массива
void task8()
{
    Console.OutputEncoding = Encoding.UTF8;
    Console.WriteLine("Введите длину массива: ");
    var array = createIntArray(Convert.ToInt32(Console.ReadLine()));
    int a = array.Length % 2 == 0 ? array.Length / 2 : array.Length/ 2 + 1;

    for (int i = 0; i < array.Length / 2; i++)
    {
        int b = array[i];
        array[i] = array[i + a];
        array[i + a] = b;
    }

    Console.WriteLine("\nРезультат: ");
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
}

task8();