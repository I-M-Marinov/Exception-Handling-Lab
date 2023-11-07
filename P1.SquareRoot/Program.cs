int number = int.Parse(Console.ReadLine());

try
{
    if (number < 0)
    {
        throw new ArgumentException("Invalid number.");
    }
    Console.WriteLine($"{Math.Sqrt(number)}");
}
catch (ArgumentException argEx)
{
    Console.WriteLine($"{argEx.Message}");
}
finally
{
    Console.WriteLine("Goodbye.");
}