namespace TeachMeSkills;

public static class LinqHomeWork
{
    static void OutputResult<T>(IEnumerable<T> list)
    {
        foreach (var num in list)
        {
            Console.WriteLine(num);
        }
    }

    public static IEnumerable<int> GetPositiveTwoDigitNumbers()
    {
        var list = new List<int>() { 11, -21, 64, 59, 11, 0, -7, 53, -31, 1 };

        var result = list.Where(t => t >= 10 && t <= 99).Order();

        OutputResult(result);

        return result;
    }

    public static IEnumerable<int> GetEvenNumbers()
    {
        var list = new List<int> { 11, 23, 60, 57, 62, 17, 42, 34, 123 };

        var result = list.Where(t => t % 2 == 0);

        OutputResult(result);

        return result;
    }

    public static char[] Reverse()
    {
        var word = "automation";

        var result = word.Reverse().ToArray();
        Console.WriteLine(result);

        return result;
    }

    public static IEnumerable<string> ChangeFirstLetter()
    {
        var names = new List<string>()
        {
            "Alexa",
            "Kirill",
            "Jonas",
            "Alina",
            "Andrey",
            "Danila",
            "Nick",
            "Amer",
            "Chastity",
            "Kristina",
            "Amelia"
        };

        var namesStartsWithA = names.Where(n => n.StartsWith("A"));
        var namesStartsWithI = new List<string>();

        foreach (var name in namesStartsWithA)
        {
            var replace = name.Replace("A", "I");
            namesStartsWithI.Add(replace);
        }

        OutputResult(namesStartsWithI);

        return namesStartsWithI;
    }

    public static IEnumerable<string> UnionListsOfNames()
    {
        var firstList = new List<string>() { "Igor", "Vasya", "Alex" };
        var secondList = new List<string>() { "Nikita", "Yura", "Sergey" };

        var names = firstList.Union(secondList).Where(n => n.ElementAt(n.Length - 1) != 'a');

        var reversedNames = names.Reverse();

        OutputResult(reversedNames);

        return reversedNames;
    }

    public static IEnumerable<int> SortNamesByLength()
    {
        var names = new List<string>() { "Brenda", "Kristina", "Anna", "Nik", "Hugo", "Alice", "Selena" };

        var sortedNames = names.OrderBy(n => n.Length);

        var countOfSymbolsList = new List<int>();

        foreach (var name in sortedNames)
        {
            countOfSymbolsList.Add(name.Length);
        }

        OutputResult(countOfSymbolsList);

        return countOfSymbolsList;
    }

    public static IEnumerable<string> FilterProductsListByPrice()
    {
        var productsList = new List<Product>()
        {
            new("Milk", 5422), new("Bread", 1233), new("Cookies", 694), new("Water", 10)
        };

        var result = new List<string>();

        var resultProductsList = productsList.Where(p => p.Price > 1000);

        foreach (var product in resultProductsList)
        {
            result.Add(product.Name);
        }

        OutputResult(result);
        return result;
    }

    public static int CountWords(string text)
    {
        return text.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public static List<string> FizzBuzz()
    {
        var result = new List<string>();
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                result.Add("FizzBuzz");
            else if (i % 3 == 0)
                result.Add("Fizz");
            else if (i % 5 == 0)
                result.Add("Buzz");

            else
            {
                result.Add(i.ToString());
            }
        }

        return result;
    }

    public static void Main()
    {
        //Console.WriteLine("Введите строку: ");
        //Console.WriteLine("Количество слов в строке: " + CountWords(Console.ReadLine()));

        OutputResult(FizzBuzz());

    }
}