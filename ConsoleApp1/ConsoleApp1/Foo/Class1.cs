using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Foo
{
    class Class1
    {
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public int MyProperty2 { get; internal set; }
    }
}
