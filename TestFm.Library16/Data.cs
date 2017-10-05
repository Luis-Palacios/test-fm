using System;
using System.Collections.Generic;

namespace TestFm.Library16
{
    public class Data
    {
        public IEnumerable<string> GetData()
        {
            return new List<string>
            {
                "foo", "bar"
            };
        }
    }
}
