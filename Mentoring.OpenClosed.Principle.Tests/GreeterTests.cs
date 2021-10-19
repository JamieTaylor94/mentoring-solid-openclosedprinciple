using NUnit.Framework;

namespace Mentoring.OpenClosed.Principle.Tests
{
    public class GreeterTests
    {
        [Test]
        public void Greeter_ReturnsHello()
        {
            // Arrange 
            var greeter = new Greeter();
            
            // Act
            var result = greeter.Greet(Language.English);
            
            // Assert
            Assert.AreEqual("Hello", result);
        }

        [Test]
        public void Greeter_InFrench_ReturnsHello()
        {
            // Arrange 
            var greeter = new Greeter();

            // Act
            var result = greeter.Greet(Language.French);

            // Assert
            Assert.AreEqual("Bonjour", result);
        }

        [Test]
        public void Greeter_InSpanish_ReturnsHello()
        {
            // Arrange 
            var greeter = new Greeter();

            // Act
            var result = greeter.Greet(Language.Spanish);

            // Assert
            Assert.AreEqual("Hola", result);
        }

        [Test]
        public void Greeter_InItalian_ReturnsHello()
        {
            // Arrange 
            var greeter = new Greeter();

            // Act
            var result = greeter.Greet(Language.Italian);

            // Assert
            Assert.AreEqual("Ciao", result);
        }
    }
}