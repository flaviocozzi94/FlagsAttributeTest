using System;
using System.Collections.Generic;
using System.Text;
using static FlagsAttributeTest.Enumerator;

namespace FlagsAttributeTest
{
    public class User
    {
        public string Name { get; set; } = "Flavio";
        public Permission Permission { get; set; }
    }
}
