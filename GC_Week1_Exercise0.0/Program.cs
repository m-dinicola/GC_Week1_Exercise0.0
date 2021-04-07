using System;

namespace GC_Week1_Exercise0._0
{
    class Program
    {
        static void Main(string[] args)
        {
            uint age, offset; // unsigned to allow TryParse to handle validity testing
            Console.Write("Please enter your name: ");
            string name=Console.ReadLine();
            Console.Write("Please enter your age (numerical positive integer): ");
            while (!uint.TryParse(Console.ReadLine(), out age))  //will repeat read/write until TryParse resolve
            {
                Console.Write("Invalid. Enter a valid age, please: ");
            }
            Console.Write("How far in the future (positive integer yrs) do you wish to look? ");
            while (!uint.TryParse(Console.ReadLine(), out offset)) //same as previous loop
            {
                Console.Write("Invalid. Enter a valid future offset, please: ");
            }
            age += offset;
            string ageUnits = (age == 1) ? " year" : " years";     //creating units string to handle plurals
            string offsetUnits = (offset == 1) ? " year" : " years";  //same as above
            Console.WriteLine(name + ", I have peered through the veil of time... \n" +  //putting it all together
                                     "...you will be " + age + ageUnits +" old in " +
                                     offset + offsetUnits+"... IF YOU ARE LIVING!");
        }
    }
}
