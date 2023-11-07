void ReadNumber(int start, int end)
{
    List<int> numbersList = new();

    while (numbersList.Count != 10)
    {
        
        string input = Console.ReadLine();
        
        try
        {
            bool isNumber = int.TryParse(input, out int currentNumber);

            if (!isNumber)
            {
                throw new ArgumentException("Invalid Number!");
            }

            if ((numbersList.Count == 0 && currentNumber <= 1) || currentNumber >= 100)
            {
                throw new ArgumentException("Your number is not in range 1 - 100!");
            }

            if (numbersList.Count > 0 && numbersList.Last() >= currentNumber || currentNumber >= 100)
            {
                throw new ArgumentException($"Your number is not in range {numbersList.Last()} - 100!");
            }

            numbersList.Add(currentNumber);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    Console.WriteLine(string.Join(", ", numbersList));
}

ReadNumber(1, 100);

