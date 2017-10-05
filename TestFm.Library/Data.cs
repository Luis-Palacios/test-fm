using System;
using System.Collections;
using System.Collections.Generic;

namespace TestFm.Library
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
