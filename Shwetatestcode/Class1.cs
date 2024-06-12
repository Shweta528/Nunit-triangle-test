using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnitDemonstration;

namespace shwetatestcase
{
    [TestFixture]
    public class Class1
    {
        // Shweta Triangle Test Code
        [Test]
        public void ValidTriangle_Input60and60and60_OutputValidTriangle()
        {
            //Arrange
            int angle1 = 60;
            int angle2 = 60;
            int angle3 = 60;

            string expected = "The triangle is valid.";

            //Act
            string actual = Triangle.ValidTriangle(angle1, angle2, angle3);

            //Assert
            //Assert.Equals(expected, actual);
        }
    }
} 