using TeachMeSkills;

void OutputResult<T>(IEnumerable<T> list)
{
    foreach (var num in list)
    {
        Console.WriteLine(num);
    }
}

void GetPositiveTwoDigitNumbers()
{
    var list = new List<int>() {11, -21, 64, 59, 11, 0, -7, 53, -31, 1};

    var result = list.Where(t => t >= 10 && t <= 99).Order();

    OutputResult(result);
}

void GetEvenNumbers()
{
    var list = new List<int> { 11, 23, 60, 57, 62, 17, 42, 34, 123 };

    var result = list.Where(t => t % 2 == 0);

    OutputResult(result);
}

void Reverse()
{
    var word = "automation";

    Console.WriteLine(word.Reverse().ToArray());
}

void ChangeFirstLetter()
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
}

void UnionListsOfNames()
{
    var firstList = new List<string>() { "Igor", "Vasya", "Alex" };
    var secondList = new List<string>() { "Nikita", "Yura", "Sergey" };

    var names = firstList.Union(secondList).Where(n => n.ElementAt(n.Length - 1) !=  'a');

    var reversedNames = names.Reverse();

    OutputResult(reversedNames);
}

void SortNamesByLength()
{
    var names = new List<string>() { "Brenda", "Kristina", "Anna", "Nik", "Hugo", "Alice", "Selena" };

    var sortedNames = names.OrderBy(n => n.Length);

    var countOfSymbolsList = new List<int>();

    foreach (var name in sortedNames)
    {
        countOfSymbolsList.Add(name.Length);
    }

    OutputResult(countOfSymbolsList);
}

void FilterProductsListByPrice()
{
    var productsList = new List<Product>()
    {
        new Product("Milk", 5422), new Product("Bread", 1233), new Product("Cookies", 694), new Product("Water", 10)
    };

    var result = new List<string>();

    var resultProductsList = productsList.Where(p => p.Price > 1000);

    foreach (var product in resultProductsList)
    {
        result.Add(product.Name);
    }

    OutputResult(result);

}

FilterProductsListByPrice();
