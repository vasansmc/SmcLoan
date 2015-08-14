using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SMCLoanfact
{
 
  // one class--------
  
  //public  class ParallelFacts_1
  //  {
  //   [Fact]
  //      [Trait("category", "para1")]
  //      public void ThreeSesc()
  //      {
  //          System.Threading.Thread.Sleep(3000);
  //      }

  //   [Fact]
  //      [Trait("category", "para1")]
  //      public void FiveSesc()
  //      {
  //          System.Threading.Thread.Sleep(5000);
  //      }
  //  }

    //--------------

// two class
    public class ParallelFacts_1
    {

        [Fact]
        [Trait("category", "para1")]
        public void ThreeSecs()
        {
            System.Threading.Thread.Sleep(3000);
        }
    }

    public class ParallelFacts_2
    {

        [Fact]
        [Trait("category", "para1")]
        public void FiveSecs()
        {
            System.Threading.Thread.Sleep(5000);
        }

    }

         
}
