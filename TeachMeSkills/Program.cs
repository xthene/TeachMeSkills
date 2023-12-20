void task1()
{
    Console.WriteLine("Введите число a: ");
    var a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите число b: ");
    var b = Convert.ToDouble(Console.ReadLine());
    double res = 0;

    if (a > b)
    {
        res = a + b;
    }
    else if (a == b)
    {
        res = a * b;
    }
    else
    {
        res = a - b;
    }

    Console.WriteLine("Результат: " + res);
}

void task2()
{
    Console.WriteLine("Введите число x: ");
    var x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите число y: ");
    var y = Convert.ToDouble(Console.ReadLine());

    if (x > 0 && y > 0)
    {
        Console.WriteLine("Точка находится в первой четверти.");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Точка находится во второй четверти.");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Точка находится в третьей четверти");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Точка находится в четвёртой четверти");
    }
    else if (x == 0 || y == 0)
    {
        Console.WriteLine("Точка находится на одной из осей координат");
    }
}

void task3()
{
    Console.WriteLine("Введите число a: ");
    var a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите число b: ");
    var b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите число c: ");
    var c = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Результат: ");
    if (a < b && a < c)
    {
        Console.WriteLine(a);
        Console.WriteLine(Math.Min(b, c));
        Console.WriteLine(Math.Max(b, c));
    }
    if (b < a && b < c)
    {
        Console.WriteLine(b);
        Console.WriteLine(Math.Min(a, c));
        Console.WriteLine(Math.Max(a, c));
    }
    if (c < b && c < a)
    {
        Console.WriteLine(c);
        Console.WriteLine(Math.Min(a, b));
        Console.WriteLine(Math.Max(a, b));
    }
}

void task4()
{
    Console.WriteLine("Введите число a: ");
    var a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите число b: ");
    var b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите число c: ");
    var c = Convert.ToDouble(Console.ReadLine());

    double d = b * b - 4 * a * c;

    switch (d)
    {
        case < 0: Console.WriteLine("Корней нет."); break;
        case 0:
            {
                var x = -b / 2 * a;
                Console.WriteLine("Корень уравнения: " + x);
            }
            break;
        case > 0:
            {
                var x1 = (-b + Math.Sqrt(d)) / 2 * a;
                var x2 = (-b - Math.Sqrt(d)) / 2 * a;
                Console.Write("Корень уравнения: {0} \nКорень уравнения: {1}", x1, x2);
            }
            break;
    }
}

void task5()
{
    Console.WriteLine("Введите двузначное число: ");
    var number = Convert.ToInt32(Console.ReadLine());

    if (number >= 10 && number < 100)
    {
        switch (number / 10)
        {
            case 2: Console.Write("двадцать "); break;
            case 3: Console.Write("tridtsat "); break;
            case 4: Console.Write("сорок "); break;
            case 5: Console.Write("пятьдесят "); break;
            case 6: Console.Write("шестьдесят "); break;
            case 7: Console.Write("семьдесят "); break;
            case 8: Console.Write("восемьдесят "); break;
            case 9: Console.Write("девяносто "); break;
        }

        switch (number % 10)
        {
            case 1: Console.Write("один"); break;
            case 2: Console.Write("dva"); break;
            case 3: Console.Write("три"); break;
            case 4: Console.Write("четыре"); break;
            case 5: Console.Write("пять"); break;
            case 6: Console.Write("шесть"); break;
            case 7: Console.Write("семь"); break;
            case 8: Console.Write("восемь"); break;
            case 9: Console.Write("девять"); break;
        }

        if (number >= 10 && number < 20)
        {
            switch (number)
            {
                case 11: Console.WriteLine("одинадцать"); break;
                case 12: Console.WriteLine("двенадцать"); break;
                case 13: Console.WriteLine("тринадцать"); break;
                case 14: Console.WriteLine("четырнадцать"); break;
                case 15: Console.WriteLine("пятнадцать"); break;
                case 16: Console.WriteLine("шестнадцать"); break;
                case 17: Console.WriteLine("семнадцать"); break;
                case 18: Console.WriteLine("восемнадцать"); break;
                case 19: Console.WriteLine("девятнадцать"); break;
            }

        }
    }
}

void task6()
{
    Console.WriteLine("Введите координату x0 центра круга: ");
    var x0 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите координату y0 центра круга: ");
    var y0 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите радиус круга r: ");
    var r = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите координату x искомой точки: ");
    var x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите координату y искомой точки: ");
    var y = Convert.ToDouble(Console.ReadLine());

    var distance = Math.Sqrt(Math.Pow((x - x0), 2) + Math.Pow((y - y0), 2));

    Console.WriteLine(distance <= r ? "Точка входит в окружность" : "Точка не входит в окружность");
}

void task7()
{
    Console.WriteLine("Выберите задание (a, b, c, d): ");
    var answer = Console.ReadLine();

    switch (answer)
    {
        case "a":
            {
                Console.WriteLine("Введите трехзначное число: ");
                var a = Convert.ToInt32(Console.ReadLine());
                var res = Math.Pow(a, 2) == Math.Pow((a / 100 + a / 10 % 10 + a % 10), 3);

                Console.WriteLine(res.ToString());
            }
            break;
        case "b":
            {
                Console.WriteLine("Введите четырехзначное число: ");
                var a = Convert.ToInt32(Console.ReadLine());
                var res = a / 1000 + a / 100 % 10 == a / 10 % 10 + a % 10;
                Console.WriteLine(res.ToString());
            }
            break;
        case "c":
            {
                Console.WriteLine("Введите трехзначное число: ");
                var number = Convert.ToInt32(Console.ReadLine());
                int a = number / 100;
                int b = number / 10 % 10;
                int c = number % 10;
                bool res = a == b || a == c || b == c;

                Console.WriteLine(res.ToString());
            }
            break;
        case "d":
            {
                Console.WriteLine("Введите дробное число: ");
                var number = Convert.ToDouble(Console.ReadLine());

                var fraction = number % 1;

                var a = Math.Truncate(fraction * 10);
                var b = Math.Truncate(fraction * 100) % 10;
                var c = Math.Truncate(fraction * 1000) % 10;

                var res = a == 0 || b == 0 || c == 0;

                Console.WriteLine(res.ToString());

            }
            break;
    }

}


task7();
