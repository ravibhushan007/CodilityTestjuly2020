using System;
using System.Collections.Generic;

namespace InterviewCodilitytcst
{
    class Program
    {
        static void Main(string[] args)
        {
            var TestInput1 = new Dictionary<string, Dictionary<int, int>>(){
                                                                                    {"A",new Dictionary<int, int>(){{50,1}}},
                                                                                    {"B",new Dictionary<int, int>(){{30,1}}},
                                                                                    {"C",new Dictionary<int, int>(){{20,1}}},
                                                                                    };
            var TestInput2 = new Dictionary<string, Dictionary<int, int>>(){
                                                                                    {"A",new Dictionary<int, int>(){{50,5}}},
                                                                                    {"B",new Dictionary<int, int>(){{30,5}}},
                                                                                    {"C",new Dictionary<int, int>(){{20,1}}},
                                                                                     };

            
           var TestInput3 = new Dictionary<string, Dictionary<int, int>>(){
                                                                                    {"A",new Dictionary<int, int>(){{50,3}}},
                                                                                    {"B",new Dictionary<int, int>(){{30,5}}},
                                                                                    {"C",new Dictionary<int, int>(){{20,1}}},
                                                                                    {"D",new Dictionary<int, int>(){{15,1}}} };


            Invoice(TestInput1);
            Invoice(TestInput2,true, "InstantPromo");
            Invoice(TestInput3,true, "InstantPromo");



            Console.ReadLine();
        }

        public static void Invoice(Dictionary<string, Dictionary<int, int>> orderlist, bool ispromoapplied = false, string PromoType="")
        {
            try
            {
                int Total = Pricecalculator.TotalPrice(orderlist, ispromoapplied, PromoType);
                Console.WriteLine("Total price :" + Total.ToString());
            }catch(Exception ex)
            {
                Console.WriteLine("Sorry ! Something is wrong. Error :"+ ex.Message);
            };
        }
    }
}
