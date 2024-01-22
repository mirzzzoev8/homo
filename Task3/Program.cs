var st1 = new Student();
st1.Name = "Yusufjon";
st1.SurName = "Mirzoev";
st1.GradeLevel = 9;
st1.TestScores = new List<double>(){100,100,100,100};

var st2 = new Student();
st2.Name = "Davron";
st2.SurName = "Ziyoyev";
st2.GradeLevel = 9;
st2.TestScores = new List<double>(){0,90,80,100};

var st3 = new Student();
st3.Name = "Mustafo";
st3.SurName = "Barotov";
st3.GradeLevel = 9;
st3.TestScores = new List<double>(){50,100,90,20};

var st4 = new Student();
st4.Name = "Alijoni";
st4.SurName = "Zabiri";
st4.GradeLevel = 9;
st4.TestScores = new List<double>(){84,84,84,84};

var st5 = new Student();
st5.Name = "Ziyoartsho";
st5.SurName = "Jononov";
st5.GradeLevel = 9;
st5.TestScores = new List<double>(){100,100,100,100};
var students =  new List<Student>();
students.Add(st1); 
students.Add(st2); 
students.Add(st3); 
students.Add(st4); 
students.Add(st5); 
foreach (var student in students)
{
    var average = student.AverageScores();
    if(average >= 85) System.Console.WriteLine($" Congratulations {student.FullName} on achieving above average scores ({average}) in grade {student.GradeLevel} !  Keep up the good work!   ");
    else if(average >= 70 && average < 85 ) System.Console.WriteLine($"  {student.FullName} if you're having difficulties with your studies, don't hesitate to  seek help. Your current average score is   ({average}) in grade {student.GradeLevel} !  ");

}




class Student 
{
    public string Name;
    public string SurName;
    public int GradeLevel;
    public List<double> TestScores ;  
    public double AverageScores()
    {
        double sum = 0;
        foreach (var score in TestScores)
        {
            sum+=score;
        }
        return sum/TestScores.Count;
    }
    public string FullName()
    {
        return $"{Name} {SurName}";
    }
}