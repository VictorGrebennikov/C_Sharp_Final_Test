string[] arr = { "1234", "1567", "-2", "computer science"};

string[] FilterFourChar(string[] array)
{
    array = Array.FindAll(array, el => el.Length < 4);
    return array;
}

foreach (string item in FilterFourChar(arr))
{
    Console.WriteLine(item);
}
