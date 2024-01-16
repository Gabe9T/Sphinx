using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sphinx.Models;

namespace Sphinx.TestTools
{
    [TestClass]
    public class SphinxRiddlesTests
    {
        [TestMethod]
        public void GetRiddle_ReturnsRiddleString_String()
        {
            //Arrange
            SphinxRiddles sphinxRiddles = new SphinxRiddles();
            //Act
            string newRiddle = SphinxRiddles.GetRiddle(1);
            //Assert
            Assert.AreEqual(typeof(String), newRiddle().GetType());
        }
    }
}


// string newRiddle = SphinxRiddles.GetRiddle(1);
// string riddleAnswer = SphinxRiddles.GetAnswer(1);

// get user input
// if user input is riddleAnswer === yay!
// else "get eaten"