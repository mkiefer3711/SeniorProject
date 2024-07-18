using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeniorProjectGUI;
using System;

namespace TestProject2
{
    [TestClass]
    public class UnitTestForm2
    {
        [TestMethod]
        public void InsertCustomer_ValidInput_ReturnsValidCustomerId()
        {
            // Arrange
            Form2 form2 = new Form2();
            string firstName = "John";
            string lastName = "Doe";
            string email = "john.doe@example.com";
            long phoneNumber = 1234567890;

            // Act
            int customerId = InsertCustomer(firstName, lastName, email, phoneNumber);

            // Assert
            Assert.IsTrue(customerId > 0);
        }
    }
}
