using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TestFm.Library
{
    public class Data
    {
        public IEnumerable<string> GetData()
        {
            var context = new TestContext();
            return context.Humans.Select(h => h.Name).ToList();
        }
    }
}
