using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Taps;

namespace TapParserTests
{
    [TestFixture]
    public class TapParserTests
    {

        [Test]
        public void Method_Name()
        {
            // arrange
            var sut = new TAPParser();
            
            // act
            sut.ParseLine("1..10");


            // assert

        }
		
    }
}
