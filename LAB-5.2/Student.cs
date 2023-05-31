using System;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;


namespace struct_lab_student
{
    public struct Student
    {
        public string surName;
        public string firstName;
        public string patronymic;
        public char sex;
        public string dateOfBirth;
        public char mathematicsMark;
        public char physicsMark;
        public char informaticsMark;
        public int scholarship;

        public Student(string lineWithAllData)
        {
            // TODO   you SHOULD IMPLEMENT constructor with exactly this signature
            // lineWithAllData is string contating all data about one student, as described in statement
            lineWithAllData = Regex.Replace(lineWithAllData, "\\s+", " ");
            string[] line = lineWithAllData.Trim().Split();
            surName = line[0];
            firstName = line[1];
            patronymic = line[2];
            sex = Checking.CheckSex(line[3]);
            dateOfBirth = (line[4]);
            mathematicsMark = Checking.CheckMark(line[5]);
            physicsMark = Checking.CheckMark(line[6]);
            informaticsMark = Checking.CheckMark(line[7]);
            scholarship = Checking.CheckScholarship(line[8]);
        }
    }
}
