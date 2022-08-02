// See https://aka.ms/new-console-template for more information

namespace CSharp
{

    class Program 
    {
        static void Main(string[] args)
        {
            Student student = new Student("John", "Smith",20);

            Console.WriteLine($"First Name - {student.firstName}");// Excpected outcome: To print
            Console.WriteLine($"Last Name - {student.lastName}"); // Excpected outcome: To print
            // Console.WriteLine($"Age - {student.age}"); // Excpected outcome: Error age is not da de da
            double firstSum = AddNumbers(12.7, 16.35);
            Console.WriteLine($"FirstSum = {firstSum}");
            double secondSum = AddNumbers(9.5, 10);
            Console.WriteLine($"SecondSum = {secondSum}");
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Students s1 = new Students();
            s1.FirstName = "Gary";
            s1.LastName = "Truman";
            s1.Grade = 20;

            Students s2;
            s2 = new Students();
            s2.FirstName = "Joe";
            s2.LastName = "Mama";
            s2.Grade = 21;

            Console.WriteLine($"{s1.FirstName} {s1.LastName} - {s1.Grade}");
            Console.WriteLine($"{s2.FirstName} {s2.LastName} - {s2.Grade}");

            Students s3 = new Students("John", "Hilario", 101);
            Console.WriteLine($"{s3.FirstName} {s3.LastName} - {s3.Grade}");
        }
        public static double AddNumbers(double firstNumber, double secondNumber) => firstNumber + secondNumber; //! If a method does not have a return type the void keyword is the tool for the job
        //* Void is when there is no return for the user
    }
    public class Student //! public is an access modifier. Modifies the access how much can be used in other classes
    {
        public string firstName; //! Public variables can be accessed outside of the class it's stored / Can be used in other classes
        public string lastName;
        // private int age; //! Private variables can only be used in the same class and cannot be mention outside of this class.
        public Student(string firstName, string lastName, int age) //* <visibility> <return type><name>(<parameters>)||Student is contructor
        {
            this.firstName = firstName; //! this. is a Keyword. "The this. keyword refers to the current instance of the class and is also used as a modifier of the first parameter of an extension method." - Microsoft
            this.lastName = lastName; //? Examples on what it does: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/this
            // this.age = age; //! Use this. to qualify the members of the class, instead of the constructor parameters.
        }
    }
    //* To call a function it's: <name>(); || (parameters)

 // The protected Access Modfiers can only be accessed from within the defined class and child classes. The middle ground between public where any class can access it, and privite where it's only within the defined class.
 // Seems to be used for Iheritance and Polymorphism
 // Iternal acess modifier. accessed from within the same assembly?
 // Protected internal makes variables accessible from the child classes within the same assembly from a class which they are actually defined
}
