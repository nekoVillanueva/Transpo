using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Test
{
    [TestFixture]
    class MotorcycleTests
    {
        [Test]
        public void CreateCycle()
        {
            //arrange
            Cycle testCycle = new Cycle();
            //Action
            testCycle.GetMake = "BMW";

            string response = testCycle.GetMake;
            //Assert
            Assert.That(response, Is.EqualTo("BMW"));

        }

    }
}
