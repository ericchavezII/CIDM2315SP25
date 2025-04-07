
using System.Linq;

namespace HW9
{
    class Program
    {
        static void Main(string[] args)
        {
            Student alice = new Student(111, "Alice");
            Student bob = new Student(222, "Bob");
            Student cathy = new Student(333, "Cathy");
            Student david = new Student(444, "David");

            foreach (var student in Student.student_list)
            {
                student.PrintInfo();
            }

            Dictionary<string, double> gradebook = new Dictionary<string, double>();

            gradebook.Add("Alice", 4.0);
            gradebook.Add("Bob", 3.6);
            gradebook.Add("Cathy", 2.5);
            gradebook.Add("David", 1.8);

            if (!gradebook.ContainsKey("Tom"))
            {
                gradebook.Add("Tom", 3.3);
                Console.WriteLine("Tom was added to the grade book");
            }
            else
            {
                Console.WriteLine("Tom is already in the gradebook");
            }

            Console.WriteLine("\nGradebook");
            foreach (KeyValuePair<string, double> kvp in gradebook)
            {
                Console.WriteLine($"name: {kvp.Key} , GPA: {kvp.Value}");
            }

            double averageGPA = gradebook.Values.Average();
            Console.WriteLine($"\n Average GPA: {averageGPA}");

            Console.WriteLine("\nStudents with GPA greater than average:");
            foreach (KeyValuePair<string, double> kvp in gradebook)
            {
                if (kvp.Value > averageGPA)
                {
                    Student student = Student.student_list.Find(s => s.StuName.ToLower() == kvp.Key.ToLower()); // Corrected line 47
                    if (student != null)
                    {
                        student.PrintInfo();
                        Console.WriteLine($"GPA: {kvp.Value}");
                    }
                }
            }
        }
    }

    class Student
    {
        public static List<Student> student_list = new List<Student>();
        public int StuID { get; set; }
        public string StuName { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Student ID: {StuID} , Student Name: {StuName}");
        }

        public Student(int inputID, string inputName)
        {
            StuID = inputID;
            StuName = inputName;
            student_list.Add(this);
        }
    }
}
// ( chatgpt , april 1 , why wont the two students with the higher than avg gpa print out)