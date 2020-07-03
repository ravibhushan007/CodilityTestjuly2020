using System;
using System.Collections.Generic;

namespace InterviewCodilitytcst
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<int, int>> TestInput1 = new Dictionary<string, Dictionary<int, int>>(){
                                                                                    {"A",new Dictionary<int, int>(){{50,1}}},
                                                                                    {"B",new Dictionary<int, int>(){{30,1}}},
                                                                                    {"C",new Dictionary<int, int>(){{20,1}}},
                                                                                    };
            Dictionary<string, Dictionary<int, int>> TestInput2 = new Dictionary<string, Dictionary<int, int>>(){
                                                                                    {"A",new Dictionary<int, int>(){{50,5}}},
                                                                                    {"B",new Dictionary<int, int>(){{30,5}}},
                                                                                    {"C",new Dictionary<int, int>(){{20,1}}},
                                                                                     };

            
            Dictionary<string, Dictionary<int, int>> TestInput3 = new Dictionary<string, Dictionary<int, int>>(){
                                                                                    {"A",new Dictionary<int, int>(){{50,3}}},
                                                                                    {"B",new Dictionary<int, int>(){{30,5}}},
                                                                                    {"C",new Dictionary<int, int>(){{20,1}}},
                                                                                    {"D",new Dictionary<int, int>(){{15,1}}} };


            Invoice(TestInput1);
            Invoice(TestInput2,true, "InstantPromo");
            Invoice(TestInput3,true, "InstantPromo");



        }

        public static void Invoice(Dictionary<string, Dictionary<int, int>> orderlist, bool ispromoapplied = false, string PromoType="")
        {
            int Total1 = Pricecalculator.TotalPrice(orderlist, ispromoapplied, PromoType);
            Console.WriteLine(Total1.ToString());
            int Total2 = Pricecalculator.TotalPrice(orderlist, ispromoapplied, PromoType);
            Console.WriteLine(Total2.ToString());
            int Total3 = Pricecalculator.TotalPrice(orderlist, ispromoapplied, PromoType); 
            Console.WriteLine(Total3.ToString());
        }
    }
}
