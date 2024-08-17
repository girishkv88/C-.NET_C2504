using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_example
{
    public class Prescription
    {
        public string PrescriptionID { get; set; }
        public int Dosage { get; set; }

        public Prescription(string prescriptionID, int dosage)
        {
            PrescriptionID = prescriptionID;
            Dosage = dosage;
        }

        public bool Equals(Prescription other)
        {
            return this.Dosage == other.Dosage;
        }

        public bool NotEquals(Prescription other)
        {
            return this.Dosage != other.Dosage;
        }

        public bool GreaterThan(Prescription other)
        {
            return this.Dosage > other.Dosage;
        }

        public bool GreaterThanEquals(Prescription other)
        {
            return this.Dosage >= other.Dosage;
        }

        public bool LessThan(Prescription other)
        {
            return this.Dosage < other.Dosage;
        }

        public bool LessThanEquals(Prescription other)
        {
            return this.Dosage <= other.Dosage;
        }
    }
    internal class ProgramTest
    {

        static void Main(string[] args)
        {
            Prescription prescrip1 = new Prescription("RX001", 500);
            Prescription prescrip2 = new Prescription("RX002", 400);

            if (prescrip1.Equals(prescrip2))
            {
                Console.WriteLine($"Prescription1 dosage {prescrip1.Dosage} equals to Prescription2 Dosage {prescrip2.Dosage} is :   ");
            }
            if (prescrip1.GreaterThan(prescrip2))
            {
                Console.WriteLine($"Prescription1 dosage {prescrip1.Dosage} GreaterThan Prescription2 Dosage {prescrip2.Dosage} is :   ");
            }
            if (prescrip1.LessThanEquals(prescrip2))
            {
                Console.WriteLine($"Prescription1 dosage {prescrip1.Dosage} LessThan or Equals to Prescription2 Dosage {prescrip2.Dosage} is :   ");
            }
            if (prescrip1.NotEquals(prescrip2))
            {
                Console.WriteLine($"Prescription1 dosage {prescrip1.Dosage} Not Equals To Prescription2 Dosage {prescrip2.Dosage} is :   ");
            }
            if (prescrip1.LessThan(prescrip2))
            {
                Console.WriteLine($"Prescription1 dosage {prescrip1.Dosage} LessThan Prescription2 Dosage {prescrip2.Dosage} is :   ");
            }
            /*
                        Console.Write($"Prescription1 dosage {prescrip1.Dosage} equals to Prescription2 Dosage {prescrip2.Dosage} is :   ");
                        Console.WriteLine(prescrip1.Equals(prescrip2));
                        Console.Write($"Prescription1 dosage {prescrip1.Dosage} GreaterThan Prescription2 Dosage {prescrip2.Dosage} is :   ");
                        Console.WriteLine(prescrip1.GreaterThan(prescrip2));
                        Console.Write($"Prescription1 dosage {prescrip1.Dosage} LessThan or Equals to Prescription2 Dosage {prescrip2.Dosage} is :   ");
                        Console.WriteLine(prescrip1.LessThanEquals(prescrip2));
                        Console.Write($"Prescription1 dosage {prescrip1.Dosage} Not Equals To Prescription2 Dosage {prescrip2.Dosage} is :   ");
                        Console.WriteLine(prescrip1.NotEquals(prescrip2));
                        Console.Write($"Prescription1 dosage {prescrip1.Dosage} LessThan Prescription2 Dosage {prescrip2.Dosage} is :   ");
                        Console.WriteLine(prescrip1.LessThan(prescrip2));
            */
        }
    }
}

/*OUTPUT
 * Prescription1 dosage 500 GreaterThan Prescription2 Dosage 400 is :
Prescription1 dosage 500 Not Equals To Prescription2 Dosage 400 is :
Press any key to continue . . .

 */





/*OUTPUT2
 Prescription1 dosage 500 equals to Prescription2 Dosage 400 is :   False
Prescription1 dosage 500 GreaterThan Prescription2 Dosage 400 is :   True
Prescription1 dosage 500 LessThan or Equals to Prescription2 Dosage 400 is :   False
Prescription1 dosage 500 Not Equals To Prescription2 Dosage 400 is :   True
Prescription1 dosage 500 LessThan Prescription2 Dosage 400 is :   False
*/
