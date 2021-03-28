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

        [Fact]
        public void LoadTextFile_InvalidNameShouldThrowException()
        {
            // Assert
            Assert.Throws<FileNotFoundException>(() => ExampleMethods.LoadTextFile("bla"));
        }
    }
}
