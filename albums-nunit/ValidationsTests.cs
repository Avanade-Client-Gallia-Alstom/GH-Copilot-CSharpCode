using NUnit.Framework;
using albums_api.Utilis;

namespace albums_api.Tests.Utilis
{
    public class ValidationsTests
    {
        [Test]
        public void ValidateIPv6Address_ValidIPv6_ReturnsTrue()
        {
            // Arrange
            string ipv6 = "2001:0db8:85a3:0000:0000:8a2e:0370:7334";

            // Act
            bool isValid = Validations.ValidateIPv6Address(ipv6);

            // Assert
            Assert.IsTrue(isValid);
        }

        [Test]
        public void ValidateIPv6Address_InvalidIPv6_ReturnsFalse()
        {
            // Arrange
            string ipv6 = "invalid_ipv6";

            // Act
            bool isValid = Validations.ValidateIPv6Address(ipv6);

            // Assert
            Assert.IsFalse(isValid);
        }

        [Test]
        public void ValidatePhoneNumber_ValidPhoneNumber_ReturnsTrue()
        {
            // Arrange
            string phoneNumber = "123-456-7890";

            // Act
            bool isValid = Validations.ValidatePhoneNumber(phoneNumber);

            // Assert
            Assert.IsTrue(isValid);
        }

        [Test]
        public void ValidatePhoneNumber_InvalidPhoneNumber_ReturnsFalse()
        {
            // Arrange
            string phoneNumber = "invalid_phone_number";

            // Act
            bool isValid = Validations.ValidatePhoneNumber(phoneNumber);

            // Assert
            Assert.IsFalse(isValid);
        }
    }

}
