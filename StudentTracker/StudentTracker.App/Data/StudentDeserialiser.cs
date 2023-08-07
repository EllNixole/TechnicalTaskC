using StudentTracker.App.Models;
using System.Text.Json;

namespace StudentTracker.App.Data
{
    public class StudentDeserialiser
    {

        public static List<Student> GetStudentList(string filePath)
        {
            try
            {
                string jsonText = File.ReadAllText(filePath);
                List<Student> students = JsonSerializer.Deserialize<List<Student>>(jsonText);
                return students;
            }
            catch (Exception e) 
            {
                Console.WriteLine("Error during deserialisation: " + e.Message);
                return null;
            }
        }

    }
}
