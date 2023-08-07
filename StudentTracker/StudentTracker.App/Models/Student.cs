using Newtonsoft.Json;

namespace StudentTracker.App.Models
{
    public class Student
    {
        public string Name { get; set; }

        public string University { get; set; }

        public string Major { get; set; }

        [JsonProperty("student_id")]
        public string Id { get; set; }

        public Grades Grades { get; set; }

        public Attendance Attendance { get; set; }
    }
}
