using System;

namespace SubstringDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Substring method parses a string starting from an index which is given
             * through the parameters and by defuault goes to the last index in the string
             * Can also be overloaded and given 2 parameters where the second one will specify 
             * how long the string will parse from the beginning index
             * if the 2nd parameter causes the parsing to exceed the length of the string,
             * will throw an out of bounds exception
             */

            string example = "Pack my box with five liqour jugs";
            string test1 = example.Substring(22);
            string test2 = example.Substring(22,6);
            Console.WriteLine(example);
            Console.WriteLine(test1);
            Console.WriteLine(test2);

            // Real life example
            // extracting area code of a Phone Number

            string phoneNumber = "345-324-3245";
            string areaCode = phoneNumber.Substring(0, 3);
            Console.WriteLine();
            Console.WriteLine(phoneNumber);
            Console.WriteLine(areaCode);
        }
    }
}
