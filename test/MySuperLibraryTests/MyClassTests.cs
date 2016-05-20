using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using MySuperLibrary;

namespace MySuperLibraryTests
{
    public class MyClassTests
    {
        [Fact]
        public void ShouldDoStuff()
        {
            Assert.True(new MyClass().DoStuff());
        }
    }
}
