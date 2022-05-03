

for (var idx = 1; idx <= 30; idx++)
    {
    if ((idx % 3 == 0) && (idx % 5 == 0))
        Console.WriteLine($"Fizzbuzz, {idx}");

    else if (idx % 3 == 0)
        Console.WriteLine($"Fizz, {idx}");

    else if (idx % 5 == 0)
        Console.WriteLine($"Buzz, {idx}");
    else
        Console.WriteLine($"{idx}");
    }


