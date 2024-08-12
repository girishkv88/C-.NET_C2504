class DoctorSalary_UsingArray 
{
    static void ReadDoctorSalaryTillMinus1()
    {
        int[] salaries = new int[100]; // Initial array size
        int count = 0;
        int countOdd = 0;
        int sum = 0;
        int primeCount = 0;
        int minFourDigitsCount = 0;
        int oddSum = 0;
        int minOdd = int.MaxValue, secondMinOdd = int.MaxValue;

        int salary = 0;
        do
        {
            salary = int.Parse(Console.ReadLine());

            if (salary == -1) // Stop input condition
            {
                break;
            }
            if (salary < 0) // Validation
            {
                Console.WriteLine("Invalid salary");
                continue;
            }

            // Check if array needs resizing
            if (count == salaries.Length)
            {
                Array.Resize(ref salaries, salaries.Length * 2); // Double the size of the array
            }

            // Store the salary in the array
            salaries[count] = salary;
            count++;

            if (IsOdd(salary)) // Check for odd number salaries
            {
                countOdd++;
                oddSum += salary;

                if (salary < minOdd) // Check for minimum odd salary
                {
                    if (minOdd != int.MaxValue) 
                    { 
                        secondMinOdd = minOdd;
                    }
                    minOdd = salary;                           
                }
                else if (salary < secondMinOdd && salary != minOdd)
                {
                    secondMinOdd = salary;
                }
            }

            sum += salary;

            if (IsPrime(salary)) // Check for prime salaries
            {
                primeCount++;
            }

            if (IsMinimumFourDigits(salary)) // Check for 4-digit salaries
            {
                minFourDigitsCount++;
            }
        } while (salary != -1);

        if (count > 0)
        {
            int max = salaries[0];
            for (int i = 1; i < count; i++) // Find the maximum salary
            {
                if (salaries[i] > max)
                {
                    max = salaries[i];
                }
            }

            bool isMaxPrime = IsPrime(max);
            int avg = sum / count; // Find average salary

            Console.WriteLine($"Average Salary: {avg}");
            Console.WriteLine($"Prime Salaries#: {primeCount}");
            Console.WriteLine($"Min Four Digits Salaries#: {minFourDigitsCount}");
            Console.WriteLine($"Max Salary#: {max}");
            Console.WriteLine($"Odd Salaries Sum#: {oddSum}");
            Console.WriteLine($"Min Odd Salary#: {minOdd}");
            if (secondMinOdd == int.MaxValue)
            { 
                Console.WriteLine("Second Min Odd Salary does not exist");
            }
            else
            {
                Console.WriteLine($"Second Min Odd Salary#: {secondMinOdd}");
            }
            
            if (isMaxPrime) // Check if maximum salary is prime
            {
                Console.WriteLine("Maximum salary is also prime");
            }
            else
            {
                Console.WriteLine("Maximum salary is not prime");
            }
        }
        else
        {
            Console.WriteLine("No valid salaries were entered.");
        }
    }

    static bool IsPrime(int salary)
    {
        if (salary < 2) return false;
        int sqrtSal = (int)Math.Sqrt((double)salary);
        for (int i = 2; i <= sqrtSal; i++)
        {
            if (salary % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static bool IsMinimumFourDigits(int salary)
    {
        return salary >= 1000;
    }

    static bool IsOdd(int salary)
    {
        return salary % 2 != 0;
    }

    static void TestReadDoctorSalaryTillMinus1()
    {
        ReadDoctorSalaryTillMinus1();
    }

    static void Main(string[] args) 
    {
        Console.WriteLine("-----TestReadDoctorSalaryTillMinus1-----");
        TestReadDoctorSalaryTillMinus1();
        Console.WriteLine("-----End TestReadDoctorSalaryTillMinus1-----");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
