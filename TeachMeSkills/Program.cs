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

int[,] createIntTwoDimensionalArray(int count1, int count2)
{
    int[,] result = new int[count1, count2];

    for (int i = 0; i < count1; i++)
    {
        for (int j = 0; j < count2; j++)
        {
            result[i, j] = new Random().Next(-10, 10);
            Console.Write(result[i, j] + " ");
        }
        Console.WriteLine("");
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


//Найти минимальный элемент массива
void task2_1()
{
    Console.WriteLine("Введите длину массива: ");
    var count1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите длину массива: ");
    var count2 = Convert.ToInt32(Console.ReadLine());
    var array = createIntTwoDimensionalArray(count1, count2);

    int minElement = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minElement > array[i, j])
            {
                minElement = array[i, j];
            }
        }
    }

    Console.WriteLine("\nРезультат: " + minElement);
}

//Найти максимальный элемент массива
void task2_2()
{
    Console.WriteLine("Введите длину массива: ");
    var count1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите длину массива: ");
    var count2 = Convert.ToInt32(Console.ReadLine());
    var array = createIntTwoDimensionalArray(count1, count2);

    int maxElement = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (maxElement < array[i, j])
            {
                maxElement = array[i, j];
            }
        }
    }

    Console.WriteLine("\nРезультат: " + maxElement);
}

//Найти индекс минимального элемента массива
void task2_3()
{
    Console.WriteLine("Введите длину массива: ");
    var count1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите длину массива: ");
    var count2 = Convert.ToInt32(Console.ReadLine());
    var array = createIntTwoDimensionalArray(count1, count2);

    int minElement = array[0, 0];
    int result1 = 0;
    int result2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minElement > array[i, j])
            {
                minElement = array[i, j];
                result1 = i;
                result2 = j;
            }
        }
    }

    Console.WriteLine("\nРезультат: [" + result1 + ", " + result2 + "]");
}

//Найти индекс максимального элемента массива
void task2_4()
{
    Console.WriteLine("Введите длину массива: ");
    var count1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите длину массива: ");
    var count2 = Convert.ToInt32(Console.ReadLine());
    var array = createIntTwoDimensionalArray(count1, count2);

    int maxElement = array[0, 0];
    int result1 = 0;
    int result2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (maxElement < array[i, j])
            {
                maxElement = array[i, j];
                result1 = i;
                result2 = j;
            }
        }
    }

    Console.WriteLine("\nРезультат: [" + result1 + ", " + result2 + "]");
}

//5.  Найти количество элементов массива, которые больше всех своих соседей одновременно
void task2_5()
{
    var array = createIntTwoDimensionalArray(5, 4);
    //var array = new int[,] { { 0, 9, 2 }, {9, 4, 9}, { 2, 9, 2 } };
    var rowsCount = array.GetLength(0);
    var columnsCount = array.GetLength(1);
    var lastElementIndex1 = rowsCount - 1;
    var lastElementIndex2 = columnsCount - 1;
    var result = 0;

    //у верхнего левого элемента [0, 0] два соседних элемента
    if (array[0, 0] > array[1, 0] && array[0, 0] > array[0, 1])
        result++;

    //для нижнего правого
    if (array[lastElementIndex1, lastElementIndex2] > array[lastElementIndex1 - 1, lastElementIndex2] &&
        array[lastElementIndex1, lastElementIndex2] > array[lastElementIndex1, lastElementIndex2 - 1])
        result++;

    //для верхнего правого
    if (array[0, lastElementIndex2] > array[0, lastElementIndex2 - 1] &&
        array[0, lastElementIndex2] > array[1, lastElementIndex2])
        result++;

    //для нижнего левого
    if (array[lastElementIndex1, 0] > array[lastElementIndex1 - 1, 0] &&
        array[lastElementIndex1, 0] > array[lastElementIndex1, 1])
        result++;

    //элементы первой строки кроме крайних
    for (int i = 1; i <= lastElementIndex2 - 1; i++)
    {
        if (array[0, i] > array[0, i - 1] && array[0, i] > array[1, i] && array[0, i] > array[0, i + 1])
            result++;
    }

    //элементы последней строки кроме крайних
    for (int i = 1; i <= lastElementIndex2 - 1; i++)
    {
        if (array[lastElementIndex1, i] > array[lastElementIndex1, i - 1] &&
            array[lastElementIndex1, i] > array[lastElementIndex1 - 1, i] &&
            array[lastElementIndex1, i] > array[lastElementIndex1, i + 1])
            result++;
    }

    //элементы первого столбца кроме крайних
    for (int i = 1; i <= lastElementIndex1 - 1; i++)
    {
        if (array[i, 0] > array[i - 1, 0] &&
            array[i, 0] > array[i, 1] &&
            array[i, 0] > array[i + 1, 0])
            result++;
    }

    //элементы последнего столбца кроме крайних
    for (int i = 1; i <= lastElementIndex1 - 1; i++)
    {
        if (array[i, lastElementIndex2] > array[i - 1, lastElementIndex2] &&
           array[i, lastElementIndex2] > array[i, lastElementIndex2 - 1] &&
           array[i, lastElementIndex2] > array[i + 1, lastElementIndex2])
            result++;
    }

    //для остальных элементов
    for (int i = 1; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 1; j < array.GetLength(1) - 1; j++)
        {
            if (array[i, j] > array[i + 1, j] && array[i, j] > array[i, j + 1] && array[i, j] > array[i, j - 1] && array[i, j] > array[i - 1, j])
                result++;
        }
    }

    Console.WriteLine(result);
}

task2_3();