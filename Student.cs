namespace CSharp
{ //? Structures are faster than classes, and can use them whenever you want to store data.
//* Generally structs are great for game programming
//! They're not the best option for transferring data
//! For example when you're passing data to other classes
// Also structs can have methods, fields, indexers, properties, operator methods, and events
// Structs can also have defined contructors but not destructors
// However you cannot define a default constructor for structs because a default constructor is automattically defined and cannot be changed
//? Structures can implement one or more interfaces.
//! However structures cannot:
//! Inherit from other structures or classes
//! Be used as a base for other structures or classes
//! It's members cannot be specified as abstract, virtual or protected.
        public struct Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }


        public Students(string fName, string lName, int grade)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Grade = grade;
        }

        public void ShowStudent()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Grade}");

        }
        
    }
}