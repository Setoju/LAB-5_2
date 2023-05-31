using Microsoft.VisualStudio.TestPlatform.TestHost;
using struct_lab_student;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void RightInputFormat()
        {
            Student[] student = new Student[1];
            student[0] = new Student("Hlushchenko Yevhenii Ruslanovich M 07.05.2005 5 5 5 1980");
            string expected = "Hlushchenko Yevhenii Ruslanovich";

            string actual = Lab.runMenu(student)[0];
            
            Assert.AreEqual(expected, actual, "Program is messed up :)");
        }
        [TestMethod]
        public void ManySpaces()
        {
            Student[] student = new Student[1];
            student[0] = new Student("Hlushchenko            Yevhenii               Ruslanovich M      07.05.2005 5 5 5 1980");
            string expected = "Hlushchenko Yevhenii Ruslanovich";

            string actual = Lab.runMenu(student)[0];

            Assert.AreEqual(expected, actual, "Program is messed up :)");
        }
        [TestMethod]
        public void DifferentChoices()
        {
            Student[] student = new Student[1];
            student[0] = new Student("Hlushchenko Yevhenii Ruslanovich × 07.05.2005 5 5 5 1980");
            string expected = "Hlushchenko Yevhenii Ruslanovich";

            string actual = Lab.runMenu(student)[0];

            Assert.AreEqual(expected, actual, "Program is messed up :)");
        }               
        [TestMethod]
        public void AccurateBirthDate()
        {
            Student[] student = new Student[1];
            student[0] = new Student("Hlushchenko Yevhenii Ruslanovich M 25.05.2005 5 5 5 1980");
            string expected = null;

            string actual = Lab.runMenu(student)[0];

            Assert.AreEqual(expected, actual, "Program is messed up :)");
        }
    }
}