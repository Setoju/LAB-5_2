using System.Text.RegularExpressions;

namespace struct_lab_student
{
    public class Lab
    {
        static Student[] ReadData(string fileName)
        {
            // TODO   implement this method.
            // It should read the file whose fileName has been passed and fill data inside array of Student            

            string[] lines = File.ReadAllLines(fileName);
            Student[] students = new Student[lines.Length];                        
            for (int i = 0; i < lines.Length; i++)
            {
                
                students[i] = new Student(lines[i]);
            }
            return students;
        }

        public static string[] runMenu(Student[] studs)
        {
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int counter = 0;
            string[] result = new string[studs.Length];
            for (int i = 0;i < studs.Length; i++)
            {
                int dateOfBirth = Convert.ToInt32(Regex.Replace(studs[i].dateOfBirth, "\\.", ""));
                int age = (now - dateOfBirth) / 10000;
                if (age >= 18)
                {
                    counter++;
                    string line = $"{studs[i].surName} {studs[i].firstName} {studs[i].patronymic}";
                    Console.WriteLine($"{studs[i].surName} {studs[i].firstName} {studs[i].patronymic}");
                    result[i] = line;
                }
            }
            Array.Resize(ref result, result.Length);            
            return result;
        }

        static void Main(string[] args)
        {
            Student[] studs = ReadData("file.txt");
            runMenu(studs);
        }
    }
}
