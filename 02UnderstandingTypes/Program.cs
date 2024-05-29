
namespace Assignment1 {
    class NumberData {
        /// <summary>
        /// Prints a table of number types, bytes of storage, minimum value of number type, and maximum
        /// value of number type.
        /// </summary>
        public static void PrintNumberTypesAndDetails() {            

            string formatString = "{0,-15} {1,-8} {2,-30} {3,-30}";

            Console.WriteLine(formatString, "Number Type", "Bytes", "Minimum Value", "Maximum Value");
            Console.WriteLine(formatString, "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine(formatString, "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
            Console.WriteLine(formatString, "short", sizeof(short), short.MinValue, short.MaxValue);
            Console.WriteLine(formatString, "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            Console.WriteLine(formatString, "int", sizeof(int), int.MinValue, int.MaxValue);
            Console.WriteLine(formatString, "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
            Console.WriteLine(formatString, "long", sizeof(long), long.MinValue, long.MaxValue);
            Console.WriteLine(formatString, "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            Console.WriteLine(formatString, "float", sizeof(float), float.MinValue, float.MaxValue);
            Console.WriteLine(formatString, "double", sizeof(double), double.MinValue, double.MaxValue);
            Console.WriteLine(formatString, "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);

        }
        /// <summary>
        /// Prints a representation of time equivalencies based on the number of centuries entered.
        /// </summary>
        /// <param name="centuries">The number of centuries to get a time equivalency.</param>
        public static void PrintRepresentationOfCenturies(int centuries)
        {
            long years = centuries * 100L;
            long days = (long)Math.Floor(years * 365.242199D);
            long hours = days * 24L;
            decimal minutes = hours * 60M;
            decimal seconds = minutes * 60M;
            decimal milliseconds = seconds * 1000M;
            decimal microseconds = milliseconds * 1000M;
            decimal nanoseconds = microseconds * 1000M;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");

        }
    }
    class Program {
        public static void Main(string[] args) {

            //Question 1:
            //Output the number of bnumber of bytes in memory that each of the following number types uses, and the
            //  minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
            //  ulong, float, double, and decimal
            NumberData.PrintNumberTypesAndDetails();

            Console.WriteLine("\n\n\n");

            //Question 2:
            //Write program to enter an integer number of centuries and convert it to years, days, hours,
            //  minutes, seconds, milliseconds, microseconds, nanoseconds.Use an appropriate data
            //  type for every data conversion.Beware of overflows!
            int n;
            string input;
            do
            {
                Console.Write("Input: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out n));
            NumberData.PrintRepresentationOfCenturies(n);

        }
    }
}