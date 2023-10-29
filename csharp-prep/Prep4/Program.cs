using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;

        do 
        {
        Console.WriteLine("Enter numbers to add to a list, when finished enter 0. ");
        userNumber = int.Parse(Console.ReadLine());
        
        numbers.Add(userNumber);

          
        } while (userNumber != 0);

        int total = 0;
    
        foreach (int number in numbers)
        {
            total += number;
        }

        Console.WriteLine($"The total of the list is: {total}");

        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average of the list is: {average}");

        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The largest number you entered was: {largest}");

    }

}