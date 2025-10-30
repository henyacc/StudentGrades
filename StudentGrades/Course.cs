using System.ComponentModel.Design;

namespace StudentGrades;

public class Course
{
    public string CourseName { get; set; } = "";
    public int CourseCode { get; set; } = 0;

    private List<string> enrolledStudents;

    public Course()
    {
        enrolledStudents = new List<string>();
    } 
    
    public bool EnrolledStudent(string studentName)
    {
        if (!enrolledStudents.Contains(studentName))
        {
            enrolledStudents.Add(studentName);
            return true;
        }
        else
        {
            return false;
        }
    }

    public Course Programming = new Course();
    
    public string Name { get; set; }
    public string Description { get; set; }
    public int Credits { get; set; }

    public void AddCourse(string courseName)
    {
        CourseName = courseName;
        Description = Description;
        Credits = 0;
    }
    
    private void AddStudents(string studentsName)
    {
        AddStudents(studentsName);
    }
    
    public void DisplayCourseInfo()
    {
        Programming.AddStudents("Sharah");
        Programming.AddStudents("David");
        
    }
    
        
        
        
        
        
        
    
    


}
    