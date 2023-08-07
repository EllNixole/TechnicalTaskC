namespace StudentTracker.App.Models
{
    public class Student
    {

        public string Name { get; set; }

        public String University { get; set; }

        public string Major { get; set; }

        public int Id { get; set; }

        public Dictionary<string, double> Grades { get; set; }

        public Dictionary<string, double> Attendance { get; set; }

    }
}
