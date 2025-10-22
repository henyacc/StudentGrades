namespace StudentGrades;

public class Student
{
    public string Name { get; set; } = "";
    public int StudentId { get; set; } = 0;
    public List<double> Grades { get; set; } = [];


    public void AddGrade(double grade)
    {
        Grades.Add(grade);

    }

    public void AddGrade(params double[] grades)
    {
        Grades.AddRange(grades);
    }

    public double CalculateAverageGrade()
    {
        double sum = Grades.Any() ? Grades.Average() : 0;
        return sum;
    }

}