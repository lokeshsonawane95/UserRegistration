using UserRegistration;

namespace UserRegistrationMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Lokesh", "Lokesh")]
        [DataRow("Lo", null)]

        [DataRow("Sonawane", "Sonawane")]
        [DataRow("S", null)]
        public void Name(string a, string expected)
        {
            ValidateForMSTest validate = new ValidateForMSTest();
            string actual = validate.Name(a);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("abc@yahoo.com", "abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc-100@abc.net", "abc-100@abc.net")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
        [DataRow("abc@gmail.com.com", "abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com", "abc+100@gmail.com")]
        public void Email(string a, string expected)
        {
            ValidateForMSTest validate = new ValidateForMSTest();

            string actual = validate.Email(a);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [DataRow("9 9842905050", "9 9842905050")]
        [DataRow("91 9842905050", "91 9842905050")]
        [DataRow("1 1000987267", null)]
        [DataRow("919842905050", null)]
        [DataRow("91 984290", null)]
        public void MobileNumber(string a, string expected)
        {
            ValidateForMSTest validate = new ValidateForMSTest();

            string actual = validate.Mobile(a);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("9D*jkscu", "9D*jkscu")]
        [DataRow("S&dfhkkdkwn", null)]
        [DataRow("123sdf34", null)]
        public void Password(string a, string expected)
        {
            ValidateForMSTest validate = new ValidateForMSTest();

            string actual = validate.Password(a);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GivenUserRegistrationClassNameShouldReturnUserRegistrationObject()
        {
            object expected = new ValidateForMSTest();
            UserRegistrationFactory userRegistrationFactory = new UserRegistrationFactory();
            object actual = userRegistrationFactory.CreateUserRegistration("UserRegistration.ValidateForMSTest", "ValidateForMSTest");
            expected.Equals(actual);
        }

        [TestMethod]
        public void GivenUserRegistrationClassNameShouldReturnObjectUsingParameterizedConstructor()
        {
            object expected = new ValidateForMSTest("message");
            UserRegistrationFactory userRegistrationFactory = new UserRegistrationFactory();
            object actual = userRegistrationFactory.CreateUserRegistrationUsingParameterizedConstructor("UserRegistration.ValidateForMSTest", "ValidateForMSTest", "message");
            expected.Equals(actual);
        }
    }
}