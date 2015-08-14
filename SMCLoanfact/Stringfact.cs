using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace SMCLoanfact{
    public class Stringfact    {
        public class LengthProperty        {

            [Fact]
            public void EmptyString_ShouldHaveZeroLength()
            {
                // arrange
                string s = string.Empty;

                // act!
                int n = s.Length;

                // assert
                Assert.Equal(0, n);
            }
        }

    }
}
