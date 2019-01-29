using Newtonsoft.Json;
using NUnit.Framework;
using TabMaker.Model.Models;

namespace TabMaker.Model.Test
{
    public class NotationTests
    {

        [TestCase("12b14", 12, TabOperation.Bend, 14)]
        [TestCase("2h5", 2, TabOperation.HammerOn, 5)]
        [TestCase("9", 9, TabOperation.None, null)]
        [TestCase("x", null, TabOperation.Muted, null)]
        [TestCase("9b11", 9, TabOperation.Bend, 11)]
        [TestCase("3/8", 3, TabOperation.SlideUp, 8)]
        [TestCase(@"12\8", 12, TabOperation.SlideDown, 8)]
        [TestCase("13v", 13, TabOperation.Vibrato, null)]
        [TestCase("7t12", 7, TabOperation.Tap, 12)]
        public static void ParseNotationTest(string input, int? fret, TabOperation op, int? destFret)
        {
            var not = Notation.Parse(input);
            
            Assert.AreEqual(fret, not.Fret);
            Assert.AreEqual(op, not.Operation);
            Assert.AreEqual(destFret, not.DestinationFret);

            Assert.AreEqual(input, not.ToString());
        }

        [TestCase(12, TabOperation.Bend, 14)]
        [TestCase(2, TabOperation.HammerOn, 5)]
        [TestCase(9, TabOperation.None, null)]
        [TestCase(null, TabOperation.Muted, null)]
        [TestCase(9, TabOperation.Bend, 11)]
        [TestCase(3, TabOperation.SlideUp, 8)]
        [TestCase(12, TabOperation.SlideDown, 8)]
        [TestCase(13, TabOperation.Vibrato, null)]
        [TestCase(7, TabOperation.Tap, 12)]
        public static void SerializeNotationTest(int? fret, TabOperation op, int? destFret)
        {
            var n = new Notation
            {
                Fret = fret,
                Operation = op,
                DestinationFret = destFret
            };
            var json = JsonConvert.SerializeObject(n);
            var ob = JsonConvert.DeserializeObject<Notation>(json);

            Assert.AreEqual(fret, ob.Fret);
            Assert.AreEqual(destFret, ob.DestinationFret);
            Assert.AreEqual(op, ob.Operation);
        }

        public static void SerializeAllTest(int? fret, TabOperation op, int? destFret)
        {

        }
    }
}
