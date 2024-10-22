while (true)
{
    try
    {
        // get a number
        Console.Write("Lütfen bir sayı giriniz: ");
        string input = Console.ReadLine();

        // string to double
        double number = double.Parse(input);

        // calculate the square of the number
        double square = number * number;
        Console.WriteLine($"Girdiğiniz sayının karesi: {square}");

        // exit loop
        break;
    }
    catch (FormatException) // FormatException: When an incorrect format is used when trying to convert a string
    {
        // if user enter an invalid input, an error message is display
        Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
    }
}

