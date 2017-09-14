using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using PrimitiveObsession;

namespace PrimitiveObsessionUnitTests
{
    [TestClass]
    public class JsonMakerTests
    {
        private class Thing
        {
            public string name { get; set; }
            public string color { get; set; }
            public string type { get; set; }
            public int quantity { get; set; }
            public int size { get; set; }
        }

        [TestMethod]
        public void MakesTheJson()
        {
            var name = "bigOkayBlueThing";
            var color = "Blue";
            var type = "Okay";
            var quantity = 7;
            var size = 3;
            var expected = JObject.FromObject(new Thing { name = name, color = color, type = type, quantity = quantity, size = size });

            var json = JsonMaker.MakeJson(name, type, color, size, quantity);
            var parsedJson = JObject.Parse(json);

            Assert.AreEqual(expected["name"], parsedJson["name"]);
            Assert.AreEqual(expected["color"], parsedJson["color"]);
            Assert.AreEqual(expected["type"], parsedJson["type"]);
            Assert.AreEqual(expected["quantity"], parsedJson["quantity"]);
            Assert.AreEqual(expected["size"], parsedJson["size"]);
        }
    }
}
