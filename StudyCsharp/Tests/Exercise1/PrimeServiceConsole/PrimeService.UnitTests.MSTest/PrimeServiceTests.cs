using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


/*
 * Assert used in a code which implements testing
 * I have a project which has a service for example primeservice
 * PrimeService has methods -> Thesemethods i want to testing
 * MS -> Microsoft test -> .MSTest means testing
 * One direction only we can use One project into another
 * PrimeServiceConsole to PrimeService.UnitTests.MSTest only
 * I get Assembly of PrimeServiceConsole and give the ability to above to use it
 * 
 * Test Unit are simple classes, which contains Objects from the classes which i want to test for example in this case
 * PrimeServiceConsole.PrimeService
 * I don't create Objects of PrimeServiceTest onyl MSTests do this
 * 
 * I create a project -> do compile -> this named assembly
 * assembly can ran under CLR -> Common Language Runtime
 * c# -> i can run in fsharp, visual basic this is CLR... .Net framework give them to me
 * I can have assemblies from project in the same solution
 * 
 * mstest, nunit, xunit
 * 
 * with ADD References i have all public
 * I want to have class with class
 * I want to have class with class
 * I want to have class with class
 * I want to have class with class
 * I want to have class with class
 * I want to have class with class
 * I want to have class with class
 * I want to have class with class
 * I want to have class with class
 * Bold Project is the start up project
 * Right Click Set as start up project
 * A test for MStest is Class Library can't use with the hit of run
 * this assembly i can take and use it some other position
 * Class Library is a non executable program have extension.dll
 * 
 * All debug become if i do release i have a folder release
 * 
 * PrimeService.UnitTests.MSTest -> bin -> debug ... I don't have .exe i have dll
 * 
 * Console Application -> .exe
 * Class Library Projects -> dll (dynamic Link Library)
 * 
 * PlayList File define the way of tests execution
 * 
 * [TestMethod] -> Inside has a try catch and if throw exception will do try catch on it in order to have a result on test explorer
 * 
 * I can have multiple asserts in a method
 */
namespace PrimeService.UnitTests.MSTest
{
    [TestClass] // annotation 4.x or attributes .Net Core 3.2 LTS or .NET 5+
    public class PrimeServiceTests
    {
        // Namespace.Class 
        private readonly PrimeServiceConsole.PrimeService _primeService;

        public PrimeServiceTests()
        {
            _primeService = new PrimeServiceConsole.PrimeService();
        }

        [TestMethod]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrime(1);
            
            Assert.IsFalse(result, "1 should not be prime.");
        }

        [TestMethod]
        public void ReturnFalseGivenNegativeValueOrZero()
        {
            var result = _primeService.IsPrime(0);
            Assert.IsFalse(result);

            result = _primeService.IsPrime(-1);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ReturnFalseGivenValueOf31()
        {

            var result = _primeService.IsPrime(-33);
            Assert.IsTrue(result);
        }



        //[DataTestMethod]
        //[DataRow(-1)]
        //[DataRow(0)]
        //[DataRow(1)]
        //public void ReturnFalseGivenValueLessThan2(int value)
        //{
        //    var result = _primeService.IsPrime(value);
        //    Assert.IsFalse(result, $"{value} should not be prime.");
        //}
    }
}
