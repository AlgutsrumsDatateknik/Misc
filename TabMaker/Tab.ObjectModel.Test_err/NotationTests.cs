using System;
using System.Collections.Generic;
using System.Text;
using NUnit;
using NUnit.Framework;
using Tab.ObjectModel.Models;

namespace Tab.ObjectModel.Test
{
    public class NotationTests
    {

        [TestCase("12b14", 12, TabOperation.Bend, 14)]
        public static void ParseNotationTest(string input, int fret, TabOperation op, int destFret)
        {
            var not = Notation.Parse(input);
            
            Assert.AreEqual(fret, not.Fret);
            Assert.AreEqual(op, not.Operation);
            Assert.AreEqual(destFret, not.DestinationFret);
        }
    }
}
