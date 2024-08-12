using System;

class PatientTemperatureUsingArray
{
    static void ReadPatientTemperatureTillZero()
    {
        // Initial array size
        int initialSize = 10;
        int[] temperatures = new int[initialSize];
        int count = 0;

        // Read temperatures until 0 is entered
        int temperature = 0;
        while (true)
        {
            temperature = int.Parse(Console.ReadLine());

            if (temperature == 0) // Stop input condition
            {
                break;
            }
            if (temperature < 0) // Validation
            {
                Console.WriteLine("Invalid temperature");
                continue;
            }

            // Resize array if needed
            if (count >= temperatures.Length)
            {
                Array.Resize(ref temperatures, temperatures.Length * 2);
            }

            temperatures[count++] = temperature;
        }

        // Initialize statistics variables
        int sum = 0;
        int countOdd = 0;
        int primeSum = 0;
        int min3DigitsTemperatureSum = 0;
        int min = int.MaxValue;
        int oddSum = 0;
        bool isMinPrime = false;
        int maxOdd = int.MinValue, secondMaxOdd = int.MinValue;

        // Process the temperatures from the array
        for (int i = 0; i < count; i++)
        {
            int currentTemperature = temperatures[i];
            sum += currentTemperature;

            if (IsOdd(currentTemperature)) // Check for odd number temperatures
            {
                countOdd++;
                oddSum += currentTemperature;

                if (currentTemperature > maxOdd) // Check for max odd temperature
                {
                    if (maxOdd != int.MinValue)
                    {
                        secondMaxOdd = maxOdd;
                    }
                    maxOdd = currentTemperature;
                }
                else if (currentTemperature > secondMaxOdd && currentTemperature != maxOdd)
                {
                    secondMaxOdd = currentTemperature;
                }
            }

            if (IsPrime(currentTemperature)) // Check for prime temperatures
            {
                primeSum += currentTemperature;
            }

            if (IsMinThreeDigits(currentTemperature)) // Check for min three-digit temperatures
            {
                min3DigitsTemperatureSum += currentTemperature;
            }

            if (currentTemperature < min) // Check for min temperature
            {
                min = currentTemperature;
            }
        }

        isMinPrime = IsPrime(min);

        // Calculate average if count > 0
        int avg = count > 0 ? sum / count : 0;
        Console.WriteLine(count > 0 ? $"Average Temperature: {avg}" : "No valid temperatures were entered.");

        // Print statistics
        Console.WriteLine($"Prime Temperatures Sum: {primeSum}");
        Console.WriteLine($"Min 3 Digits Temperature Sum: {min3DigitsTemperatureSum}");
        Console.WriteLine($"Min Temperature: {min}");
        Console.WriteLine($"Odd Temperature Sum: {oddSum}");
        Console.WriteLine(secondMaxOdd == int.MinValue ? "Second Max Odd Temperature does not exist" : $"Second Max Odd Temperature: {secondMaxOdd}");

        Console.WriteLine(isMinPrime ? "Minimum temperature is also prime." : "Minimum temperature is not prime.");
    }

    static bool IsPrime(int temperature)
    {
        if (temperature < 2) return false;
        int sqrtTemperature = (int)Math.Sqrt(temperature);
        for (int i = 2; i <= sqrtTemperature; i++)
        {
            if (temperature % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static bool IsMinThreeDigits(int temperature)
    {
        return temperature >= 100;
    }

    static bool IsOdd(int temperature)
    {
        return temperature % 2 != 0;
    }

    static void TestReadPatientTemperatureTillZero()
    {
        ReadPatientTemperatureTillZero();
    }

    static void Main(string[] args) 
    {
        Console.WriteLine("-----TestReadPatientTemperatureTillZero-----");
        TestReadPatientTemperatureTillZero();
        Console.WriteLine("-----End TestReadPatientTemperatureTillZero-----");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
