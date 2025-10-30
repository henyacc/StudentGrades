namespace StudentGrades;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        List<Student> students = new List<Student>();
        student.CalculateAverageGrade();

        Student student1 = new Student()
        {
            StudentId = 1,
            Grades = [90.1, 88.7, 100, 97.6],
            Name = "Sharah"
        };
        
        student1.AddGrade(90.8);
        
        Student student2 = new Student();// dot notation, made a new instance of the class (blueprint)
        student2.StudentId = 2; //dotted down into that class which holds the variable student1, to reach the StudentId property
        student2.Grades = [88.8, 90.6];
        student2.Name = "Michael";
        
        student2.AddGrade(88.7);
        
        Student student3 = new Student();
        student3.StudentId = 3;
        student3.Grades = [98.2, 67.7, 55.5];
        student3.Name = "David";
        
        student3.AddGrade(100);

        Student student4 = new Student();
        student4.StudentId = 4;
        student4.Grades = [84.5, 85.9, 78.6];
        student4.Name = "John";
        
        student4.AddGrade(85.9);
        
        students.AddRange([student1, student2, student3, student4]);//add range for adding mutiple elements to a list

        foreach (Student item in students)
        {
            Console.WriteLine($"Name: {item.Name}");
            Console.WriteLine($"Student ID: {item.StudentId}");
            Console.WriteLine("Grades:");

            foreach (double grade in item.Grades)
            {
                Console.WriteLine(grade);
            }
            
            
            Console.WriteLine("Average grade:");
            Console.WriteLine(Math.Round(item.CalculateAverageGrade(), 2));
            Console.WriteLine();
            
            
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        
    }
}