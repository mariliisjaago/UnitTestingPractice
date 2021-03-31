using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace DemoLibrary.Tests
{
    public class ExampleMethodsTests
    {
        [Fact]
        public void LoadTextFile_ValidNameShouldWork()
        {
            // Act
            string actual = ExampleMethods.LoadTextFile("this is a valid file path");

            // Assert
            Assert.True(actual.Length >= 10);
        }

        //[Fact]
        //public void LoadTextFile_InvalidNameShouldThrowException()
        //{
        //    // Assert
        //    Assert.Throws<FileNotFoundException>(() => ExampleMethods.LoadTextFile("bla"));
        //}

        [Fact]
        public void LoadTextFile_InvalidArgumentShouldThrowException()
        {
            // Assert
            Assert.Throws<ArgumentException>("filePath", () => ExampleMethods.LoadTextFile(""));
        }

        [Theory]
        [InlineData("McChicken", "Chic", "Mc***ken")]
        [InlineData("McBurrito", "Chic", "McBurrito")]
        public void ReturnBleepedString_ShouldBleepOutSubstring(
                                                                string input, 
                                                                string bleepableWord, 
                                                                string expected)
        {
            // Arrange

            // Act
            string actual = ExampleMethods.ReturnBleepedString(input, bleepableWord);

            // Arrange
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnBleepedString_EmptyInputShouldThrowException()
        {
            // Assert
            Assert.Throws<ArgumentException>("input", () => ExampleMethods.ReturnBleepedString("", "duck"));
        }

        [Fact]
        public void ReturnBleepedString_EmptyBleepWordShouldThrowException()
        {
            // Assert
            Assert.Throws<ArgumentException>("bleepedWord", () => ExampleMethods.ReturnBleepedString("McChicken", ""));
        }

    }
}
