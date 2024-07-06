using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstApplication;

namespace MyFirstTestProject
{
    [TestClass]
    public class Lesson10Test
    {
        [TestMethod]
        public void FirstName_LastName_ZipCode_Verify()
        {
            // arrange
            string firstName = "George";
            string lastName = "Washington";
            int zipCode = 64119;
            Lesson10 myLesson10 = new Lesson10(firstName, lastName, zipCode);

            // act - nothing for this one

            // assert
            /*Assert.AreEqual(firstName, myLesson10.FirstName);
            Assert.AreEqual(lastName, myLesson10.LastName);
            Assert.AreEqual(zipCode, myLesson10.ZipCode);*/

        }

        [TestMethod]
        public void IdVerify()
        {
            // arrange
            int id = 1234;
            Lesson10 lab18 = new Lesson10(id);


            // assert
            Assert.AreEqual(id, lab18.Id);
        }
    }
}