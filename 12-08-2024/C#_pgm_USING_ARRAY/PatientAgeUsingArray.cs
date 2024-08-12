using System;

class PatientAgeUsingArray
{
    static void ReadPatientAgeTillBelowZero()
    {
        // Initial array size
        int initialSize = 10;
        int[] ages = new int[initialSize];
        int count = 0;

        // Read ages until below zero is entered
        int age = 0;
        while (true)
        {
            age = int.Parse(Console.ReadLine());

            if (age < 0) // Stop input condition
            {
                break;
            }
            if (age == 0) // Validation
            {
                Console.WriteLine("Invalid age");
                continue;
            }

            // Resize array if needed
            if (count >= ages.Length)
            {
                Array.Resize(ref ages, ages.Length * 2);
            }

            ages[count++] = age;
        }

        // Initialize statistics variables
        int sum = 0;
        int countOdd = 0;
        int primeSum = 0;
        int teenagerSum = 0;
        int min = int.MaxValue;
        int oddSum = 0;
        bool isMinPrime = false;
        int maxAdult = int.MinValue, secondMaxAdult = int.MinValue;

        // Process the ages from the array
        for (int i = 0; i < count; i++)
        {
            int currentAge = ages[i];
            sum += currentAge;

            if (IsOdd(currentAge)) // Check for odd number ages
            {
                countOdd++;
                oddSum += currentAge;
            }

            if (IsAdult(currentAge)) // Check for adult age
            {
                if (currentAge > maxAdult) // Check for max adult age
                {
                    if (maxAdult != int.MinValue)
                    {
                        secondMaxAdult = maxAdult;
                    }
                    maxAdult = currentAge;
                }
                else if (currentAge > secondMaxAdult && currentAge != maxAdult)
                {
                    secondMaxAdult = currentAge;
                }
            }

            if (IsPrime(currentAge)) // Check for prime ages
            {
                primeSum += currentAge;
            }

            if (IsTeenager(currentAge)) // Check for teenager
            {
                teenagerSum += currentAge;
            }

            if (currentAge < min) // Check for min age
            { 
                min = currentAge;
            }
        }

        isMinPrime = IsPrime(min);

        // Calculate average if count > 0
        int avg = count > 0 ? sum / count : 0;
        Console.WriteLine(count > 0 ? $"Average Age: {avg}" : "No valid ages were entered.");

        // Print statistics
        Console.WriteLine($"Prime Ages Sum: {primeSum}");
        Console.WriteLine($"Teenagers' Age Sum: {teenagerSum}");
        Console.WriteLine($"Min Age: {min}");
        Console.WriteLine($"Odd Age Sum: {oddSum}");
        Console.WriteLine(secondMaxAdult == int.MinValue ? "Second Max Adult Age does not exist" : $"Second Max Adult Age: {secondMaxAdult}");

        Console.WriteLine(isMinPrime ? "Minimum age is also prime." : "Minimum age is not prime.");
    }

    static bool IsPrime(int age)
    {
        if (age < 2) return false;
        int sqrtAge = (int)Math.Sqrt(age);
        for (int i = 2; i <= sqrtAge; i++)
        {
            if (age % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static bool IsTeenager(int age)
    {
        return age >= 13 && age <= 19;
    }

    static bool IsAdult(int age)
    {
        return age > 19;
    }

    static bool IsOdd(int age)
    {
        return age % 2 != 0;
    }

    static void TestReadPatientAgeTillBelowZero()
    {
        ReadPatientAgeTillBelowZero();
    }

    static void Main(string[] args) 
    {
        Console.WriteLine("-----TestReadPatientAgeTillBelowZero-----");
        TestReadPatientAgeTillBelowZero();
        Console.WriteLine("-----End TestReadPatientAgeTillBelowZero-----");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
