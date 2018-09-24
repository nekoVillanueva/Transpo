using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Test
{
    [TestFixture]
    class TranspoTest
    {
        [Test]
        public void GetMake()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            testTranspo.GetMake = "Ford";
            string response = testTranspo.GetMake;

            //assert
            Assert.That(response, Is.EqualTo("Ford"));


        }
        [Test]
        public void GetModel()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            testTranspo.GetModel = "Bronco";
            string response = testTranspo.GetModel;

            //assert
            Assert.That(response, Is.EqualTo("Bronco"));


        }
        [Test]
        public void GetYear()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            testTranspo.GetYear = "1965";
            string response = testTranspo.GetYear;

            //assert
            Assert.That(response, Is.EqualTo("1965"));


        }
        [Test]
        public void GetNumWheels()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            testTranspo.GetNumWheels= "4";
            string response = testTranspo.GetNumWheels;

            //assert
            Assert.That(response, Is.EqualTo("4"));


        }
        [Test]
        public void GetColor()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            testTranspo.GetColor = "red";
            string response = testTranspo.GetColor;

            //assert
            Assert.That(response, Is.EqualTo("red"));


        }
        [Test]
        public void GetEngineSize()
        {
            //arrange
            Transpo testTranspo = new Transpo();

            //action
            testTranspo.GetEngineSize = "351";
            string response = testTranspo.GetEngineSize;

            //assert
            Assert.That(response, Is.EqualTo("351"));


        }
        [Test]
        public void GetMph()
        {
            Transpo testTranspo = new Transpo();

            //action
           
            int response = testTranspo.GetMph(55);

            //assert
            Assert.That(response, Is.EqualTo(55));





        }
        [Test]
        public void GetMpg()
        {
            Transpo testTranspo = new Transpo();

            //action
           
            int response = testTranspo.GetMpg(55,11);

            //assert
            Assert.That(response, Is.EqualTo(605));




        }
        [Test]
        public void GetWear()
        {
            //Arrange
            Transpo testTranspo = new Transpo();
            //action
            string response = testTranspo.GetWear(0, 0,0);
            //assert
            Assert.That(response, Is.EqualTo("Invalid Entry"));
        }
        [Test]
        public void GetWear_if_miles_div_heat_is_less_than_50_percent_tread_return_unsafe()
        {
            //Arrange
            Transpo testTranspo = new Transpo();
            //action
            string response = testTranspo.GetWear(20, 85,32);
            //assert
            Assert.That(response, Is.EqualTo("unsafe"));
        }
        [Test]
        public void GetWear_if_miles_div_heat_is_greater_than_50_percent_tread_return_unsafe()
        {
            //Arrange
            Transpo testTranspo = new Transpo();
            //action
            string response = testTranspo.GetWear(1500, 85, 32);
            //assert
            Assert.That(response, Is.EqualTo("safe"));
        }
    }
}
