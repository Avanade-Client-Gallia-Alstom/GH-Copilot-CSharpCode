using albums_api.Utilis;

namespace albums_nunit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestValidateIPv6Address()
        {
            // Arrange
            string validIPv6Address = "2001:0db8:85a3:0000:0000:8a2e:0370:7334";
            string invalidIPv6Address = "2001:0db8:85a3:0000:0000:8a2e:0370:7334:abcd";

            // Act
            bool isValid1 = Validations.ValidateIPv6Address(validIPv6Address);
            bool isValid2 = Validations.ValidateIPv6Address(invalidIPv6Address);

            // Assert
            Assert.IsTrue(isValid1);
            Assert.IsFalse(isValid2);
        }
        [Test]
        public void TestValidatePhoneNumber()
        {
            // Arrange
            string validPhoneNumber = "+1 (123) 456-7890";
            string invalidPhoneNumber = "123-456-7890";

            // Act
            bool isValid1 = Validations.ValidatePhoneNumber(validPhoneNumber);
            bool isValid2 = Validations.ValidatePhoneNumber(invalidPhoneNumber);

            // Assert
            Assert.IsTrue(isValid1);
            Assert.IsFalse(isValid2);
        }

    }
}