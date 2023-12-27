int Fact(int t)
{
    int factorial = 1;
    int i = 1;
    do
    {
        factorial *= i;
        i++;
    } while (i <= t);

    return factorial;
}

void task3_1()
{
    Console.WriteLine("Введите число А: ");
    var a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B: ");
    var b = Convert.ToInt32(Console.ReadLine());
    var res = 1;

    for (var i = 0; i < b; i++)
    {
        res *= a;
    }

    Console.WriteLine("Результат: " + res);
}

void task3_2()
{
    Console.WriteLine("Введите число А: ");
    var a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Результат: ");
    for (int i = a; i <= 1000; i += a)
    {
        if ((i % a) == 0)
            Console.WriteLine(i);
    }
}

void task3_3()
{
    Console.WriteLine("Введите число А: ");
    var a = Convert.ToInt32(Console.ReadLine());
    int count = 0;

    for (int i = 1; i < a; i++)
    {
        if (Math.Pow(i, 2) < a)
            count++;
    }

    Console.WriteLine("Результат: " + count);
}

void task3_4()
{
    Console.WriteLine("Введите число А: ");
    var a = Convert.ToInt32(Console.ReadLine());
    List<int> divisors = new List<int>();

    for (int i = 1; i < a; i++)
    {
        if ((a % i) == 0)
            divisors.Add(i);
    }

    Console.WriteLine("Результат: " + divisors.Max());
}

void task3_5()
{
    Console.WriteLine("Введите число А: ");
    var a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите число B: ");
    var b = Convert.ToDouble(Console.ReadLine());
    int divisor = 7;
    double sum = 0;

    if (a == b)
    {
        if (a % divisor == 0)
            sum = a;
    }
    else if (a > b)
    {
        for (double i = b; i <= a; i++)
        {
            if (i % divisor == 0)
                sum += i;
        }
    }
    else if (a < b)
    {
        for (double i = a; i <= b; i++)
            if (i % divisor == 0)
                sum += i;
    }

    Console.WriteLine("Результат: " + sum);
}

void task3_6()
{
    Console.WriteLine("Введите число N: ");
    var n = Convert.ToInt32(Console.ReadLine());

    if (n < 0)
    {
        Console.WriteLine("Введенно некорректное значение.");
    }
    else
    {
        int first = 1;
        int second = 1;
        int sum = 0;
        //счётчик элементов начинается с 2, так как первые два элемента известны
        int i = 2;
        while (i <= n)
        {
            sum = first + second;
            first = second;
            second = sum;
            i++;
        }
        Console.WriteLine("Результат: " + first);
    }

}

void task3_7()
{
    Console.WriteLine("Введите число А: ");
    var a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B: ");
    var b = Convert.ToInt32(Console.ReadLine());

    if (a < 0) a = Math.Abs(a);
    if (b < 0) b = Math.Abs(b);

    while ((a != 0) && (b != 0))
    {
        if (a > b)
            a %= b;
        else
            b %= a;
    }

    var res = a + b;

    Console.WriteLine("Результат: " + res);

}

void task3_8()
{
    static int f(double x)
    {
        return Convert.ToInt32(Math.Pow(x, 1 / 3));
    }

    Console.WriteLine("Введите число N: ");
    var n = Convert.ToInt32(Console.ReadLine());

    if (n < 0) Console.WriteLine("Число N должно быть положительным");
    else
    {
        Console.WriteLine("Задайте левую границу интервала a: ");
        var a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Задайте правую границу интервала b: ");
        var b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Задайте точность по аргументу: ");
        var epsx = Convert.ToDouble(Console.ReadLine());
        Console.Write("Задайте точность по функции: ");
        var epsy = Convert.ToDouble(Console.ReadLine());

        if (f(a) * f(b) > 0)
        {
            Console.WriteLine("Неверно задан интервал!");
            return;
        }
        if (Math.Abs(f(a)) <= epsy)
        {
            Console.WriteLine("Корень на границе a.");
            return;
        }
        if (Math.Abs(f(b)) <= epsy)
        {
            Console.WriteLine("Корень на границе b.");
            return;
        }

        double c = (a + b) / 2;
        double result;
        while (Math.Abs((b - a) / 2) > epsx || (Math.Abs(f(c)) > epsy))
        {
            c = (a + b) / 2;
            if (f(a) * f(c) < 0)
            {
                b = c;
            }
            else
            {
                a = c;
            }
        }
        result = (a + b) / 2;
        Console.WriteLine("Результат          : {0}", result);
        Console.WriteLine("Погрешность        : {0}", Math.Abs(f(result)));
    }

}

void task3_9()
{
    Console.WriteLine("Введите число N: ");
    var n = Convert.ToInt32(Console.ReadLine());
    int count = 0;

    while (n > 0)
    {
        if (n % 2 != 0)
            count++;
        n /= 10;
    }

    Console.WriteLine("Результат: " + count);
}

void task3_10()
{
    Console.WriteLine("Введите число N: ");
    var n = Convert.ToInt32(Console.ReadLine());
    int res = 0;

    if (n < 0) Console.WriteLine("Введено отрицательное число");
    else
    {
        while (n > 0)
        {
            res *= 10;
            res += n % 10;
            n /= 10;
        }

        Console.WriteLine("Результат: " + res);
    }
}

void task3_11()
{
    Console.WriteLine("Введите число N: ");
    var n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Результат: ");
    for (int i = 1; i <= n; i++)
    {
        int evenSum = 0, oddSum = 0;
        var num = i;
        while (num > 0)
        {
            int digit = num % 10;
            num /= 10;
            if (digit % 2 == 0)
                evenSum += digit;
            else
                oddSum += digit;
        }
        if (evenSum > oddSum)
            Console.WriteLine(i);
    }
}

void task3_12()
{
    Console.WriteLine("Введите число A: ");
    var a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B: ");
    var b = Convert.ToInt32(Console.ReadLine());
    var res = false;
    var max = Math.Max(a, b);
    while (max > 0)
    {
        var digit1 = max % 10;
        max /= 10;
        var min = Math.Min(a, b);
        while (min > 0)
        {
            var digit2 = min % 10;
            min /= 10;
            if (digit1 == digit2)
                res = true;
        }
    }

    Console.WriteLine(res ? "ДА" : "НЕТ");
}

void task3_13()
{
    Console.WriteLine("Введите натуральное число N: ");
    var n = Convert.ToInt32(Console.ReadLine());
    double res = 0;

    if (n > 0)
    {
        while (n > 0)
        {
            res += 1 + 1 / Math.Pow(n, 2);
            n--;
        }

        Console.WriteLine("Результат: " + res);
    }
    else
    {
        Console.WriteLine("Число N должно быть натуральным");
    }
}

//не сделано
void task3_14_1()
{
    Console.WriteLine("Введите натуральное число N: ");
    var n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите действительное число X: ");
    var x = Convert.ToDouble(Console.ReadLine());
    double result = 0;

    for (int i = 0; i < n; i++)
    {
        var a = 1.0 / x + i;
        for (int j = 0; j < n; j++)
        {
            //result +=
        }
    }
}


void task3_14_2()
{
    Console.WriteLine("Введите натуральное число N: ");
    var n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите действительное число X: ");
    var x = Convert.ToDouble(Console.ReadLine());
    double result = 0;

    for (int i = 1; i <= n; i++)
    {
        result += Math.Pow(x, i) / Fact(i);
    }

    Console.WriteLine(result);
}

void task3_15_1()
{
    Console.WriteLine("Введите натуральное число N: ");
    var n = Convert.ToInt32(Console.ReadLine());
    double result = 1;

    for (int i = 1; i <= n; i++)
    {
        result *= (2 + 1.0 / Fact(i));
    }

    Console.WriteLine(result);
}

void task3_15_2()
{
    Console.WriteLine("Введите натуральное число N: ");
    var n = Convert.ToInt32(Console.ReadLine());
    double result = 0;

    for (int i = 1; i <= n; i++)
    {
        result += (1.0 + i) / Fact(i);
    }

    Console.WriteLine(result);
}

void task3_16_1()
{
    Console.WriteLine("Введите значение точности: ");
    var d = Convert.ToDouble(Console.ReadLine());
    double result = 0, a = 0;
    var i = 1;

    do
    {
        a = 1.0 / (i * i);
        result += a;
        i++;
    } while (a > d);

    Console.WriteLine(result);
}


void task3_16_2()
{
    Console.WriteLine("Введите значение точности: ");
    var d = Convert.ToDouble(Console.ReadLine());
    double result = 0, a = 0;
    int i = 1, j = 3;

    do
    {
        a = 1.0 / (i * j);
        result += a;
        i++;
        j++;
    } while (a > d);

    Console.WriteLine(result);
}

//не сделано
void task3_16_3()
{
    Console.WriteLine("Введите значение точности: ");
    var d = Convert.ToDouble(Console.ReadLine());
    double result = 0, a = 0;
    int i = 1, j = 1;
}

void task3_17()
{
    int Sum(int x)
    {
        int sum = 0;

        while (x > 0)
        {
            int digit = x % 10;
            x /= 10;
            sum += digit;
        }

        return sum;
    }

    for (int i = 10; i <= 99; i++)
    {
        //флаг сбрасывается в false, как только находится число, в котором сумма цифр не равна сумме цифр до умножения
        var res = true;
        var sumBefore = Sum(i);
        for (int j = 2; j <= 9; j++)
        {
            var sumAfter = Sum(i * j);

            if (sumBefore != sumAfter)
                res = false;
        }

        if (res)
            Console.WriteLine(i);
    }
}

void task3_18()
{
    for (var i = 100; i <= 999; i++)
    {
        int hundreds = i / 100;
        int tens = i / 10 % 10;
        int units = i % 10;
        int sum = Fact(hundreds) + Fact(tens) + Fact(units);

        if (i == sum)
            Console.WriteLine(i);
    }
}

void task3_19()
{
    Console.WriteLine("Введите натуральное число M: ");
    var m = Convert.ToInt32(Console.ReadLine());

    int first = 1;
    int second;
    bool flag = false;
    do
    {
        second = m - Convert.ToInt32(Math.Pow(first, 2));
        double second_sqrt = Math.Sqrt(second);
        if (second_sqrt % 1 == 0)
            flag = true;
        else
            first++;
    } while ((!flag) && (first < Math.Sqrt(m)));

    if (flag)
        Console.WriteLine(first + " и " + second);
    else
        Console.WriteLine("Числа не найдены");
}

void task3_20()
{
    Console.WriteLine("Введите натуральное число M: ");
    var m = Convert.ToInt32(Console.ReadLine());

    int sum = 0;
    for (int i = 1; i < m; i++)
    {
        if (m % i == 0)
            sum += i;
    }

    string result = sum == m ? "Число является совершенным" : "Число не является совершенным";
    Console.WriteLine(result);
}

void task3_21()
{
    Console.WriteLine("Введите k номер элемента числовой последовательности");
    var k = Convert.ToInt32(Console.ReadLine());

    int i = 1;

    while (i != k)
    {
        i++;
    }

    Console.WriteLine(i);
}

