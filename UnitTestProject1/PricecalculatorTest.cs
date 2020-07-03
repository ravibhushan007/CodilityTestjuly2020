using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using InterviewCodilitytcst;

namespace UnitTestProject1
{
    [TestClass]
    public class PricecalculatorTest
    {
         public readonly Dictionary<string, Dictionary<int, int>> TestInput1, TestInput2 , TestInput3 = null;
       
        public PricecalculatorTest() {
            TestInput1 = new Dictionary<string, Dictionary<int, int>>();
                                                                                    
            TestInput1.Add("A", new Dictionary<int, int>() { { 50, 1 } });
            TestInput1.Add("B", new Dictionary<int, int>() { { 30, 1 } });
            TestInput1.Add("C", new Dictionary<int, int>() { { 20, 1 } });
            TestInput2 = new Dictionary<string, Dictionary<int, int>>(){
                                                                                    {"A",new Dictionary<int, int>(){{50,5}}},
                                                                                    {"B",new Dictionary<int, int>(){{30,5}}},
                                                                                    {"C",new Dictionary<int, int>(){{20,1}}}
                                                                                     };

            TestInput3 = new Dictionary<string, Dictionary<int, int>>(){
                                                                                    {"A",new Dictionary<int, int>(){{50,3}}},
                                                                                    {"B",new Dictionary<int, int>(){{30,5}}},
                                                                                    {"C",new Dictionary<int, int>(){{20,1}}},
                                                                                    {"D",new Dictionary<int, int>(){{15,1}}} };

        }
       [TestMethod]
        public void TotalPricewithoutpromo()
        {
            Pricecalculator obj = new Pricecalculator();
            int totaolprice= obj.TotalPrice(TestInput1);
            Assert.Equals(100, totaolprice);

        }
        [TestMethod]
        public void TotalPricewithpromo()
        {
            Pricecalculator obj = new Pricecalculator();
            int totaolprice = obj.TotalPrice(TestInput2,true, "InstantPromo");
            Assert.Equals(370, totaolprice);
            int totaol = obj.TotalPrice(TestInput3, true, "InstantPromo");
            Assert.Equals(280, totaol);
        }
    }
}
