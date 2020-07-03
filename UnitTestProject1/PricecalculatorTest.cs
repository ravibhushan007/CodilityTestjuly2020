using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using InterviewCodilitytcst;

namespace UnitTestProject1
{
    [TestClass]
    public class PricecalculatorTest
    {
         public readonly Dictionary<string, Dictionary<int, int>> TestInput = null;  
        public PricecalculatorTest() {
            TestInput=  new Dictionary<string, Dictionary<int, int>>(){
                                                                                    {"A",new Dictionary<int, int>(){{50,4}}
},
                                                                                    {"B",new Dictionary<int, int>(){{30,3}}},
                                                                                    {"C",new Dictionary<int, int>(){{20,1}}},
                                                                                    {"D",new Dictionary<int, int>(){{15,5}}}
                                                                         };
        }                                                                     
        [TestMethod]
        public void TotalPricewithoutpromo()
        {
            Pricecalculator obj = new Pricecalculator();
            int totaolprice= obj.TotalPrice(TestInput);
            Assert.Equals(300, totaolprice);

        }
        [TestMethod]
        public void TotalPricewithpromo()
        {
            Pricecalculator obj = new Pricecalculator();
            int totaolprice = obj.TotalPrice(TestInput,true, "InstantPromo");
            Assert.Equals(300, totaolprice);
        }
    }
}
