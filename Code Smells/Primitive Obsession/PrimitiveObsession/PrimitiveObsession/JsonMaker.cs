using System;
using System.Collections.Generic;
using System.Text;

namespace PrimitiveObsession
{
    public static class JsonMaker
    {
        // supported sizes: small = 1, medium = 2, large = 3
        // types: cool, nice, awesome, okay
        public static string MakeJson(string name, string type, string color, int size, int quantity)
        {
            var jsonContents =
                string.Format(
                    "\"name\":\"{0}\",\"type\":\"{1}\",\"color\":\"{2}\",\"size\":{3},\"quantity\":{4}", 
                    name, type, color, size, quantity);
            var json = "{" + jsonContents + "}";
            return json;
        }
    }
}
