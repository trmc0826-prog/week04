List<int> readings = new List<int> { 12, 88, 41, 93, 55, 7 };

PrintMatching(readings, IsHighReading);

static void PrintMatching(List<int> values, Func<int, bool> condition)
{
    // TODO: Skriv bare verdier der condition(value) er true.
    foreach (int value in values)
    {
        if (condition(value))
        {
            Console.WriteLine(value);
        }
    }
}

static bool IsHighReading(int value)
{
    // TODO: Definer "high" som minst 60.
    return value >= 60;
}
